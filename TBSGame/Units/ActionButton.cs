using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame.Units
{
    enum TileStatus
    {
        EMPTY,
        ALLY,
        ENEMY,
        TOWN_ALLY,
        TOWN_ENEMY
    }
    class ActionButton : Control
    {
        private const int BASE_WIDTH = 8,
                          BASE_HEIGHT = 8;

        private readonly CoordinateDirection direction;

        private Coordinate _coords;
        public Coordinate Coords 
        { 
            get { return _coords; }
            private set
            {
                Location = new Point((int)((Utils.BASE_TILE_WIDTH - BASE_WIDTH) * (Utils.scale.Width / 2)) + 
                                        (int)(Utils.BASE_TILE_WIDTH * Utils.scale.Width) * (value.X - 1),
                                     (int)((Utils.BASE_TILE_HEIGHT - BASE_HEIGHT) * (Utils.scale.Height / 2)) + 
                                        (int)(Utils.BASE_TILE_HEIGHT * Utils.scale.Height) * (value.Y - 1));
                _coords = value;
            }
        }

        private TileStatus _tileStatus;
        public TileStatus TileStatus
        {
            get { return _tileStatus; }
            set
            {
                BackColor = ChangeColor(value);
                _tileStatus = value;
            }
        }

        private Color ChangeColor(TileStatus value)
        {
            switch (value)
            {
                case TileStatus.EMPTY: return Color.Green;
                case TileStatus.ALLY: return Color.Yellow;
                case TileStatus.ENEMY: return Color.Red;
                case TileStatus.TOWN_ALLY: return Color.Orange;
                case TileStatus.TOWN_ENEMY: return Color.Red;
                default: return Color.Transparent;
            }
        }

        public void CenterAroundUnit(Coordinate unitLocation)
        {
            switch (direction)
            {
                case CoordinateDirection.UP:
                    {
                        Coords = new Coordinate(unitLocation.X, (byte)(unitLocation.Y - 1));
                        break;
                    }
                case CoordinateDirection.RIGHT:
                    {
                        Coords = new Coordinate((byte)(unitLocation.X + 1), unitLocation.Y);
                        break;
                    }
                case CoordinateDirection.DOWN:
                    {
                        Coords = new Coordinate(unitLocation.X, (byte)(unitLocation.Y + 1));
                        break;
                    }
                case CoordinateDirection.LEFT:
                    {
                        Coords = new Coordinate((byte)(unitLocation.X - 1), unitLocation.Y);
                        break;
                    }
            }
            Visible = true;
        }

        public ActionButton(CoordinateDirection direction)
        {
            Width = BASE_WIDTH;
            Height = BASE_HEIGHT;

            this.direction = direction;

            Visible = false;
        }
    }
}
