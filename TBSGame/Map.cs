using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;


namespace TBSGame
{/*
    abstract class Map
    {
        private static List<string> lines;

        public static Char[,] ReadMap(string filePath)
        {
            lines = new List<string>();

            var map = new Char[20,20];
            var sr = new StreamReader(filePath,Encoding.UTF8);
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    string line = sr.ReadLine();
                    for (int j = 0; j < line.Length; j++)
                    {
                        map[i, j] = line[j];
                    }
                }
            }
            catch (Exception) { throw new Exception("Map file error: map needs to have 20x20 dimensions"); }

            while (!sr.EndOfStream) lines.Add(sr.ReadLine());
            sr.Close();
            return map;
        }

        public static List<TileInfo> GetTiles()
        {
            List<TileInfo> tileInfo = new List<TileInfo>();
            lines.RemoveAt(0);
            try
            {
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
                        tileInfo.Add(new TileInfo(line[0][0], 
                                                    int.Parse(line[1]), 
                                                    double.Parse(line[2],CultureInfo.InvariantCulture), 
                                                    line[3], 
                                                    line[4]));
                        lines.RemoveAt(0);
                    }
                }
                return tileInfo;
            }
            catch(Exception) {   throw new Exception("Map file error: Tile descriptions are invalid"); }

            //return new List<TileInfo>();
        }

        public static Town[] GetTown()
        {
            Town[] towns = new Town[2];

            lines.RemoveAt(0);
            int hp, reg;
            string[] stats = lines[0].Split(';');
            lines.RemoveAt(0);
            try
            {
                hp = int.Parse(stats[0]);
                reg = int.Parse(stats[1]);
                string[] coords = lines[0].Split(';');
                lines.RemoveAt(0);
                towns[0] = new Town(hp, reg, int.Parse(coords[0]), int.Parse(coords[1]));
                coords = lines[0].Split(';');
                lines.RemoveAt(0);
                towns[1] = new Town(hp, reg, int.Parse(coords[0]), int.Parse(coords[1]));
            }
            catch (Exception) {    throw new Exception("Map file error: Town description invalid"); }
            return towns;
        }

        public static List<UnitInfo> GetUnitInfos(TileMap map)
        {
            List<UnitInfo> unitInfos = new List<UnitInfo>();
            lines.RemoveAt(0);
            try
            {
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
                        unitInfos.Add(new UnitInfo(line[0], int.Parse(line[1]), int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]),line[6],map.mapFolder+ line[7],line[8]));
                        lines.RemoveAt(0);
                    }
                }
                return unitInfos;
            }
            catch (Exception) { throw new Exception("Map file error: Unit descriptions are invalid."); }
        }
    }
*/
}
