using System;
using System.Drawing;

namespace TBSGame.MapHandler
{
    struct UnitInfo
    {
        const string ERROR_MESSAGE = "Error in reading units.txt of selected map";
        public string Name { private set; get; }

        public int RecruitTime { private set; get; }

        public int Health { private set; get; }

        public int MinDamage { private set; get; }
        public int MaxDamage { private set; get; }

        public int ActionPoints { private set; get; }

        public int Type { private set; get; }

        public Image Texture { private set; get; }

        public string Description { private set; get; }
            
        public UnitInfo(string line)
        {
            var tmp = line.Split(';');
            if (tmp.Length != 9) throw new Exception(ERROR_MESSAGE);

            Name = tmp[0];

            int tmpRecruitTime;
            if (int.TryParse(tmp[1], out tmpRecruitTime)) RecruitTime = tmpRecruitTime;
            else throw new Exception(ERROR_MESSAGE);

            int tmpHealth;
            if (int.TryParse(tmp[2], out tmpHealth)) Health = tmpHealth;
            else throw new Exception(ERROR_MESSAGE);

            int tmpMinDamage;
            if (int.TryParse(tmp[3], out tmpMinDamage)) MinDamage = tmpMinDamage;
            else throw new Exception(ERROR_MESSAGE);

            int tmpMaxDamage;
            if (int.TryParse(tmp[4], out tmpMaxDamage)) MaxDamage = tmpMaxDamage;
            else throw new Exception(ERROR_MESSAGE);

            int tmpActionPoints;
            if (int.TryParse(tmp[5], out tmpActionPoints)) ActionPoints = tmpActionPoints;
            else throw new Exception(ERROR_MESSAGE);

            int tmpType;
            if (int.TryParse(tmp[6], out tmpType)) Type = tmpType;
            else throw new Exception(ERROR_MESSAGE);

            Texture = Image.FromFile(Utils.CACHE_FOLDER_NAME + tmp[7]);

            Description = tmp[8];

        }
            
    }
}
