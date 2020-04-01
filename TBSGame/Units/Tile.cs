using System;
using System.Drawing;
using System.Windows.Forms;
using TBSGame.MapHandler;

namespace TBSGame.Units
{
    class Tile : Control
    {
        public int ActionPointReduction { get; private set; }
        public double ArmorBonus { get; private set; }
        public string TileName { get; private set; }

        public Coordinate Coords { get; private set; }

        public Tile(byte x, byte y, TileInfo ti)
        {
            Width = (int)Math.Floor(Utils.BASE_TILE_WIDTH * Utils.scale.Width);
            Height = (int)Math.Floor(Utils.BASE_TILE_HEIGHT * Utils.scale.Height);
            BackgroundImage = ti.Texture;
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
