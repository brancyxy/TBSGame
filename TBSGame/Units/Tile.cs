using System;
using System.Drawing;
using System.Windows.Forms;
using TBSGame.MapHandler;

namespace TBSGame.Units
{
    class Tile : Control
    {
        const string ERROR_MESSAGE = "Error in creating tile map from the selected map";
        public int ActionPointReduction { get; private set; }
        public double ArmorBonus { get; private set; }
        public string TileName { get; private set; }

        public Coordinate Coords { get; private set; }

        public Tile(byte x, byte y, TileInfo ti)
        {
            if ((x <= 0 || x > 20) || 
                (y <= 0 || y > 20)) throw new Exception(ERROR_MESSAGE);

            Width = (int)Math.Floor(Utils.BASE_TILE_WIDTH * Utils.scale.Width);
            Height = (int)Math.Floor(Utils.BASE_TILE_HEIGHT * Utils.scale.Height);
            BackgroundImage = ti.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            Location = new Point((x - 1) * Width, 
                                 (y - 1) * Height);
            ActionPointReduction = ti.APred;
            ArmorBonus = ti.ArmorBonus;
            TileName = ti.Name;

            Coords = new Coordinate(x, y);
        }
    }
}
