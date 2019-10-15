using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    class Unit : Control
    {
        public UnitInfo stats;
        public int x;
        public int y;
        public bool owner = false;
        public int currHP;
        public int currAP;
        public double dmgRed;
        public bool attacked = false;

        public Unit(UnitInfo ui, int x, int y,Tile t)
        {
            dmgRed = t.armorBonus;
            stats = ui;

            Width = 15;
            Height = 25;
            Visible = true;

            currHP = ui.MaxHP;
            currAP = ui.MaxAP;
            BackgroundImage = ui.Texture;
            this.x = x;
            this.y = y;

            Location = new Point(5 + ((x - 1) * 25), ((y - 1) * 25));
        }

    }

}