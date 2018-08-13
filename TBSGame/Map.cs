using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    class Map
    {
        public char[,] charMap = new char[20, 20];
        public List<Tile> tiles;
        private string mapFolder;

        public Map(char[,] map, string mapFolder)
        {
            charMap = map;
            this.mapFolder = mapFolder;
        }
    }
}
