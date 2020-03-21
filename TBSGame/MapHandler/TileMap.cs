using System;
using System.Collections.Generic;
using System.Linq;
using TBSGame.Units;

namespace TBSGame.MapHandler
{
    class TileMap
    {
        const string ERROR_MISSING = "Error in creating tile map: there are missing tile definitions.";
        const string ERROR_MORE = "Error in creating tile map: there are multiple tile definitions for a tile";
        public Tile[,] Tiles { get; private set; }
        public List<TileInfo> tileInfos;

        public TileMap(char[,] map, List<TileInfo> tiles)
        {
            Tiles = new Tile[20, 20];
            tileInfos = tiles;

            for (byte line = 0; line < Tiles.GetLength(0); line++)
                for (byte column = 0; column < Tiles.GetLength(1); column++)
                {
                    TileInfo ti;

                    try { ti = tiles.SingleOrDefault(tileInfo => tileInfo.Character == map[line, column]); }
                    catch (Exception) { throw new Exception(ERROR_MORE); }

                    if (ti.Equals(default(TileInfo))) throw new Exception(ERROR_MISSING);

                    var x = Convert.ToByte(column + 1);
                    var y = Convert.ToByte(line + 1);

                    if(ti is TownInfo) Tiles[line, column] = new Town(x, y, ti as TownInfo);
                    else Tiles[line, column] = new Tile(x, y, ti);
                }

        }
    }
}