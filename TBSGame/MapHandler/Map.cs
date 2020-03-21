using System.Collections.Generic;
using System.IO;

namespace TBSGame.MapHandler
{
    class Map
    {
        public List<TileInfo> TileInfos { private set; get; }
        public TileMap TileMap { private set; get; }
        public List<UnitInfo> UnitInfos { private set; get; }
        public byte PlayerCount { private set; get; }

        public Map()
        {
            GetTileInfos();
            GetUnitInfos();
            GetTileMap();
            GetPlayerCount();
        }

        /// <summary>
        /// Reads the map file and creates the tile map from the definition
        /// </summary>
        private void GetTileMap()
        {
            char[,] tileChars = new char[20, 20];
            int line = 0;
            var sr = new StreamReader(Utils.CACHE_FOLDER_NAME + "map.txt");
            while (!sr.EndOfStream)
            {
                var tmp = sr.ReadLine();

                for (int column = 0; column < tmp.Length; column++)
                    tileChars[line, column] = tmp[column];

                line++;
            }
            sr.Close();
            TileMap = new TileMap(tileChars, TileInfos);
        }

        /// <summary>
        /// Reads the unit definition file and sets the list value
        /// </summary>
        private void GetUnitInfos()
        {
            UnitInfos = new List<UnitInfo>();
            var sr = new StreamReader(Utils.CACHE_FOLDER_NAME + "units.txt");
            while (!sr.EndOfStream)
                UnitInfos.Add(new UnitInfo(sr.ReadLine()));
            sr.Close();
        }

        /// <summary>
        /// Reads the tile definiton file and sets the list value
        /// </summary>
        private void GetTileInfos()
        {
            TileInfos = new List<TileInfo>();
            var sr = new StreamReader(Utils.CACHE_FOLDER_NAME + "tiles.txt");
            while (!sr.EndOfStream)
            {
                string dummy = sr.ReadLine();
                if (dummy.Split(';').Length == 5) TileInfos.Add(new TileInfo(dummy));
                else TileInfos.Add(new TownInfo(dummy));
            }
            sr.Close();
        }

        /// <summary>
        /// Reads the tile definiton file and sets the list value
        /// </summary>
        private void GetPlayerCount()
        {
            TileInfos = new List<TileInfo>();
            var sr = new StreamReader(Utils.CACHE_FOLDER_NAME + "meta.txt");
            PlayerCount = byte.Parse(sr.ReadLine());
            sr.Close();
        }
    }
}
