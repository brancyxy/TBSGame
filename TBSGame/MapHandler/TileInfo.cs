using System;
using System.Drawing;
using System.Globalization;

namespace TBSGame.MapHandler
{
    class TileInfo
    {
        protected const string ERROR_MESSAGE = "Error in reading tiles.txt of selected map";
        public char Character { get; private set; }
        public int APred { get; private set; }
        public double ArmorBonus { get; private set; }
        public string Name { get; private set; }
        public Image Texture { get; private set; }

        public TileInfo(string line)
        {
            var tmp = line.Split(';');
            if (tmp.Length != 5 &&
                tmp.Length != 8) throw new Exception(ERROR_MESSAGE);

            Character = tmp[0][0];

            if (int.TryParse(tmp[1], out int tmpAPred)) APred = tmpAPred;
            else throw new Exception(ERROR_MESSAGE);

            if (double.TryParse(tmp[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double tmpArmorBonus)) ArmorBonus = tmpArmorBonus;
            else throw new Exception(ERROR_MESSAGE);

            Name = tmp[3];

            Texture = Image.FromFile(Utils.MAP_CACHE + tmp[4]);
        }

        public TileInfo(char character, string name, int APred, double armorBonus, Image texture)
        {
            Character = character;
            Name = name;
            this.APred = APred;
            ArmorBonus = armorBonus;
            Texture = texture;
        }

        public virtual string ToCSV()
        {
            string filePath = Name + Utils.EDITOR_TILE_IMAGE_POSTFIX;

            return $"{Character};{APred};{ArmorBonus};{Name};{filePath}";
        }

        

    }
}
