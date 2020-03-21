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
        public Image Background { get; private set; }

        public TileInfo(string line)
        {
            var tmp = line.Split(';');
            if (tmp.Length != 5 && 
                tmp.Length != 8) throw new Exception(ERROR_MESSAGE);

            Character = tmp[0][0];

            int tmpAPred;
            if (int.TryParse(tmp[1], out tmpAPred)) APred = tmpAPred;
            else throw new Exception(ERROR_MESSAGE);

            
            double tmpArmorBonus;
            if (double.TryParse(tmp[2], NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out tmpArmorBonus)) ArmorBonus = tmpArmorBonus;
            else throw new Exception(ERROR_MESSAGE);

            Name = tmp[3];

            Background = Image.FromFile(Utils.CACHE_FOLDER_NAME + tmp[4]);
        }
    }
}
