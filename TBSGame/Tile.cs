using System;
using System.Drawing;
using System.Windows.Forms;

namespace TBSGame
{


    class Tile : Control
    {
        public double armorBonus;
        public int APred;
        public string name;

     
        public Tile(Image bg, int x, int y, int APred, double armorBonus, string name)
        {
            if (bg.Height != 25 || bg.Width != 25) throw new Exception(String.Format("Resource file error at {0}: Tiles need to be 25x25 \n in pixels", name));
            if ((x < 0 || x > 20) || (y < 0 || y > 20)) throw new Exception("This tile is like, out of bounds. This bug shouldnt happen at all anyway..");

            Visible = true; 
            Width = 25;
            Height = 25;
            BackgroundImage = bg;
            Location = new Point(y * 25, x * 25);
            this.APred = APred;
            this.armorBonus = armorBonus;
            this.name = name;
        }
    }
}
