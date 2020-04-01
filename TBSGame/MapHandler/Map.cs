using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace TBSGame.MapHandler
{
    class Map
    {
        public List<TileInfo> Tiles { private set; get; }
        public TileMap TileMap { private set; get; }
        public List<UnitInfo> Units { private set; get; }
        public byte PlayerCount { private set; get; }

        char[,] tileChars;
        readonly string mapName,
                        mapCreator;

        public void SaveMap()
        {
            SavePlayerCount();
            SaveTileInfos();
            SaveUnitInfos();
            SaveTileMap();

            ZipFile.CreateFromDirectory(Utils.EDITOR_CACHE,
                                        Utils.MAP_FOLDER + $"[{PlayerCount}] {mapName}-{mapCreator}.zip");
            Directory.Delete(Utils.EDITOR_CACHE, true);
        }

        /// <summary>
        /// Creates the map file and writes the definition
        /// </summary>
        private void SaveTileMap()
        {
            var sw = new StreamWriter(Utils.EDITOR_CACHE + "map.txt", false, Encoding.UTF8);

            for (byte line = 0; line < tileChars.GetLength(0); line++)
            {
                string currentLine = "";

                for (byte column = 0; column < tileChars.GetLength(1); column++)
                    currentLine += tileChars[column, line];

                sw.WriteLine(currentLine);
            }
            sw.Close();
        }

        /// <summary>
        /// Reads the map file and creates the tile map from the definition
        /// </summary>
        private void GetTileMap()
        {
            tileChars = new char[20, 20];
            int line = 0;
            var sr = new StreamReader(Utils.MAP_CACHE + "map.txt",Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                var tmp = sr.ReadLine();

                for (byte column = 0; column < 20; column++)
                    tileChars[line, column] = tmp[column];

                line++;
            }
            sr.Close();
            TileMap = new TileMap(tileChars, Tiles);
        }

        /// <summary>
        /// Creates the unit definiton file from the list value
        /// </summary>
        private void SaveUnitInfos()
        {
            var sw = new StreamWriter(Utils.EDITOR_CACHE + "units.txt", false, Encoding.UTF8);
            foreach (var u in Units)
            {
                sw.WriteLine(u.ToCSV());
                u.Texture.Save(Utils.EDITOR_CACHE + u.Name + Utils.EDITOR_UNIT_IMAGE_POSTFIX, ImageFormat.Png);
            }
            sw.Close();
        }

        /// <summary>
        /// Reads the unit definition file and sets the list value
        /// </summary>
        private void GetUnitInfos()
        {
            Units = new List<UnitInfo>();
            var sr = new StreamReader(Utils.MAP_CACHE + "units.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
                Units.Add(new UnitInfo(sr.ReadLine()));
            sr.Close();
        }
        
        /// <summary>
        /// Creates the tile definiton file from the list value
        /// </summary>
        private void SaveTileInfos()
        {
            var sw = new StreamWriter(Utils.EDITOR_CACHE + "tiles.txt", false, Encoding.UTF8);
            foreach (var t in Tiles)
            {
                sw.WriteLine(t.ToCSV());
                t.Texture.Save(Utils.EDITOR_CACHE + t.Name + Utils.EDITOR_TILE_IMAGE_POSTFIX, ImageFormat.Png);
            }
            sw.Close();
        }

        /// <summary>
        /// Reads the tile definiton file and sets the list value
        /// </summary>
        private void GetTileInfos()
        {
            Tiles = new List<TileInfo>();
            var sr = new StreamReader(Utils.MAP_CACHE + "tiles.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string dummy = sr.ReadLine();
                if (dummy.Split(';').Length == 5) Tiles.Add(new TileInfo(dummy));
                else Tiles.Add(new TownInfo(dummy));
            }
            sr.Close();
        }

        /// <summary>
        /// Writes the map meta file and pushes the player count
        /// </summary>
        private void SavePlayerCount()
        {
            var sw = new StreamWriter(Utils.EDITOR_CACHE + "meta.txt", false, Encoding.UTF8);
            sw.WriteLine(PlayerCount);
            sw.Close();
        }

        /// <summary>
        /// Reads the map meta file and fetches the player count
        /// </summary>
        private void GetPlayerCount()
        {
            var sr = new StreamReader(Utils.MAP_CACHE + "meta.txt", Encoding.UTF8);
            PlayerCount = byte.Parse(sr.ReadLine());
            sr.Close();
        }

        public Map()
        {
            GetTileInfos();
            GetUnitInfos();
            GetTileMap();
            GetPlayerCount();
        }
        public Map(List<UnitInfo> units, List<TileInfo> tiles, char[,] tileMap,
                   byte playerCount, string mapName, string mapCreator)
        {
            Tiles = tiles;
            Units = units;
            tileChars = tileMap;
            PlayerCount = playerCount;
            this.mapName = mapName;
            this.mapCreator = mapCreator;
        }
    }
}
