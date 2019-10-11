using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TBSGame
{
    class TileMap
    {
        public char[,] CharMap { get; private set; }
        public readonly string mapFolder;
        public Tile[,] tiles;

        public void AddTiles(List<TileInfo> tileInfo)
        {

            if (tileInfo.FindAll(ti => ti.name.ToLower() == "town").ToArray().Length ==0) 
                throw new Exception("There must be a town in the map");

            tiles = new Tile[20, 20];
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    foreach (var ti in tileInfo)
                    {
                        if (ti.chr == CharMap[x, y])
                        {
                            try { tiles[x, y] = (new Tile(Image.FromFile(mapFolder + ti.imgFN), x, y, ti.APred, ti.armorBonus, ti.name));     }
                            catch (Exception) { throw new Exception(string.Format("Resource file error: Tile image not found: {0}", ti.imgFN));     }
                        }
                    }
                }
            }
        }
        public TileMap(char[,] map, string mapFolder)
        {
            CharMap = map;
            this.mapFolder = mapFolder + @"\";
        }
    }
}