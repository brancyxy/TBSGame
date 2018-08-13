using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    class Tile : System.Windows.Forms.Control
    {
   
        public double armorBonus;
        public int APred;

        public Tile(Image bg, int x, int y, int APred, double armorBonus)
        {
            BackgroundImage = bg;
            Location = new Point(x * 25, y * 25);
            this.APred = APred;
            this.armorBonus = armorBonus;
        }
    }
}
