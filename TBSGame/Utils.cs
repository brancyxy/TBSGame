using IniParser.Model;
using System.Drawing;


namespace TBSGame
{
    public static class Utils
    {
        public const string MAP_CACHE = @"MapCache\",
                            SETTINGS_FILE = "AppSettings.ini",
                            MAP_FOLDER = @"Maps\",
                            EDITOR_CACHE = @"Editor\",
                            EDITOR_UNIT_IMAGE_POSTFIX = "@.png",
                            EDITOR_TILE_IMAGE_POSTFIX = "$.png";

        public const int BASE_WIDTH = 608,
                         BASE_HEIGHT = 342,
                         BASE_TILE_HEIGHT = 15,
                         BASE_TILE_WIDTH = 15;


        public static IniData settings;

        public static SizeF scale;
    }
}
