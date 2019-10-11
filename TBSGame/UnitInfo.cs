using System;
using System.Drawing;

namespace TBSGame
{
    struct UnitInfo
    {
            public string name;

            public int recTime;

            public int maxHP;

            public int maxAP;

            public int minDMG;
            public int maxDMG;

            public int type;
            public int range;

            public Image bg;

            public string description;
            public UnitInfo(string name, int recTime, int maxHP, int minDMG, int maxDMG, int maxAP, string type, string imgPath, string description)
            {
                string[] typeData = type.Split(',');
                if (typeData.Length == 2 && typeData[0] == "1")
                {
                    range = int.Parse(typeData[1]);
                }
                else range = 1;

                Image img = Image.FromFile(imgPath);
                if (img.Width != 15 || img.Height != 25) throw new Exception(string.Format("Unit resource error at {0}: image must be 25x15 in pixels", name));

                {
                    bg = img;
                    this.type = int.Parse(typeData[0]);
                    this.name = name;
                    this.recTime = recTime;
                    this.maxHP = maxHP;
                    this.minDMG = minDMG;
                    this.maxDMG = maxDMG;
                    this.maxAP = maxAP;
                    this.description = description;
                }
            
        }
    }
}
