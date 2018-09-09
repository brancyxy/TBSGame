using System;
using System.Collections.Generic;
using System.Drawing;

namespace TBSGame
{
    class Map
    {
        public char[,] charMap;
        public readonly string mapFolder;
        public Tile[,] tiles;

        public void AddTiles(List<TileInfo> tileInfo)
        {
            { 
                var town = false;
                foreach (var t in tileInfo)
                {
                    if (t.name.ToLower() == "town") town = true;
                }
                if (town == false) throw new Exception("There must be a town in the map");
            } // town check

            tiles = new Tile[20, 20];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    foreach (var ti in tileInfo)
                    {
                        if (ti.chr == charMap[i, j])
                        {
                            try { tiles[i, j] = (new Tile(Image.FromFile(mapFolder + ti.imgFN), i, j, ti.APred, ti.armorBonus, ti.name));     }
                            catch (Exception) {    throw new Exception(string.Format("Resource file error: Tile image not found: {0}", ti.imgFN));     }
                        }
                    }
                }
            }
        }
        public Map(char[,] map, string mapFolder)
        {
            charMap = new char[20, 20];
            charMap = map;
            this.mapFolder = mapFolder + @"\";
        }
    }
}