﻿using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TBSGame
{
    public static class Utils
    {
        public const string CACHE_FOLDER_NAME = @"MapCache\",
                            SETTINGS_FILE = "AppSettings.ini",
                            MAP_FOLDER = @"Maps\";

        public const int BASE_WIDTH = 608,
                         BASE_HEIGHT = 342,
                         BASE_TILE_HEIGHT = 25,
                         BASE_TILE_WIDTH = 25;

        public static IniData settings;

        public static SizeF scale;
    }
}
