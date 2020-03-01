using System;
using System.Drawing;
using System.Windows.Forms;

namespace TBSGame.Units
{
    class Tile : Control
    {
        const string ERROR_MESSAGE = "Error in creating tile map from the selected map";
        public int APred { get; private set; }
        public double ArmorBonus { get; private set; }
        public string TileName { get; private set; }


        public Tile(byte x, byte y, int APred, double armorBonus, string name, Image texture)
        {
            if ((x < 0 || x > 20) || 
                (y < 0 || y > 20)) throw new Exception(ERROR_MESSAGE);

            Visible = true; 
            Width = (int)(Utils.BASE_TILE_WIDTH * Utils.scale.Width);
            Height =(int)(Utils.BASE_TILE_HEIGHT * Utils.scale.Height);
            BackgroundImage = texture;
            Location = new Point(x * Width, y * Height);
            this.APred = APred;
            this.ArmorBonus = armorBonus;
            this.TileName = name;
        }
    }
}
