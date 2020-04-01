using IniParser;
using IniParser.Model;
using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using TBSGame.Menus;

namespace TBSGame
{
    static class Program
    {
        static int resX, resY;

        static bool useFullScreen;

        [STAThread]
        static void Main()
        {

            Initialize();
            ReadSettings();
            Utils.scale = DetermineSizeScale();

            switch (StartMenu())
            {
                case MainMenuAction.START:
                    {
                        if (OpenMapSelector())
                            PlayGame();
                        break;
                    }

                case MainMenuAction.EXIT:
                    {
                        Application.Exit();
                        break;
                    }
                case MainMenuAction.EDITOR:
                    {
                        ShowEditor();
                        break;
                    }
            }
        }

        /// <summary>
        /// Jumps to the map editor
        /// </summary>
        private static void ShowEditor()
        {
            var editor = new Editor(useFullScreen);
            editor.ShowDialog();
        }

        /// <summary>
        /// Brings up the game window
        /// </summary>
        private static void PlayGame()
        {
            var gw = new GameWindow(useFullScreen);
            gw.ShowDialog();
        }

        /// <summary>
        /// Opens the map selector window. Returns true if the map selection is successful.
        /// </summary>
        /// <returns>True if the map selection is successful</returns>
        private static bool OpenMapSelector()
        {
            var mapSelector = new MapSelector(useFullScreen);

            bool result = mapSelector.ShowDialog() == DialogResult.OK;

            if (result)
            {
                string mapFile = mapSelector.SelectedMapFileName;
                mapSelector.Dispose();
                ZipFile.ExtractToDirectory(Path.Combine(Utils.MAP_FOLDER, mapFile), Utils.MAP_CACHE);
            }

            return result;
        }

        /// <summary>
        /// Starts the main menu.
        /// </summary>
        /// <returns>Returns an enumerated value based on the button pressed</returns>
        private static MainMenuAction StartMenu()
        {
            var menu = new Menus.MainMenu(useFullScreen);
            try
            {
                while (menu.ShowDialog() != DialogResult.OK)
                    menu.Dispose();
                return menu.Action;
            }
            catch (Exception)
            {
                menu.Dispose();
                return MainMenuAction.EXIT;
            }
        }

        /// <summary>
        /// Warns the user if the set resolution is unsupported.
        /// </summary>
        private static void Warning()
        {
            if (!bool.TryParse(Utils.settings["UI"]["aspectRatioWarning"], out bool warn))
            {
                warn = true;
                Utils.settings["UI"]["aspectRatioWarning"] = warn.ToString();
                new FileIniDataParser()
                    .WriteFile(Utils.SETTINGS_FILE, Utils.settings, Encoding.UTF8);
            }

            if (warn)
            {
                int x = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Width
                        : resX,
                    y = (useFullScreen)
                        ? Screen.PrimaryScreen.Bounds.Height
                        : resY;

                if ((decimal)x / 16 != (decimal)y / 9 &&
                    (decimal)x / 683 != (decimal)y / 384)
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

            Warning();

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
                Utils.settings = parser.ReadFile(Utils.SETTINGS_FILE, Encoding.UTF8);
            else
            {
                Utils.settings = new IniData();
                File.Create(Utils.SETTINGS_FILE).Close();
            }

            Utils.settings.Configuration.AllowCreateSectionsOnFly = true;


            if (!bool.TryParse(Utils.settings["UI"]["fullscreen"], out useFullScreen))
            {
                useFullScreen = false;
                Utils.settings["UI"]["fullscreen"] = useFullScreen.ToString();
            }

            if (!int.TryParse(Utils.settings["UI"]["res-x"], out resX) ||
               !int.TryParse(Utils.settings["UI"]["res-y"], out resY))
            {
                Utils.settings["UI"]["res-x"] = Utils.BASE_WIDTH.ToString();
                resX = Utils.BASE_WIDTH;
                Utils.settings["UI"]["res-y"] = Utils.BASE_HEIGHT.ToString();
                resY = Utils.BASE_HEIGHT;

                MessageBox.Show("Error reading resolution data, game resolution set to default value",
                                "Warning");
            }

            parser.WriteFile(Utils.SETTINGS_FILE, Utils.settings, Encoding.UTF8);
        }

        /// <summary>
        /// Deletes leftover cache files in case the game closed with a crash.
        /// Also sets meta settings for the application
        /// </summary>
        private static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Directory.Exists(Utils.MAP_CACHE)) Directory.Delete(Utils.MAP_CACHE, true);
            Directory.CreateDirectory(Utils.MAP_CACHE);

            if (Directory.Exists(Utils.EDITOR_CACHE)) Directory.Delete(Utils.EDITOR_CACHE, true);
            Directory.CreateDirectory(Utils.EDITOR_CACHE);

            if (!Directory.Exists(Utils.MAP_FOLDER)) Directory.CreateDirectory(Utils.MAP_FOLDER);
        }
    }
}
