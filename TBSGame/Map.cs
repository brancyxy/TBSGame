using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    class Map
    {
        public char[,] charMap = new char[20, 20];
        private List<Tile> tiles = new List<Tile>();
        private readonly string mapFolder;


        public List<Tile> AddTiles(List<TileInfo> tileInfo)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    foreach (var ti in tileInfo)
                    {
                        if (ti.chr == charMap[i, j])
                        {
                            tiles.Add(new Tile(Image.FromFile(mapFolder + ti.imgFN), i,j, ti.APred, ti.armorBonus,ti.name));
                        }
                    }
                }
            }
            return tiles;
        }
        public Map(char[,] map, string mapFolder)
        {
            charMap = map;
            this.mapFolder = mapFolder;
        }
    }
}
