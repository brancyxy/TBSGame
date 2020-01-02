using System;
using System.Drawing;

namespace TBSGame
{
    struct UnitInfo
    {
            public string Name { private set; get; }

            public int RecTime { private set; get; }

            public int MaxHP { private set; get; }

            public int MinDMG { private set; get; }
            public int MaxDMG { private set; get; }

            public int MaxAP { private set; get; }

            public int Type { private set; get; }

            // public int Range { private set; get; } -- dont need this atm

            public Image Texture { private set; get; }

            public string Description { private set; get; }
            public UnitInfo(string name, int recTime, int maxHP, int minDMG, int maxDMG, int maxAP, string type, string imgPath, string description)
            {

                Image img = Image.FromFile(imgPath);
                if (img.Width != 15 || img.Height != 25) throw new Exception(string.Format("Unit resource error at {0}: image must be 25x15 in pixels", name));
                Texture = img;
                this.Type = int.Parse(type);
                this.Name = name;
                this.RecTime = recTime;
                this.MaxHP = maxHP;
                this.MinDMG = minDMG;
                this.MaxDMG = maxDMG;
                this.MaxAP = maxAP;
                this.Description = description;   
            
        }
    }
}
