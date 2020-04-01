using System;
using System.Drawing;
using System.Drawing.Imaging;

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

        public byte Type { private set; get; }

        public Image Texture { private set; get; }

        public string Description { private set; get; }

        public UnitInfo(string line)
        {
            var tmp = line.Split(';');
            if (tmp.Length != 9) throw new Exception(ERROR_MESSAGE);

            Name = tmp[0];

            if (int.TryParse(tmp[1], out int tmpRecruitTime) &&
                int.TryParse(tmp[2], out int tmpHealth) &&
                int.TryParse(tmp[3], out int tmpMinDamage) &&
                int.TryParse(tmp[4], out int tmpMaxDamage) &&
                int.TryParse(tmp[5], out int tmpActionPoints) &&
                byte.TryParse(tmp[6], out byte tmpType))
            {
                RecruitTime = tmpRecruitTime;
                Health = tmpHealth;
                MinDamage = tmpMinDamage;
                MaxDamage = tmpMaxDamage;
                ActionPoints = tmpActionPoints;
                Type = tmpType;
            }
            else throw new Exception(ERROR_MESSAGE);

            Texture = Image.FromFile(Utils.MAP_CACHE + tmp[7]);

            Description = tmp[8];

        }

        public UnitInfo(string name, int recruitTime, int health, int minDamage, int maxDamage, 
                        int actionPoints, byte type, Image texture, string description)
        {
            Name = name;
            RecruitTime = recruitTime;
            Health = health;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            ActionPoints = actionPoints;
            Type = type;
            Texture = texture;
            Description = description;
        }
        public string ToCSV()
        {
            string filePath = Name + Utils.EDITOR_UNIT_IMAGE_POSTFIX;

            return  $"{Name};{RecruitTime};{Health};{MinDamage};{MaxDamage};{ActionPoints};" +
                    $"{Type};{filePath};{Description}";
        }
    }
}
