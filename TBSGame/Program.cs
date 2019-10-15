using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    static class Program
    {
        const string CACHE_FOLDER_NAME = "MapCache/";

        static FileInfo mapFile;

        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Directory.Delete(CACHE_FOLDER_NAME, true);

            while (true)
            {
                var mapSelector = new MapSelector();
                if (mapSelector.ShowDialog() == DialogResult.OK)
                {
                    mapFile = mapSelector.SelectedMap;
                }

                Application.Run(new MapSelector());
            }
        }
    }
}
