using System;

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

        /// <summary>
        /// Checks if the coordinate falls in a virtual rectangle between two coordinates
        /// </summary>
        public bool IsBetween(Coordinate cornerA, Coordinate cornerB)
        {
            return X >= Math.Min(cornerA.X, cornerB.X) && X <= Math.Max(cornerA.X, cornerB.X) &&
                   Y >= Math.Min(cornerA.Y, cornerB.Y) && Y <= Math.Max(cornerA.Y, cornerB.Y);
        }

        public static bool operator ==(Coordinate a, Coordinate b)
            => (a.X == b.X) && (a.Y == b.Y);
        public static bool operator !=(Coordinate a, Coordinate b)
            => !(a == b);

    }
}
