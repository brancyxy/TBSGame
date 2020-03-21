using System;
using TBSGame.MapHandler;

namespace TBSGame.Units
{
    class Town : Tile
    {

        public bool Recruiting { get; private set; }

        private int turnsToRecruit;
        public Unit recruitingUnit;

        public int MaxHealth { get; private set; }

        public int CurrentHealth { get; private set; }

        public int Regeneration { get; private set; }

        public readonly byte ownerPlayer;

        public bool Alive { get; set; }

        public Town(byte x, byte y, TownInfo ti) : base(x, y, ti)
        {
            Recruiting = false;

            MaxHealth = ti.MaxHealth;
            CurrentHealth = MaxHealth;

            Regeneration = ti.Regeneration;

            ownerPlayer = ti.OwnerPlayer;

            Alive = true;
        }

        /// <summary>
        /// Adds the regeneration and the unit recruit progress
        /// </summary>
        /// <returns>True if there was a recruit in progress and the unit is just finished recruiting</returns>
        public bool ElapsedTurn()
        {
            if (!Alive) return false;

            CurrentHealth = Math.Min(CurrentHealth + Regeneration, MaxHealth);

            if (Recruiting)
            {
                turnsToRecruit--;
                if (turnsToRecruit <= 0)
                {
                    Recruiting = false;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Begins the recruiting process
        /// </summary>
        /// <param name="ui">The given unit</param>
        public void Recruit(UnitInfo ui, byte currentPlayer)
        {
            Recruiting = true;
            turnsToRecruit = ui.RecruitTime;

            recruitingUnit = new Unit(ui, Coords, currentPlayer);
        }

        /// <summary>
        /// Processes damage to the town
        /// </summary>
        /// <param name="damage">ammount</param>
        /// <returns>True if the town is destroyed</returns>
        public bool Damage(int damage)
        {
            CurrentHealth = Math.Max(CurrentHealth - damage, 0);

            return (CurrentHealth == 0);
        }
    }
}
