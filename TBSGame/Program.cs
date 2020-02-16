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

            switch (StartMenu())
            {
                case MainMenuAction.OPTIONS:

                    break;
                case MainMenuAction.EXIT:
                    Application.Exit();
                    break;
            }
            /*
            var mapSelector = new MapSelector(sizeScale, useFullScreen);
            string mapFile;

            if (mapSelector.ShowDialog() == DialogResult.OK)
            {
                mapFile = mapSelector.SelectedMapFileName;
                mapSelector.Dispose();
                ZipFile.ExtractToDirectory(Path.Combine(MAP_FOLDER, mapFile), CACHE_FOLDER_NAME);
            }
            */
        }

        private static MainMenuAction StartMenu()
        {
            MainMenuAction result = MainMenuAction.START;
            var menu = new Menus.MainMenu(sizeScale, useFullScreen);
            while (menu.ShowDialog() != DialogResult.OK)
            {
                result = menu.Action;
            }
            return result;
        }

        private static void Warning()
        {
            if (!bool.TryParse(settings["UI"]["aspectRatioWarning"], out bool warn))
            {
                warn = true;
                settings["UI"]["aspectRatioWarning"] = warn.ToString();
                new FileIniDataParser()
                    .WriteFile(Utils.SETTINGS_FILE, settings, Encoding.UTF8);
            }

            if (warn)
            {
                int x = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Width
                        : resX,
                    y = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Height
                        : resY;

                if ((decimal) x / 16 != (decimal) y / 9 ||
                    (decimal) x / 683 != (decimal) y / 384)
                        MessageBox.Show("The supported aspect ratio is 16:9, there might be some graphical issues.",
                                        "Warning");
            }
        }

        private static SizeF DetermineSizeScale()
        {

            float ScaleX = (useFullScreen)
                            ? (float)Screen.PrimaryScreen.Bounds.Width / Utils.BASE_WIDTH
                            : (float)resX / Utils.BASE_WIDTH,
                  ScaleY = (useFullScreen)
                            ? (float)Screen.PrimaryScreen.Bounds.Height / Utils.BASE_HEIGHT
                            : (float)resY / Utils.BASE_HEIGHT;

            return new SizeF(ScaleX, ScaleY);
        }

        private static void ReadSettings()
        {
            var parser = new FileIniDataParser();

            if (File.Exists(Utils.SETTINGS_FILE))
                settings = parser.ReadFile(Utils.SETTINGS_FILE, Encoding.UTF8);
            else
            {
                settings = new IniData();
                File.Create(Utils.SETTINGS_FILE);
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
                settings["UI"]["res-x"] = Utils.BASE_WIDTH.ToString();
                settings["UI"]["res-y"] = Utils.BASE_HEIGHT.ToString();

                MessageBox.Show("Error reading resolution data, game resolution set to default value",
                                "Warning");
            }

            parser.WriteFile(Utils.SETTINGS_FILE, settings, Encoding.UTF8);
        }

        private static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists(Utils.CACHE_FOLDER_NAME)) Directory.Delete(Utils.CACHE_FOLDER_NAME, true);
            Directory.CreateDirectory(Utils.CACHE_FOLDER_NAME);
        }
    }
}
