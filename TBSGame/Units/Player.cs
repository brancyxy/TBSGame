using System.Collections.Generic;
using TBSGame.Units;

namespace TBSGame
{
    class Player
    {
        /// <summary>
        /// A list of the units owned by the player
        /// </summary>
        public List<Unit> OwnedUnits { get; set; }

        /// <summary>
        /// Determines if the player is still alive
        /// </summary>
        public bool InGame { get; set; }

        public Player()
        {
            OwnedUnits = new List<Unit>();
            InGame = true;
        }
    }
}
