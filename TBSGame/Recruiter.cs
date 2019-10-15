using System.Drawing;
using System.Windows.Forms;

namespace TBSGame
{
    class Recruiter : Control
    {
        public UnitInfo unit;
        public Recruiter(UnitInfo unit,int x, int y)
            {
                this.unit = unit;
                BackgroundImage = unit.Texture;
                Location = new Point(20 + (x * 30), 20 + (y * 30));
                
                Visible = true;
                Height = 26;
                Width = 16;
            }
        
    }
}
