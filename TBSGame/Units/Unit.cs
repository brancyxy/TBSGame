using System;
using System.Drawing;
using System.Windows.Forms;
using TBSGame.MapHandler;

namespace TBSGame.Units
{
    class Unit : Control
    {
        private readonly Random random;

        private const int BASE_HEIGHT = 15,
                          BASE_WIDTH = 10;

        public bool Attacked { set; get; }

        public string UnitName { private set; get; }

        public int MaxHealth { private set; get; }
        public int CurrentHealth { set; get; }

        public int MinDamage { private set; get; }
        public int MaxDamage { private set; get; }

        public int GenerateDamage()
            => random.Next(MinDamage, MaxDamage + 1);

        public int MaxActionPoints { private set; get; }
        public int CurrentActionPoints { set; get; }

        public byte Type { private set; get; }

        public string Description { private set; get; }

        public readonly byte ownerPlayer;

        private Coordinate _coords;
        public Coordinate Coords
        {
            get { return _coords; }
            set
            {
                Location = new Point((int)((Utils.BASE_TILE_WIDTH - BASE_WIDTH) * (Utils.scale.Width / 2)) +
                                     (int)(Utils.BASE_TILE_WIDTH * Utils.scale.Width) * (value.X - 1),
                                     Height * (value.Y - 1));

                _coords = value;
            }
        }

        public Unit(UnitInfo ui, Coordinate coords, byte ownerPlayer)
        {
            Width = (int)(BASE_WIDTH * Utils.scale.Width);
            Height = (int)(BASE_HEIGHT * Utils.scale.Height);

            UnitName = ui.Name;

            MaxHealth = ui.Health;
            CurrentHealth = MaxHealth;

            MinDamage = ui.MinDamage;
            MaxDamage = ui.MaxDamage;

            MaxActionPoints = ui.ActionPoints;
            CurrentActionPoints = MaxActionPoints;

            BackgroundImage = ui.Texture;
            BackgroundImageLayout = ImageLayout.Stretch;

            Type = ui.Type;

            Description = ui.Description;

            Coords = coords;

            Attacked = false;

            this.ownerPlayer = ownerPlayer;

            random = new Random();
        }

        public void ElapsedTurn()
        {
            CurrentActionPoints = MaxActionPoints;
            Attacked = false;
        }

        /// <summary>
        /// Processes damage to the unit
        /// </summary>
        /// <returns>True if the unit is killed</returns>
        public bool Damage(int damage)
        {
            CurrentHealth = Math.Max(CurrentHealth - damage, 0);

            return (CurrentHealth == 0);
        }

        /// <summary>
        /// Heals the unit
        /// </summary>
        public void Heal(int ammount) => CurrentHealth = Math.Min(CurrentHealth + ammount, MaxHealth);
    }

}