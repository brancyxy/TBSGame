using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TBSGame
{
    abstract class File
    {
        private static List<string> lines = new List<string>();
        public static Char[,] ReadMap(string filePath)
        {
            var map = new Char[20,20];
            var sr = new StreamReader(filePath,Encoding.UTF8);
            for (int i = 0; i < 20; i++)
            {
                string line = sr.ReadLine();
                for (int j = 0; j < line.Length; j++)
                {
                    map[i, j] = line[j];
                }
            }
            while (!sr.EndOfStream) lines.Add(sr.ReadLine());
            sr.Close();
            return map;
        }

        public static List<TileInfo> GetTiles()
        {
            List<TileInfo> tileInfo = new List<TileInfo>();
            lines.RemoveAt(0);
            bool done = false;
            while (!done)
            {
                if (lines[0] == "[END]")
                {
                    lines.RemoveAt(0);
                    done = true;
                }
                else
                {
                    string[] line = lines[0].Split(';');
                    tileInfo.Add(new TileInfo(line[0][0],int.Parse(line[1]),double.Parse(line[2])/100,line[3],line[4]));
                    lines.RemoveAt(0);
                }
            }
            return tileInfo;
        }
    }
}
