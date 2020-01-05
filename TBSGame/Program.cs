using IniParser;
using IniParser.Model;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

using TBSGame.Menus;

namespace TBSGame
{
    static class Program
    {
        const string CACHE_FOLDER_NAME = @"MapCache\",
                     MAP_FOLDER = @"Maps\",
                     SETTINGS_FILE = "AppSettings.ini";

        const int BASE_WIDTH = 608,
                  BASE_HEIGHT = 342;

        static SizeF sizeScale;
        static IniData settings;

        static int resX, resY;

        static bool useFullScreen;

        [STAThread]
        static void Main()
        {
            Initialize();
            ReadSettings();
            sizeScale = DetermineSizeScale();
            Warning();

            var mapSelector = new MapSelector(sizeScale, useFullScreen);
            string mapFile;

            if (mapSelector.ShowDialog() == DialogResult.OK)
            {
                mapFile = mapSelector.SelectedMapFileName;
                mapSelector.Dispose();
                ZipFile.ExtractToDirectory(Path.Combine(MAP_FOLDER, mapFile), CACHE_FOLDER_NAME);
            }

        }

        private static void Warning()
        {
            bool warn;
            if (!bool.TryParse(settings["UI"]["aspectRatioWarning"], out warn))
            {
                warn = true;
                settings["UI"]["aspectRatioWarning"] = warn.ToString();
                new FileIniDataParser()
                    .WriteFile(SETTINGS_FILE, settings, Encoding.UTF8);
            }

            if (warn)
            {
                int x = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Width
                        : resX,
                    y = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Height
                        : resY;

                if (((decimal) x / 16 != (decimal) y / 9) &&
                    ((decimal) x / 683 != (decimal) y / 384))
                        MessageBox.Show("The supported aspect ratio is 16:9, there might be some graphical issues.",
                                        "Warning");
            }
        }

        private static SizeF DetermineSizeScale()
        {

            float ScaleX = (useFullScreen)
                            ? (float)Screen.PrimaryScreen.Bounds.Width / BASE_WIDTH
                            : (float)resX / BASE_WIDTH,
                  ScaleY = (useFullScreen)
                            ? (float)Screen.PrimaryScreen.Bounds.Height / BASE_HEIGHT
                            : (float)resY / BASE_HEIGHT;

            return new SizeF(ScaleX, ScaleY);
        }

        private static void ReadSettings()
        {
            var parser = new FileIniDataParser();

            if (File.Exists(SETTINGS_FILE))
                settings = parser.ReadFile(SETTINGS_FILE, Encoding.UTF8);
            else
            {
                settings = new IniData();
                File.Create(SETTINGS_FILE);
            }

            settings.Configuration.AllowCreateSectionsOnFly = true;

            
            if(!bool.TryParse(settings["UI"]["fullscreen"], out useFullScreen))
            {
                useFullScreen = false;
                settings["UI"]["fullscreen"] = useFullScreen.ToString();
            }

            if(!int.TryParse(settings["UI"]["res-x"], out resX) ||
               !int.TryParse(settings["UI"]["res-y"], out resY))
            {
                resX = BASE_WIDTH;
                settings["UI"]["res-x"] = resX.ToString();
                resY = BASE_HEIGHT;
                settings["UI"]["res-y"] = resY.ToString();

                MessageBox.Show("Error reading resolution data, game resolution set to default value",
                                "Warning");
            }

            parser.WriteFile(SETTINGS_FILE, settings, Encoding.UTF8);
        }

        private static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists(CACHE_FOLDER_NAME)) Directory.Delete(CACHE_FOLDER_NAME, true);
            Directory.CreateDirectory(CACHE_FOLDER_NAME);
        }
    }
}
