using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBSGame
{
    /// <summary>
    /// 0 is upwards, goes clockwise.
    /// </summary>
    enum CoordinateDirection
    {
        UP = 0,
        RIGHT = 1,
        DOWN = 2,
        LEFT = 3
    }
    struct Coordinate
    {
        public readonly byte X;
        public readonly byte Y;

        public Coordinate(byte X, byte Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static bool operator == (Coordinate a, Coordinate b)
            => (a.X == b.X) && (a.Y == b.Y);
        public static bool operator !=(Coordinate a, Coordinate b)
            => !(a==b);

    }
}
