using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;

namespace TBSGame
{
    static class Program
    {
        const string CACHE_FOLDER_NAME = @"MapCache\";
        const string MAP_FOLDER = @"Maps\";

        static string mapFile;

        static IniData metaSettings;

        [STAThread]
        static void Main()
        {
            Initialize();
            ReadMetaSettings();


            var mapSelector = new MapSelector();

            if (mapSelector.ShowDialog() == DialogResult.OK)
            {
                mapFile = mapSelector.SelectedMapFileName;
                mapSelector.Dispose();
                ZipFile.ExtractToDirectory(MAP_FOLDER + mapFile, CACHE_FOLDER_NAME);
            }

        }

        private static void ReadMetaSettings()
        {
            metaSettings = new FileIniDataParser()
                           .ReadFile("AppSettings.ini", Encoding.UTF8);
            metaSettings.Configuration.AllowCreateSectionsOnFly = true;
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
