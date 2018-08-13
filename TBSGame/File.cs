using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TBSGame
{
    class File
    {
        private static List<String> lines = new List<string>();
        public static Char[,] ReadMap(string filePath)
        {
            var map = new Char[20,20];
            var sr = new StreamReader(filePath,Encoding.UTF8);
            for (int i = 0; i < 19; i++)
            {
                string line = sr.ReadLine();
                for (int j = 0; j < 19; j++)
                {
                    map[i, j] = line[j];
                }
            }
            while (!sr.EndOfStream) lines.Add(sr.ReadLine());
            sr.Close();
            return map;
        }
    }
}
