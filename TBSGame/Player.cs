using System.Collections.Generic;

namespace TBSGame
{
    class Player
    {
        public string name;

        public List<Unit> ownedUnits;
        public Town town;

        public Player(string n, Town town)
        {
            name = n;
            this.town = town;
            ownedUnits = new List<Unit>();
        }
    }
}
