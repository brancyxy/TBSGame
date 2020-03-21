﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TBSGame.MapHandler;
using TBSGame.Panels;
using TBSGame.Units;

namespace TBSGame.Menus
{
    public partial class GameWindow : Form
    {
        private Map map;
        private TileInfoPanel tileInfo;
        private TownPanel townArea;
        private UnitInfoPanel unitInfo;

        private ActionButton[] actionButtons;

        private byte currentPlayer;
        Player[] players;

        private Town selectedTown;
        private Unit selectedUnit;

        public GameWindow(bool useFullScreen)
        {
            InitializeComponent();
            InitializeButtons();
            if (useFullScreen) WindowState = FormWindowState.Maximized;

            Scale(Utils.scale);
            ScaleFontSize(Utils.scale.Height);

            map = new Map();

            AddPlayers();
            AddPanels();
            AddTiles();
            ClearMenuView();

            PlayerNameDisplay.Text = "Player " + (currentPlayer + 1);

        }

        /// <summary>
        /// Shows the unit click menu
        /// </summary>
        private void ClickUnit(object sender, EventArgs s)
        {
            selectedUnit = sender as Unit;

            ClearMenuView();

            unitInfo.UnitClick(selectedUnit);
            unitInfo.Visible = true;

            if ((sender as Unit).ownerPlayer == currentPlayer)
                CenterActionButtonsAroundSelectedUnit();

        }

        private void CenterActionButtonsAroundSelectedUnit()
        {
            for (int direction = 0; direction < actionButtons.Length; direction++)
            {
                actionButtons[direction].CenterAroundUnit(selectedUnit.Coords);
                actionButtons[direction].BringToFront();
                actionButtons[direction].TileStatus = CheckTile(actionButtons[direction].Coords);
                actionButtons[direction].Visible = true;
            }
        }

        /// <summary>
        /// Checks a tile if there's an unit or town there and is it an ally or not.
        /// </summary>
        /// <param name="coords">The location of the tile</param>
        /// <returns></returns>
        private TileStatus CheckTile(Coordinate coords)
        {
            if (players[currentPlayer].OwnedUnits.Exists(x => x.Coords == coords)) 
                return TileStatus.ALLY;

            for (int player = 0; player < players.Length; player++)
                if (player != currentPlayer)
                    for (int unit = 0; unit < players[player].OwnedUnits.Count; unit++)
                        if (players[player].OwnedUnits[unit].Coords == coords)
                            return TileStatus.ENEMY; 


            for (byte line = 0; line < map.TileMap.Tiles.GetLength(0); line++)
                for (byte column = 0; column < map.TileMap.Tiles.GetLength(1); column++)
                    if (map.TileMap.Tiles[line, column] is Town && map.TileMap.Tiles[line, column].Coords == coords)
                    {
                        if ((map.TileMap.Tiles[line, column] as Town).ownerPlayer == currentPlayer) 
                            return TileStatus.TOWN_ALLY;
                        else return TileStatus.TOWN_ENEMY;
                    }

            return TileStatus.EMPTY;
        }

        /// <summary>
        /// Adds the tiles of the map, also centers the map area for rounding the tiles
        /// </summary>
        private void AddTiles()
        {
            for (byte line = 0; line < map.TileMap.Tiles.GetLength(0); line++)
                for (byte column = 0; column < map.TileMap.Tiles.GetLength(1); column++)
                {
                    gameArea.Controls.Add(map.TileMap.Tiles[line, column]);
                    map.TileMap.Tiles[line, column].Click += (map.TileMap.Tiles[line, column] is Town)
                        ? new EventHandler(ClickTown)
                        : new EventHandler(ClickTile);
                }

            gameArea.Size = new Size(map.TileMap.Tiles[0, 0].Width * 20,
                                     map.TileMap.Tiles[0, 0].Height * 20);

            gameArea.Location = new Point((gameAreaBorder.Height - gameArea.Size.Height) / 2,
                                          (gameAreaBorder.Width - gameArea.Size.Width) / 2);
        }

        /// <summary>
        /// Shows the tile click menu
        /// </summary>
        private void ClickTile(object sender, EventArgs s)
        {
            ClearMenuView();
            tileInfo.TileClick(sender as Tile);
            tileInfo.Visible = true;
        }

        /// <summary>
        /// Shows the town click menu
        /// </summary>
        private void ClickTown(object sender, EventArgs s)
        {
            bool isOwnerOfTown = (sender as Town).ownerPlayer == currentPlayer;
            selectedTown = sender as Town;

            ClearMenuView();
            townArea.TownClick(sender as Town, isOwnerOfTown);
            townArea.Visible = true;
        }

        /// <summary>
        /// removes visibility of all the menus
        /// </summary>
        private void ClearMenuView()
        {
            tileInfo.Visible = false;
            unitInfo.Visible = false;
            townArea.Visible = false;
            townArea.Visible = false;
            townArea.Visible = false;

            for (int direction = 0; direction < actionButtons.Length; direction++)
                actionButtons[direction].Visible = false;
        }

        /// <summary>
        /// Runs on click of the recruiter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        private void RecruiterClick(object sender, EventArgs s)
        {
            if (selectedTown.Recruiting)
            {
                Log("Already Recruiting here");
                return;
            }
            if(players[currentPlayer].OwnedUnits.Exists(x => x.Coords == selectedTown.Coords))
            {
                Log("Can't recruit unit while there's one in town.");
                return;
            }
            selectedTown.Recruit(townArea.recruitInfo.RecruitingUnit, currentPlayer);
            Log($"Started recruiting {selectedTown.recruitingUnit.UnitName}, " +
                $"process takes {townArea.recruitInfo.RecruitingUnit.RecruitTime} turns.");
            
        }

        /// <summary>
        /// Switches to the next player. If the circle is over, starts the next turn. Skips eliminated players.
        /// </summary>
        private void NextPlayer(object sender, EventArgs s)
        {
            ClearMenuView();
            currentPlayer++;

            if (!players[currentPlayer].InGame)
            {
                NextPlayer(sender,s);
                return;
            }

            if (currentPlayer == players.Length) NewTurn();

            foreach (var p in players)
                foreach (var u in p.OwnedUnits)
                {
                    u.BackColor = (u.ownerPlayer == currentPlayer)
                        ? Color.Green
                        : Color.Red;
                }
            PlayerNameDisplay.Text = "Player " + (currentPlayer + 1);
        }

        /// <summary>
        /// Regenerates action points and town health, restarts the cycle
        /// </summary>
        private void NewTurn()
        {
            currentPlayer = 0;

            for (byte line = 0; line < map.TileMap.Tiles.GetLength(0); line++)
                for (byte column = 0; column < map.TileMap.Tiles.GetLength(1); column++)
                    if (map.TileMap.Tiles[line, column] is Town && 
                       (map.TileMap.Tiles[line, column] as Town).ElapsedTurn())
                    {
                        var newUnit = (map.TileMap.Tiles[line, column] as Town).recruitingUnit;
                        newUnit.Click += new EventHandler(ClickUnit);

                        (map.TileMap.Tiles[line, column] as Town).recruitingUnit = null;

                        players[(map.TileMap.Tiles[line, column] as Town).ownerPlayer]
                            .OwnedUnits
                            .Add(newUnit);

                        
                        gameArea.Controls.Add(newUnit);
                    }

            foreach (var p in players)
                foreach (var u in p.OwnedUnits)
                {
                    u.ElapsedTurn();
                    u.BringToFront();
                }
        }

        /// <summary>
        /// Runs whenever an ActionButton is clicked. Acts accordingly to the TileStatus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="s"></param>
        private void Action(object sender, EventArgs s)
        {
            Coordinate actionLocation = (sender as ActionButton).Coords;

            switch ((sender as ActionButton).TileStatus)
            {
                case TileStatus.TOWN_ALLY:
                    {
                        Log("Can't return to town.");
                        break;
                    }
                case TileStatus.ALLY:
                    {
                        if(selectedUnit.Type == 1)
                            if (!selectedUnit.Attacked)
                            {
                                selectedUnit.Attacked = true;
                                int healPower = selectedUnit.GenerateDamage();
                                players[currentPlayer].OwnedUnits
                                                      .Single(x => x.Coords == actionLocation)
                                                      .Heal(healPower);
                                Log($"Healed {healPower}.");
                            }
                            else Log("Unit already attacked this turn.");
                        break;
                    }
                case TileStatus.EMPTY:
                    {
                        byte tileColumn = (byte)(actionLocation.X - 1);
                        byte tileRow = (byte)(actionLocation.Y - 1);
                        int ActionPointReduction = map.TileMap.Tiles[tileRow, tileColumn].ActionPointReduction;

                        if (selectedUnit.CurrentActionPoints >= ActionPointReduction)
                        {
                            selectedUnit.Coords = (sender as ActionButton).Coords;
                            selectedUnit.CurrentActionPoints -= ActionPointReduction;

                            unitInfo.UnitClick(selectedUnit);

                            CenterActionButtonsAroundSelectedUnit();
                        }
                        else Log("Not enough Action Points");
                        break;
                    }
                case TileStatus.ENEMY:
                    {
                        if (selectedUnit.Type != 1)
                            if (!selectedUnit.Attacked)
                            {
                                selectedUnit.Attacked = true;
                                int damage = selectedUnit.GenerateDamage();

                                for (int player = 0; player < players.Length; player++)
                                    if(player != currentPlayer)
                                        for (int unit = 0; unit < players[player].OwnedUnits.Count; unit++)
                                            if(players[player].OwnedUnits[unit].Coords == actionLocation)
                                            {
                                                Log($"Hit for {damage}");
                                                if (players[player].OwnedUnits[unit].Damage(damage))
                                                {
                                                    Log($"Unit killed");
                                                    players[player].OwnedUnits[unit].Dispose();
                                                    gameArea.Controls.Remove(players[player].OwnedUnits[unit]);
                                                    players[player].OwnedUnits.RemoveAt(unit);
                                                    CenterActionButtonsAroundSelectedUnit();
                                                    break;
                                                }
                                            }
                            }
                            else Log("Unit already attacked this turn.");
                        break;
                    }
                case TileStatus.TOWN_ENEMY:
                    {
                        if (selectedUnit.Type != 1)
                            if (!selectedUnit.Attacked)
                            {
                                byte tileColumn = (byte)(actionLocation.X - 1);
                                byte tileRow = (byte)(actionLocation.Y - 1);
                                if ((map.TileMap.Tiles[tileRow, tileColumn] as Town).Alive)
                                {
                                    selectedUnit.Attacked = true;
                                    int damage = selectedUnit.GenerateDamage();
                                    Log($"Hit for {damage}");
                                    if ((map.TileMap.Tiles[tileRow, tileColumn] as Town).Damage(damage))
                                    {
                                        Log($"Town destroyed");
                                        CenterActionButtonsAroundSelectedUnit();
                                        (map.TileMap.Tiles[tileRow, tileColumn] as Town).Alive = false;

                                        CheckForPlayerTowns((map.TileMap.Tiles[tileRow, tileColumn] as Town).ownerPlayer);

                                        break;
                                    }
                                }
                                else Log("Town is already destroyed");
                            }
                            else Log("Unit already attacked this turn.");
                        break;
                    }
            }
        }

        /// <summary>
        /// Checks if a player has any alive towns, if not, eliminates them.
        /// </summary>
        private void CheckForPlayerTowns(byte playerIndex)
        {
            for (byte line = 0; line < map.TileMap.Tiles.GetLength(0); line++)
                for (byte column = 0; column < map.TileMap.Tiles.GetLength(1); column++)
                {
                    if ((map.TileMap.Tiles[line, column] is Town) &&
                        (map.TileMap.Tiles[line, column] as Town).Alive &&
                        (map.TileMap.Tiles[line, column] as Town).ownerPlayer == playerIndex)
                        return;
                }
            players[playerIndex].InGame = false;
            Log($"Player {playerIndex + 1} has been eliminated");
        }

        /// <summary>
        /// Adds the movement buttons to the form
        /// </summary>
        private void InitializeButtons()
        {
            actionButtons = new ActionButton[4];

            for (int direction = 0; direction < actionButtons.Length; direction++)
            {
                actionButtons[direction] = new ActionButton((CoordinateDirection)direction);
                gameArea.Controls.Add(actionButtons[direction]);
                actionButtons[direction].Click += new EventHandler(Action);
            }
        }

        /// <summary>
        /// Adds a log in the RichTextBox as a newline
        /// </summary>
        /// <param name="text">The message</param>
        private void Log(string text)
        {
            logger.Text += Environment.NewLine + text;
        }

        /// <summary>
        /// Initializes the players array
        /// </summary>
        private void AddPlayers()
        {
            players = new Player[map.PlayerCount];
            for (int i = 0; i < players.Length; i++) players[i] = new Player();
        }

        /// <summary>
        /// Adds the selection menu panels to the right area
        /// </summary>
        private void AddPanels()
        {
            unitInfo = new UnitInfoPanel();
            infoArea.Controls.Add(unitInfo);

            townArea = new TownPanel(map.UnitInfos);
            infoArea.Controls.Add(townArea);
            townArea.recruitInfo.recruit.Click += new EventHandler(RecruiterClick);

            tileInfo = new TileInfoPanel();
            infoArea.Controls.Add(tileInfo);
        }

        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            btnEndTurn.Font = new Font(btnEndTurn.Font.FontFamily,
                                       btnEndTurn.Font.Size * height);

            logger.Font = new Font(logger.Font.FontFamily,
                                   logger.Font.Size * height);

            PlayerNameDisplay.Font = new Font(PlayerNameDisplay.Font.FontFamily,
                                              PlayerNameDisplay.Font.Size * height);

            Quit.Font = new Font(Quit.Font.FontFamily,
                                 Quit.Font.Size * height);
        }

        //make the top area move the window if in window mode
        private bool mouseDown;
        private Point lastLocation;
        private void TopField_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void TopField_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && WindowState != FormWindowState.Maximized)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X,
                    (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }
        private void TopField_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /// <summary>
        /// Prompts a MessageBox, if "yes" is pressed, quits the game.
        /// </summary>
        private void Quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to stop playing?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}