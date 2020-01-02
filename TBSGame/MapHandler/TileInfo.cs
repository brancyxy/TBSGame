using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    struct TileInfo
    {
        public char chr;
        public int APred;
        public double armorBonus;
        public string name;
        public string imgFN;

        public TileInfo(char chr, int APred, double armorBonus, string name, string imgFN)
        {
            this.chr = chr;
            this.APred = APred;
            this.armorBonus = armorBonus;
            this.name = name;
            this.imgFN = imgFN;
        }
       /*public TileInfo(string tile)
        {

        }*/
    }
}
