using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TBSGame
{
    public partial class GameWindow : Form
    {
        Random r;
        public int currentPlayer = 0;
        Player[] players = new Player[2];

        Map map;
        UnitInfo selectedRec;
        Unit selectedUnit;
        public GameWindow()
        {
            InitializeComponent();
        }

        void SelectMap(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "|map.YFY"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] pName = new string[2];
                pName[0] = (p1NameBox.Text != "") ? p1NameBox.Text : "Player 1";
                pName[1] = (p2NameBox.Text != "") ? p2NameBox.Text : "Player 2";
                FileInfo file = new FileInfo(ofd.FileName);

                try
                {
                    map = new Map(File.ReadMap(file.FullName), file.DirectoryName);

                    List<TileInfo> tileInfos = File.GetTiles();

                    map.AddTiles(tileInfos);

                    Town[] towns = File.GetTown();
                    Image bg = GetTownBG(tileInfos, towns);

                    AddTiles(towns, bg);

                    List<UnitInfo> unitInfos = File.GetUnitInfos(map);
                    for (int i = 0; i < players.Length; i++)
                    {
                        towns[i].unitInfos = unitInfos;
                        players[i] = new Player(pName[i], towns[i]);
                    }

                    for (int i = 0; i < unitInfos.Count; i++)
                    {
                        var rec = new Recruiter(unitInfos[i], i % 6, i / 6);
                        rec.Click += new EventHandler(ClickRecruiter);
                        recruitArea.Controls.Add(rec);

                    }

                    {
                        mapSelector.Dispose();
                        mapSelector.SendToBack();
                        mapSelector.Visible = false;
                        logger.Text = "Map loaded succesfully!";
                    }  //map selector removal 

                    NewTurn();
                    endTurnButton.Click += new EventHandler(NewTurn);
                    endTurnButton.Visible = true;
                    recruit.Click += new EventHandler(Recruit);

                }
                catch (Exception ex)
                {
                    logger.Text += Environment.NewLine + ex.Message;
                }

            }
        }
        private void Recruit(object sender, EventArgs s)
        {

            if (players[currentPlayer].town.rec) logger.Text += Environment.NewLine + "Already recruiting a unit.";
            else if (CheckTile(players[currentPlayer].town.x, players[currentPlayer].town.y) ==1) logger.Text += Environment.NewLine + "Unit at town, can't recruit";
            else
            {
                logger.Text += string.Format(Environment.NewLine + "Recruiting {0}, process takes {1} turns", selectedRec.name, selectedRec.recTime);
                players[currentPlayer].town.rec = true;
                int x = players[currentPlayer].town.x;
                int y = players[currentPlayer].town.y;
                players[currentPlayer].town.recruit = new Unit(selectedRec, x+1, y+1, map.tiles[x,y]);
            }
        }

        private void NewTurn()
        {
            players[currentPlayer].town.owner = true;

            PlayerNameDisplay.Text = players[currentPlayer].name;
            MessageBox.Show(string.Format("{0}'s turn", players[currentPlayer].name), "New turn");
        }

        private void NewTurn(object sender, EventArgs s)
        {
            foreach (var p in players)
            {
                p.town.SendToBack();
            }
            foreach (var t in map.tiles)
            {
                t.SendToBack();
            }

            Devisualize();
            if (players[currentPlayer].town.rec)
            {
                players[currentPlayer].town.turns++;
                if (players[currentPlayer].town.RecruitDone())
                {
                    Unit u = players[currentPlayer].town.recruit;
                    u.Click += new EventHandler(ClickUnit);
                    players[currentPlayer].ownedUnits.Add(u);
                    gameArea.Controls.Add(u);
                }
            }
            currentPlayer = (currentPlayer + 1) % 2;
            foreach (var u in players[currentPlayer].ownedUnits)
            {
                var ui = u.stats;
                u.owner = true;
                u.currAP = ui.maxAP;
                u.BackColor = Color.Green;
                u.attacked = false;
            }

            players[currentPlayer].town.owner = true;
            if (players[currentPlayer].town.currHP + players[currentPlayer].town.reg > players[currentPlayer].town.maxHP) players[currentPlayer].town.currHP = players[currentPlayer].town.maxHP;
            else players[currentPlayer].town.currHP += players[currentPlayer].town.reg;

            foreach (var u in players[(currentPlayer + 1) % 2].ownedUnits)
            {
                u.owner = false;
                u.BackColor = Color.Red;
            }
            players[(currentPlayer + 1) % 2].town.owner = false;

            PlayerNameDisplay.Text = players[currentPlayer].name;
            MessageBox.Show(string.Format("{0}'s turn", players[currentPlayer].name), "New turn");
        }

        void ClickUnit(object sender, EventArgs s)
        {
            Type t = sender.GetType();
            if (t == typeof(Unit))
            {
                var unit = sender as Unit;
                var st = unit.stats;
                Devisualize();
                selectedUnit = unit;
                unitCoords.Text = string.Format("{0};{1}", unit.x, unit.y);
                unitNameDisplay.Text = unit.Name;
                unitHPbar.Maximum = st.maxHP;
                unitHPbar.Value = unit.currHP;
                unitHPdisplay.Text = Convert.ToString(unit.currHP + "/" + st.maxHP);
                unitDMGdisplay.Text = Convert.ToString(st.minDMG + "-" + st.maxDMG);
                if (unit.owner)
                {

                    unitAPbar.Maximum = st.maxAP;
                    unitAPbar.Value = unit.currAP;
                    unitAPdisplay.Text = Convert.ToString(unit.currAP + "/" + st.maxAP);
                    unitAPbar.Visible = true;
                    unitAPdisplay.Visible = true;
                    moveArea.Visible = true;
                }
                else
                {
                    unitAPbar.Visible = false;
                    unitAPdisplay.Visible = false;
                    APIcon.Visible = false;
                }
                unitDescDisplay.Text = st.description;



                unitInfo.Visible = true;

            }
            else throw new Exception("This was supposed to be an unit click event");
        }
        public void ClickRecruiter(object sender, EventArgs s)
        {
            Type t = sender.GetType();
            if (t == typeof(Recruiter))
            {
                var unit = (sender as Recruiter).unit;
                selectedRec = unit;

                recruitInfo.Visible = false;
                recUnitName.Text = unit.name;
                recUnitHP.Text = Convert.ToString(unit.maxHP);
                recUnitDMG.Text = Convert.ToString(unit.minDMG + " - " + unit.maxDMG);
                recUnitAP.Text = Convert.ToString(unit.maxAP);
                recUnitTime.Text = string.Format("Recruit time: {0} turn(s)", unit.recTime);
                recruitInfo.Visible = true;
            }
            else throw new Exception("This is supposed to be a recruit button click");
        }

        Image GetTownBG(List<TileInfo> tileInfos, Town[] towns)
        {
            bool town = false;
            foreach (var ti in tileInfos)
            {
                if ((map.charMap[towns[0].x, towns[0].y] == ti.chr && ti.name.ToLower() == "town") && (map.charMap[towns[1].x, towns[1].y] == ti.chr && ti.name.ToLower() == "town") && !town)
                {
                    town = true;
                    Image bg = Image.FromFile(map.mapFolder + ti.imgFN);
                    if (bg.Height != 25 || bg.Width != 25) throw new Exception(String.Format("Resource file error at {0}: Tiles need to be 25x25 \n in pixels", ti.name));
                    return bg;
                }
            }
            throw new Exception("Town description error: the town coordinates in the map don't match coordinates given in the file");
        }

        void AddTiles(Town[] towns, Image bg)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (!((i == towns[0].x && j == towns[0].y) || (i == towns[1].x && j == towns[1].y)))
                    {
                        map.tiles[i, j].Click += new EventHandler(ClickTile);
                        gameArea.Controls.Add(map.tiles[i, j]);
                    }
                }
            }
            for (int i = 0; i < towns.Length; i++)
            {
                towns[i].BackgroundImage = bg;
                towns[i].Click += new EventHandler(ClickTown);
                gameArea.Controls.Add(towns[i]);
            }
        }

        void ClickTown(object sender, EventArgs e)
        {
            Type t = sender.GetType();
            if (t == typeof(Town))
            {
                var town = (sender as Town);

                Devisualize();

                townHPdisplay.Text = Convert.ToString(town.currHP + "/" + town.maxHP);
                townHPbar.Maximum = town.maxHP;
                townHPbar.Value = town.currHP;
                townCoords.Text = Convert.ToString(town.Location.X / 25 + 1) + ";" + Convert.ToString(town.Location.Y / 25 + 1);
                BarColorSwitch.SetBarColor(ref townHPbar);

                townMenu.Visible = true;
                if (town.owner == true)
                {
                    recruitArea.Visible = true;
                }
            }
            else throw new Exception("This is meant to be a town click event.");
        }

        void Devisualize()
        {
            moveArea.Visible = false;
            townMenu.Visible = false;
            unitInfo.Visible = false;
            tileInfo.Visible = false;
            recruitArea.Visible = false;
            recruitInfo.Visible = false;
        }

        void ClickTile(object sender, EventArgs s)
        {
            Type t = sender.GetType();
            if (t == typeof(Tile))
            {
                var tile = (sender as Tile);

                Devisualize();

                tileName.Text = tile.name;
                tileImage.BackgroundImage = tile.BackgroundImage;
                tileAPrate.Text = Convert.ToString(tile.APred);
                tileDEFrate.Text = Convert.ToString(tile.armorBonus * 100) + "%";
                tileCoords.Text = Convert.ToString(tile.Location.X / 25 + 1) + ";" + Convert.ToString(tile.Location.Y / 25 + 1);
                tileInfo.Visible = true;
            }
            else throw new Exception("This is meant to be a tile click event.");
        }

        void Action(object sender, EventArgs e)
        {
            int x, y,s;
            try
            {
                r = new Random();
                x = int.Parse(moveX.Text);
                y = int.Parse(moveY.Text);

                if (!((x == selectedUnit.x-1 || x == selectedUnit.x + 1)||(y == selectedUnit.y - 1 || y == selectedUnit.y + 1))) throw new Exception("Must write coordinates of a neighbouring tile");
                if ((x <= 0 || x >= 21) || (y <= 0 || y >= 21)) Log("Coordinates are out of bounds");
                s = CheckTile(x, y);

                UnitInfo ui = selectedUnit.stats;
                int dmg = r.Next(ui.minDMG, ui.maxDMG);

                switch (s)
                {
                    case 0:
                        if (selectedUnit.currAP >= map.tiles[y - 1, x - 1].APred)
                        {
                            selectedUnit.currAP -= map.tiles[y - 1, x - 1].APred;
                            int a = selectedUnit.currAP;
                            selectedUnit.dmgRed = map.tiles[y - 1, x - 1].armorBonus;
                            selectedUnit.x = x;
                            selectedUnit.y = y;
                            selectedUnit.Location = new Point(5 + ((x - 1) * 25), ((y - 1) * 25));
                            {
                                Devisualize();
                                unitCoords.Text = string.Format("{0};{1}", x, y);
                                unitAPdisplay.Text = Convert.ToString(a + "/" + ui.maxAP);
                                unitAPbar.Value = a;
                                unitAPbar.Visible = true;
                                unitAPdisplay.Visible = true;
                                moveArea.Visible = true;
                                unitInfo.Visible = true;
                            }
                        }
                        else Log("Not enough AP");
                        break;
                    case 1:
                        if (ui.type == 1)
                        {
                            foreach (var u in players[currentPlayer].ownedUnits)
                            {
                                UnitInfo sui = u.stats;
                                if ((u.x == x && u.y == y))
                                {
                                    if (u.currHP < sui.maxHP)
                                    {
                                        if (!selectedUnit.attacked)
                                        {
                                            selectedUnit.attacked = true;
                                            u.currHP += dmg;
                                            if (u.currHP > sui.maxHP) u.currHP = sui.maxHP;
                                            Log(string.Format("Healed for {0} health!", dmg));
                                        }
                                        else Log("Unit already healed this turn");
                                    }
                                    else Log("Unit full HP,can't heal");
                                }
                            }
                        }
                        else Log("Not a healer, can't heal");
                        break;
                    case 2:
                        if (ui.type != 1)
                        {
                            if (selectedUnit.attacked) Log("Unit already attacked this turn");
                            else
                            {
                                foreach (var u in players[(currentPlayer + 1) % 2].ownedUnits)
                                {
                                    if (u.x == x && u.y == y)
                                    {
                                        u.currHP -= (int)(dmg - (dmg * u.dmgRed));
                                        selectedUnit.attacked = true;
                                        if (u.currHP < 0)
                                        {
                                            players[(currentPlayer + 1) % 2].ownedUnits.Remove(u);
                                            u.Location = new Point(9999,9999);
                                            u.x = -1;
                                            u.y = -1;
                                        }
                                        Log(string.Format("Hit {0} for {1} damage!", u.Name, (int)(dmg - (dmg * u.dmgRed))));
                                    }
                                }
                            }
                        }
                        else Log("Unit is a healer, can't attack enemies");
                        break;
                    case 3:
                        Log("Can't return to town.");
                        break;
                    case 4:
                        if (ui.type != 1)
                        {
                            if (selectedUnit.attacked) Log("Unit already attacked this turn");
                            else
                            {
                                players[(currentPlayer + 1) % 2].town.currHP -= dmg;
                                if (players[(currentPlayer + 1) % 2].town.currHP <= 0) Win();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(FormatException)) logger.Text += Environment.NewLine + "Invalid coordinates";
                else logger.Text += Environment.NewLine +ex.Message;
            }

        } //clean this up, prune units correctly

        private void Win()
        {
            MessageBox.Show(string.Format("{0} wins!", players[currentPlayer].name), "Congratulations!");
            map = null;
            players = null;
            Devisualize();
            gameArea.Visible = false;
            topPanel.Visible = false;
            infoArea.Visible = false;
        }

        void Log(string m)
        {
            throw new Exception(m);
        }

        int CheckTile(int x, int y)
        {
            foreach (var u in players[currentPlayer].ownedUnits) if (u.x == x && u.y == y) return 1;
            foreach (var u in players[(currentPlayer + 1) % 2].ownedUnits) if (u.x == x && u.y == y) return 2;
            if (players[currentPlayer].town.x+1 == x && players[currentPlayer].town.y+1 == y) return 3;
            if (players[(currentPlayer + 1) % 2].town.x+1 == x && players[(currentPlayer + 1) % 2].town.y+1 == y) return 4;
            return 0;
        }
    }
}