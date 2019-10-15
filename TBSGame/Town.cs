using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TBSGame
{
    class Town:Control
    {
        public List<UnitInfo> unitInfos;

        public bool rec = false;
        public int turns = 0;

        public readonly int maxHP;

        public int currHP;

        public int reg;

        public int x, y;

        public Unit recruit;
        public bool owner = false;
        public Town(int maxHP, int reg, int x,int y)
        {
            Visible = true;
            Height = 25;
            Width = 25;

            this.maxHP = maxHP;
            currHP = maxHP;
            this.reg = reg;
            this.x = x;
            this.y = y;

            Location = new Point(x * 25, y * 25);
        }

        public bool RecruitDone()
        {
            var rt = recruit.stats;
            if (turns == rt.RecTime)
            {
                rec = false;
                turns = 0;
                return true;
            }
            else return false;
        }
    }
}
