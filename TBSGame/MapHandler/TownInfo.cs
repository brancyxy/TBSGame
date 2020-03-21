using System;

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
    }
}
