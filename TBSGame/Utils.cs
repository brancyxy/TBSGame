using IniParser.Model;
using System.Drawing;


namespace TBSGame
{
    public static class Utils
    {
        public const string CACHE_FOLDER_NAME = @"MapCache\",
                            SETTINGS_FILE = "AppSettings.ini",
                            MAP_FOLDER = @"Maps\";

        public const int BASE_WIDTH = 608,
                         BASE_HEIGHT = 342,
                         BASE_TILE_HEIGHT = 15,
                         BASE_TILE_WIDTH = 15;


        public static IniData settings;

        public static SizeF scale;
    }
}
