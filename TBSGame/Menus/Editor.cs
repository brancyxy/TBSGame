using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TBSGame.MapEditor;
using TBSGame.MapHandler;

namespace TBSGame.Menus
{
    public partial class Editor : Form
    {
        private const string DEFAULT_LAYER = "Tile";

        private readonly List<UnitInfo> units;
        private readonly List<TileInfo> tiles;

        private bool placementMode;

        private readonly Dictionary<char, bool> characterMapping;

        private byte playerCount;
        private string mapName;
        private string mapCreator;

        private string selectedTileName;

        private EditorTile[,] tileLayout;
        public Editor(bool useFullScreen)
        {
            InitializeComponent();
            layerSelector.SelectedItem = DEFAULT_LAYER;
            if (useFullScreen) WindowState = FormWindowState.Maximized;

            units = new List<UnitInfo>();
            tiles = new List<TileInfo>();
            characterMapping = new Dictionary<char, bool>();

            Scale(Utils.scale);
            ScaleFontSize(Utils.scale);

            AddCharacterMap();
            AddTileMap();
        }
        // META
        /// <summary>
        /// Fills the dictionary with pairs of characters and a boolean value to determine if they can be used.
        /// Skips the semicolon.
        /// </summary>
        private void AddCharacterMap()
        {
            for (byte asciiValue = 33; asciiValue < 126; asciiValue++)
                if (asciiValue != (byte)';')
                    characterMapping.Add((char)asciiValue, false);
        }

        /// <summary>
        /// Adds the tiles to the map layer
        /// </summary>
        private void AddTileMap()
        {
            tileLayout = new EditorTile[20, 20];
            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                {
                    tileLayout[line, column] = new EditorTile(line, column);
                    tileMap.Controls.Add(tileLayout[line, column]);

                    tileLayout[line, column].MouseEnter += new EventHandler(PlaceTile);
                    tileLayout[line, column].Click += new EventHandler(delegate (object sender, EventArgs e) 
                    {
                        placementMode = !placementMode;
                        PlaceTile(sender, e);
                    });

                }

            tileMap.Size = new Size((tileLayout[0, 0].Width + 1) * 20,
                                    (tileLayout[0, 0].Height + 1) * 20);

            tileMap.Location = new Point((tileMapContainer.Height - tileMap.Size.Height) / 2,
                                          (tileMapContainer.Width - tileMap.Size.Width) / 2);
        }

        /// <summary>
        /// Removes the overlay panel and enables the editor. Also sets the map meta values.
        /// </summary>
        private void Begin(object sender, EventArgs e)
        {
            if (tbMapName.Text.Contains(';') || tbMapName.Text == "") return;
            if (tbMapCreator.Text.Contains(';') || tbMapCreator.Text == "") return;

            playerCount = (byte)nudPlayerCount.Value;
            for (byte i = 0; i < playerCount; i++)
                tileMapTownPlayerSelector.Items.Add("Player " + (i + 1));
            tileMapTownPlayerSelector.SelectedIndex = 0;

            mapName = tbMapName.Text;
            mapCreator = tbMapCreator.Text;

            Controls.Remove(newMapScreen);
            newMapScreen.Dispose();
        }

        /// <summary>
        /// Checks the TextBox if value contains a semicolon. If so changes the background color to warn the user.
        /// </summary>
        private void CheckForInvalidCharacter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = (sender as Control).Text.Contains(';')
                ? Color.Red
                : Color.White;
        }

        /// <summary>
        /// Promps a MessageBox to ask the user to quit
        /// </summary>
        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Quit editor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        private void ScaleFontSize(SizeF scale)
        {
            lbTitle.Font = new Font(lbTitle.Font.FontFamily, lbTitle.Font.Size * scale.Height);
            unitDescription.Font = new Font(unitDescription.Font.FontFamily,
                                            unitDescription.Font.Size * scale.Height);

            foreach (Control control in Controls)
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scale.Height);
        }

        /// <summary>
        /// Runs upon selecting from the left ComboBox
        /// </summary>
        private void SelectLayer(object sender, EventArgs e)
        {
            mapLayer.Visible = false;
            mapLayerMenuPanel.Visible = false;
            unitLayer.Visible = false;
            tileLayer.Visible = false;

            switch (layerSelector.SelectedItem.ToString())
            {
                case "Map":
                    {
                        mapLayer.Visible = true;
                        mapLayerMenuPanel.Visible = true;
                        break;
                    }
                case "Unit":
                    {
                        unitLayer.Visible = true;
                        break;
                    }
                case "Tile":
                    {
                        tileLayer.Visible = true;
                        break;
                    }
            }
        }

        /// <summary>
        /// Resets the placed tile if a tile of given character is deleted
        /// </summary>
        private void ResetTile(char c)
        {
            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                    if (tileLayout[line, column].Character == c)
                        tileLayout[line, column].SetTile(null, '\0');
        }

        //UNIT
        /// <summary>
        /// Adds the unit to the list if conditions are met
        /// </summary>
        private void AddUnit(object sender, EventArgs e)
        {
            foreach (var unit in units)
                if (unit.Name == tbUnitName.Text) return;

            if (tbUnitName.Text != "" &&
                !tbUnitName.Text.Contains(';') &&
                unitMinDamage.Value <= unitMaxDamage.Value &&
                pbUnitImage.Image != null &&
                unitDescription.Text != "" &&
                !unitDescription.Text.Contains(';'))
            {
                string unitName = tbUnitName.Text;
                int recruitTime = (int)unitTurnsToRecruit.Value;
                int health = (int)unitHealth.Value;
                int minDamage = (int)unitMinDamage.Value;
                int maxDamage = (int)unitMaxDamage.Value;
                int actionPoints = (int)unitActionPoints.Value;
                byte type = (byte)(unitIsHealer.Checked ? 1 : 0);
                string description = unitDescription.Text;

                units.Add(new UnitInfo(unitName, recruitTime, health, minDamage, maxDamage, 
                                       actionPoints, type, pbUnitImage.Image, description));
                dgvUnitList.Rows.Add(unitName);

                pbUnitImage.Image = null;
                unitIsImageSelected.Checked = false;
            }
        }

        /// <summary>
        /// Changes the edit mode of the unit layer
        /// </summary>
        private void ChangeUnitEditMode(object sender, EventArgs e)
        {
            btnEditUnit.Enabled = cbUnitEditMode.Checked;
            tbUnitName.Enabled = !cbUnitEditMode.Checked;
            btnAddUnit.Enabled = !cbUnitEditMode.Checked;

            dgvUnitList.ClearSelection();
        }

        /// <summary>
        /// Deletes the selected unit from the list.
        /// </summary>
        private void DeleteUnit(object sender, EventArgs e)
        { 
            if(dgvUnitList.SelectedRows.Count != 0)
            {
                string unitName = dgvUnitList.SelectedRows[0].Cells[0].Value.ToString();

                dgvUnitList.Rows.Remove(dgvUnitList.SelectedRows[0]);
                units.Remove(units.Find(x => x.Name == unitName));
            }
        }

        /// <summary>
        /// Edits the units' stats to the given new ones
        /// </summary>
        private void EditUnit(object sender, EventArgs e)
        {
            string unitName = tbUnitName.Text;
            if (units.SingleOrDefault(x => x.Name == unitName).Equals(default(UnitInfo))) return;

            int recruitTime = (int)unitTurnsToRecruit.Value;
            int health = (int)unitHealth.Value;
            int minDamage = (int)unitMinDamage.Value;
            int maxDamage = (int)unitMaxDamage.Value;
            int actionPoints = (int)unitActionPoints.Value;
            byte type = (byte)(unitIsHealer.Checked ? 1 : 0);
            string description = unitDescription.Text;

            bool newImage = pbUnitImage.Image != null;

            for (int i = 0; i < units.Count; i++)
                if(units[i].Name == unitName)
                    units[i] = new UnitInfo(unitName, recruitTime, health, minDamage, maxDamage, actionPoints,
                                            type, newImage ? pbUnitImage.Image : units[i].Texture,description);
        }

        /// <summary>
        /// Selects a unit for editing. Must be in edit mode
        /// </summary>ó
        private void SelectEditUnit(object sender, EventArgs e)
        {
            if (cbUnitEditMode.Checked)
            {
                string unitName = dgvUnitList.SelectedRows[0].Cells[0].Value.ToString();

                var selectedUnit = units.Find(x => x.Name == unitName);

                tbUnitName.Text = unitName;
                unitTurnsToRecruit.Value = selectedUnit.RecruitTime;
                unitHealth.Value = selectedUnit.Health;
                unitMinDamage.Value = selectedUnit.MinDamage;
                unitMaxDamage.Value = selectedUnit.MaxDamage;
                unitActionPoints.Value = selectedUnit.ActionPoints;
                unitIsHealer.Checked = selectedUnit.Type == 1;
                unitDescription.Text = selectedUnit.Description;
                pbUnitImage.Image = selectedUnit.Texture;
            }
        }

        /// <summary>
        /// Opens an image file 
        /// </summary>
        private void SelectUnitImage(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Supported Image Files|*.bmp;*.gif;*.jpeg;*.png;*.tiff"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbUnitImage.Image = Image.FromFile(ofd.FileName);
                    unitIsImageSelected.Checked = true;
                }
                catch (Exception) { }
            }
            else
            {
                pbUnitImage.Image = null;
                unitIsImageSelected.Checked = false;
            }
        }

        //TILE
        /// <summary>
        /// Adds the tile to the list if conditions are met
        /// </summary>
        private void AddTile(object sender, EventArgs e)
        {
            foreach (var tile in tiles)
                if (tile.Name == tbTileName.Text) return;
            if (tbTileName.Text == "" || pbTileImage.Image == null || tbTileName.Text.Contains(';')) return;

            string tileName = tbTileName.Text;
            if (!cbTileIsTown.Checked && tileName == "Town") return;

            int APred = (int)tileActionPointReduction.Value;
            double armorBonus = (double)tileArmorBonus.Value / 100;
            int townMaxHealth = (int)townHealth.Value;
            int townRegen = (int)townRegeneration.Value;
            Image texture = pbTileImage.Image;

            byte insertQuantity = cbTileIsTown.Checked
                ? playerCount
                : (byte)1;
            if (!CheckForFreeCharacters(insertQuantity))
            {
                MessageBox.Show("Max number of tiles reached.");
                return;
            }

            for (byte p = 0; p < insertQuantity; p++)
            {
                char tileCharacter = characterMapping.First(x => x.Value == false).Key;
                characterMapping[tileCharacter] = true;
                tiles.Add(cbTileIsTown.Checked
                    ? new TownInfo(tileCharacter, tileName, APred, armorBonus, texture, p, townMaxHealth, townRegen)
                    : new TileInfo(tileCharacter, tileName, APred, armorBonus, texture));
            }
            dgvTileList.Rows.Add(tileName);
            if(cbTileIsTown.Checked) tileMapTownSelector.Rows.Add(tileName);
            else tileMapTileSelector.Rows.Add(tileName);

            pbUnitImage.Image = null;
            unitIsImageSelected.Checked = false;
        }

        /// <summary>
        /// Changes the edit mode of the tile layer
        /// </summary>
        private void ChangeTileEditMode(object sender, EventArgs e)
        {
            btnEditTile.Enabled = cbTileEditMode.Checked;
            tbTileName.Enabled = !cbTileEditMode.Checked;
            btnAddTile.Enabled = !cbTileEditMode.Checked;

            dgvTileList.ClearSelection();
        }

        /// <summary>
        /// Enables or disables the town area whether the tile is marked as town or not
        /// Also forces the tile name to "Town" if it's set at such.
        /// </summary>
        private void ChangeTownMode(object sender, EventArgs e)
        {
            tileTownArea.Visible = cbTileIsTown.Checked;
            tbTileName.Text = (cbTileIsTown.Checked) ? "Town" : tbTileName.Text;
            tbTileName.Enabled = !cbTileIsTown.Checked;
        }

        /// <summary>
        /// Checks the character mapping if there are enough free characters
        /// </summary>
        private bool CheckForFreeCharacters(byte ammount)
        {
            byte sumFreeChars = 0;
            foreach (var item in characterMapping)
                sumFreeChars += (item.Value) ? (byte)0 : (byte)1;
            return sumFreeChars >= ammount;
        }

        /// <summary>
        /// Deletes the selected tile from the list.
        /// </summary>
        private void DeleteTile(object sender, EventArgs e)
        {
            if (dgvTileList.SelectedRows.Count != 0)
            {
                string tileName = dgvTileList.SelectedRows[0].Cells[0].Value.ToString();
                if (tileName == selectedTileName) selectedTileName = null;

                dgvTileList.Rows.Remove(dgvTileList.SelectedRows[0]);

                foreach (DataGridViewRow row in tileMapTileSelector.Rows)
                    if (row.Cells[0].Value.ToString() == tileName)
                        tileMapTileSelector.Rows.Remove(row);
                foreach (DataGridViewRow row in tileMapTownSelector.Rows)
                    if (row.Cells[0].Value.ToString() == tileName)
                        tileMapTownSelector.Rows.Remove(row);

                tiles.Where(x => x.Name == tileName)
                     .ToList()
                     .ForEach(x => ResetTile(x.Character));
                tiles.RemoveAll(x => x.Name == tileName);
            }
        }

        /// <summary>
        /// Edits the tile's stats to the given new ones
        /// </summary>
        private void EditTile(object sender, EventArgs e)
        {
            string tileName = tbTileName.Text;
            if (tiles.SingleOrDefault(x => x.Name == tileName).Equals(default(TileInfo))) return;
            if (!cbTileIsTown.Checked && tileName == "Town") return;

            int APred = (int)tileActionPointReduction.Value;
            double armorBonus = (double)tileArmorBonus.Value / 100;
            int townMaxHealth = (int)townHealth.Value;
            int townRegen = (int)townRegeneration.Value;

            bool newTexture = pbUnitImage.Image != null;

            for (int tile = 0; tile < tiles.Count; tile++)
                tiles[tile] = (tiles[tile] is TownInfo)
                    ? new TownInfo(tiles[tile].Character, tileName, APred, armorBonus,
                                    newTexture ? pbUnitImage.Image : tiles[tile].Texture,
                                  (tiles[tile] as TownInfo).OwnerPlayer, townMaxHealth, townRegen)
                    : new TileInfo(tiles[tile].Character, tileName, APred, armorBonus, 
                                    newTexture ? pbUnitImage.Image : tiles[tile].Texture);
        }

        /// <summary>
        /// Selects a tile for editing. Must be in edit mode
        /// </summary>
        private void SelectEditTile(object sender, EventArgs e)
        {
            if (cbTileEditMode.Checked && dgvTileList.SelectedRows.Count !=0)
            {
                string tileName = dgvTileList.SelectedRows[0].Cells[0].Value.ToString();

                var selectedTile = tiles.Find(x => x.Name == tileName);

                tbUnitName.Text = tileName;
                tileActionPointReduction.Value = selectedTile.APred;
                tileArmorBonus.Value = (decimal)selectedTile.ArmorBonus * 100;
                cbTileIsTown.Checked = selectedTile is TownInfo;
                if (cbTileIsTown.Checked)
                {
                    townHealth.Value = (selectedTile as TownInfo).MaxHealth;
                    townRegeneration.Value = (selectedTile as TownInfo).Regeneration;
                }
            }
        }

        /// <summary>
        /// Opens an image file 
        /// </summary>
        private void SelectTileImage(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "Supported Image Files|*.bmp;*.gif;*.jpeg;*.png;*.tiff"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbTileImage.Image = Image.FromFile(ofd.FileName);
                    tileIsImageSelected.Checked = true;
                }
                catch (Exception) { }
            }
            else
            {
                pbTileImage.Image = null;
                tileIsImageSelected.Checked = false;
            }
        }

        //MAP
        /// <summary>
        /// If placementMode is true, runs when mouse hovers a tile
        /// </summary>
        private void ClearTileMap(object sender, EventArgs e)
        {
            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                    tileLayout[line, column].SetTile(null, '\0');
        }

        /// <summary>
        /// If placementMode is true, runs when mouse hovers a tile
        /// </summary>
        private void PlaceTile(object sender, EventArgs e)
        {
            if (placementMode && selectedTileName != null)
            {
                int selectedPlayer = tileMapTownPlayerSelector.SelectedIndex;

                var selectedTile = tiles.Where(t => t.Name == selectedTileName).ToArray();

                if (!(selectedTile[0] is TownInfo))
                    (sender as EditorTile).SetTile(selectedTile[0].Texture, selectedTile[0].Character);
                else
                {
                    TownInfo selectedTown = selectedTile[0] as TownInfo;
                    foreach (var town in selectedTile)
                        if ((town as TownInfo).OwnerPlayer == selectedPlayer)
                            selectedTown = town as TownInfo;
                    if(VerifyNearbyTowns((sender as EditorTile).Coords))
                        (sender as EditorTile).SetTile(selectedTown.Texture, selectedTown.Character);
                }
            }
        }

        /// <summary>
        /// Prompts the player to save, checks for the conditions and does if choosen so
        /// </summary>
        private void SaveMap(object sender, EventArgs e)
        {
            const string QUESTION_TITLE = "Save";
            const string QUESTION_TEXT = "Do you want to save the map?";
            const string ERROR_TITLE = "Save";

            DialogResult answer = MessageBox.Show(QUESTION_TEXT, QUESTION_TITLE, MessageBoxButtons.YesNo);
            if (answer == DialogResult.No || answer == DialogResult.None) return;

            if (units.Count == 0)
            {
                MessageBox.Show("You must define at least one unit.", ERROR_TITLE);
                return;
            }

            char[,] tileChars = new char[20, 20];

            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                {
                    tileChars[line, column] = tileLayout[line, column].Character;
                    if (tileLayout[line, column].Character == '\0')
                    {
                        MessageBox.Show("You must define all tiles.", ERROR_TITLE);
                        return;
                    }
                }

            if (!VerifyAllPlayerTowns())
            {
                MessageBox.Show("Every player must have at least one town.", ERROR_TITLE);
                return;
            }

            Map map = new Map(units, tiles, tileChars, playerCount, mapName, mapCreator);
            map.SaveMap();

            Close();
            Application.Restart();
        }

        /// <summary>
        /// Runs when either DataGridView row is selected in the map layer
        /// </summary>
        private void SelectPlaceTile(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count == 0) return;
            selectedTileName = (sender as DataGridView).SelectedRows[0].Cells[0].Value.ToString();

            if (sender.Equals(tileMapTownSelector)) tileMapTileSelector.ClearSelection();
            else tileMapTownSelector.ClearSelection();
        }

        /// <summary>
        /// Checks if all players have at least one defined town
        /// </summary>
        private bool VerifyAllPlayerTowns()
        {
            var allTownCharacters = tiles.Where(x => x is TownInfo)
                                         .Select(x => new {
                                             x.Character,
                                             IsDefined = false})
                                         .ToDictionary(x => x.Character, x => x.IsDefined);

            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                    if (allTownCharacters.Keys.Contains(tileLayout[line, column].Character))
                        allTownCharacters[tileLayout[line, column].Character] = true;

            return !allTownCharacters.Values.Contains(false);
        }

        /// <summary>
        /// Checks for a town placed next to the already placed tiles to avoid walls
        /// </summary>
        /// <param name="coords">The coordinate of the tile</param>
        /// <returns>true if a town is not found</returns>
        private bool VerifyNearbyTowns(Coordinate coords)
        {
            Coordinate topLeft = new Coordinate((byte)(coords.X - 1), (byte)(coords.Y - 1));
            Coordinate bottomRight = new Coordinate((byte)(coords.X + 1), (byte)(coords.Y + 1));

            var towns = tiles.Where(x => x is TownInfo)
                             .Select(x => x.Character)
                             .ToArray();

            for (byte line = 0; line < tileLayout.GetLength(0); line++)
                for (byte column = 0; column < tileLayout.GetLength(1); column++)
                    if (towns.Contains(tileLayout[line, column].Character) &&
                        tileLayout[line, column].Coords.IsBetween(topLeft, bottomRight))
                        return false;

            return true;
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
    }
}
