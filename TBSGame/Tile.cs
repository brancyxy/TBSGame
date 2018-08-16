using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    struct TileInfo
    {
        public char chr;
        public int APred;
        public double armorBonus;
        public string name;
        public string imgFN;

        public TileInfo(char chr,int APred,double armorBonus,string name, string imgFN)
        {
            this.chr = chr;
            this.APred = APred;
            this.armorBonus = armorBonus;
            this.name = name;
            this.imgFN = imgFN;
        }
    }
    class Tile : Control
    {
        public double armorBonus;
        public int APred;
        public string name;

     
        public Tile(Image bg, int x, int y, int APred, double armorBonus, string name)
        {
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
