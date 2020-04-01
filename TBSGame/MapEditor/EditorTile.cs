using System;
using System.Drawing;
using System.Windows.Forms;

namespace TBSGame.MapEditor
{
    class EditorTile : Control
    {
        public char Character { get; private set; }
        public Coordinate Coords { get; private set; }
        public EditorTile(byte x, byte y)
        {
            Coords = new Coordinate((byte)(x + 1), (byte)(y + 1));
            BackColor = Color.Beige;
            Width = (int)Math.Floor(Utils.BASE_TILE_WIDTH * Utils.scale.Width) - 1;
            Height = (int)Math.Floor(Utils.BASE_TILE_HEIGHT * Utils.scale.Height) - 1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Location = new Point(x * (Width + 1), y * (Height + 1));
        }
        /// <summary>
        /// Sets the values of the tile to that of the placed tile
        /// </summary>
        /// <param name="texture">the visual representation</param>
        /// <param name="character">the code as in the map file</param>
        public void SetTile(Image texture, char character)
        {
            Character = character;
            BackgroundImage = texture;
        }
    }
}
