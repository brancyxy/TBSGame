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

        /// <summary>
        /// Starts the main menu.
        /// </summary>
        /// <returns>Returns an enumerated value based on the button pressed</returns>
        private static MainMenuAction StartMenu() 
        {
            MainMenuAction result = MainMenuAction.START;
            var menu = new Menus.MainMenu(sizeScale, useFullScreen);
            while (menu.ShowDialog() != DialogResult.OK)
                result = menu.Action;
            return result;
        }

        /// <summary>
        /// Warns the user if the set resolution is unsupported.
        /// </summary>
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
        /// <summary>
        /// Determines the rate of the set resolution and the base resolution
        /// </summary>
        /// <returns>Return value will scale up the rest of the windows accordingly</returns>
        private static SizeF DetermineSizeScale()
        {

            float ScaleX = (useFullScreen)
                            ? Screen.PrimaryScreen.Bounds.Width / (float)Utils.BASE_WIDTH
                            : resX / (float)Utils.BASE_WIDTH,
                  ScaleY = (useFullScreen)
                            ? Screen.PrimaryScreen.Bounds.Height / (float)Utils.BASE_HEIGHT
                            : resY / (float)Utils.BASE_HEIGHT;

            return new SizeF(ScaleX, ScaleY);
        }


        /// <summary>
        /// Reads the settings file and sets the values.
        /// In case of missing file or an error, it sets the settings to the default values
        /// </summary>
        private static void ReadSettings()
        {
            var parser = new FileIniDataParser();

            if (File.Exists(Utils.SETTINGS_FILE))
                settings = parser.ReadFile(Utils.SETTINGS_FILE, Encoding.UTF8);
            else
            {
                settings = new IniData();
                File.Create(Utils.SETTINGS_FILE).Close();
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
                resX = Utils.BASE_WIDTH;
                settings["UI"]["res-y"] = Utils.BASE_HEIGHT.ToString();
                resY = Utils.BASE_HEIGHT;

                MessageBox.Show("Error reading resolution data, game resolution set to default value",
                                "Warning");
            }

            parser.WriteFile(Utils.SETTINGS_FILE, settings, Encoding.UTF8);
        }

        /// <summary>
        /// Deletes the leftover cache files in case the game closed with a crash.
        /// Also sets meta settings for the program
        /// </summary>
        private static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists(Utils.CACHE_FOLDER_NAME)) Directory.Delete(Utils.CACHE_FOLDER_NAME, true);
            Directory.CreateDirectory(Utils.CACHE_FOLDER_NAME);
        }
    }
}
