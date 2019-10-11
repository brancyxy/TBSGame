using System.Collections.Generic;

namespace TBSGame
{
    class Player
    {
        public string Name { get; private set; }

        public List<Unit> ownedUnits;
        public Town Town { get; private set; }

        public Player(string n, Town town)
        {
            this.Name = n;
            this.Town = town;
            ownedUnits = new List<Unit>();
        }
    }
}
