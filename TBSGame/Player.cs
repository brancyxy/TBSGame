using System.Collections.Generic;

namespace TBSGame
{
    class Player
    {
        public string Name { get; private set; }

        public List<Units.Unit> ownedUnits;
        public Units.Town Town { get; private set; }

        public Player(string n, Units.Town town)
        {
            this.Name = n;
            this.Town = town;
            ownedUnits = new List<Units.Unit>();
        }
    }
}
