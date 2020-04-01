using System;
using System.Drawing;

namespace TBSGame.MapHandler
{
    class TownInfo : TileInfo
    {
        public byte OwnerPlayer { get; private set; }
        public int MaxHealth { get; private set; }
        public int Regeneration { get; private set; }


        public TownInfo(string line) : base(line)
        {
            var tmp = line.Split(';');

            OwnerPlayer = Convert.ToByte(tmp[5]);
            MaxHealth = int.Parse(tmp[6]);
            Regeneration = int.Parse(tmp[7]);
        }

        public TownInfo(char character, string name, int APred, double armorBonus, Image texture, 
                        byte ownerPlayer, int maxHealth, int regeneration) : base(character, name, APred, armorBonus, texture)
        {
            OwnerPlayer = ownerPlayer;
            MaxHealth = maxHealth;
            Regeneration = regeneration;
        }

        public override string ToCSV()
            => base.ToCSV() + $";{OwnerPlayer};{MaxHealth};{Regeneration}";
    }
}
