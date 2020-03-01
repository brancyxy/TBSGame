using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TBSGame.Units;

namespace TBSGame.MapHandler
{
    class TileMap
    {
        public Tile[,] Tiles { get; private set; }

        public TileMap(char[,] map, List<TileInfo> tiles)
        {



            Tiles = null;
        }
    }
}