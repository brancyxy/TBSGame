using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    public partial class GameWindow : Form
    {
        bool player; // true = p1 false = p2
        string p1Name;
        string p2Name;
        Map map;

        public GameWindow()
        {
            InitializeComponent();
            
        }

        private void SelectMap(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MAP|map.YFY"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                p1Name = (p1NameBox.Text == "") ? p1NameBox.Text : "Player 1";
                p2Name = (p2NameBox.Text == "") ? p2NameBox.Text : "Player 2";
                FileInfo file = new FileInfo(ofd.FileName);

                map = new Map(File.ReadMap(file.FullName), file.DirectoryName);
                List<Tile> tiles = map.AddTiles(File.GetTiles());

                foreach (var t in tiles)
                {
                    t.Click+= new EventHandler(ClickTile);
                    gameArea.Controls.Add(t);
                }
                {
                    mapSelector.Dispose();
                    mapSelector.SendToBack();
                    mapSelector.Visible = false;
                }  //map selector removal 
            }
        }


        void ClickTile(object sender, EventArgs s)
        {
            Type t = sender.GetType();
            if (t == typeof(Tile))
            {
                var tile = (sender as Tile);

                unitInfo.Visible = false;
                tileInfo.Visible = false;

                tileName.Text = tile.name;
                tileImage.BackgroundImage = tile.BackgroundImage;
                tileAPrate.Text = Convert.ToString(tile.APred);
                tileDEFrate.Text = Convert.ToString(tile.armorBonus * 100) + "%";
                tileCoords.Text = Convert.ToString(tile.Location.X/25+1)+";"+Convert.ToString(tile.Location.Y/25+1);
                tileInfo.Visible = true;
            }
            else throw new Exception("This is meant to be a tile click event.");
        }
    }
}
