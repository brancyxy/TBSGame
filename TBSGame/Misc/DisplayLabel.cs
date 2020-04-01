using System.Drawing;
using System.Windows.Forms;

namespace TBSGame.Misc
{
    class DisplayLabel : Label
    {
        public static Font ScaledFont(float scale)
            => new Font("Microsoft Sans Serif", 8.25F * scale);
        public DisplayLabel(Point location)
        {
            AutoSize = true;
            BackColor = Color.Transparent;
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ImeMode = ImeMode.NoControl;
            Location = location;
            Margin = new Padding(0);
            MinimumSize = new Size(137, 0);
            Size = new Size(137, 9);
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
