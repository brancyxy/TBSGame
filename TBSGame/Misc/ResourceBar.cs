using System.Drawing;
using System.Windows.Forms;

namespace TBSGame.Misc
{
    class ResourceBar : ProgressBar
    {
        public ResourceBar(Point location)
        {
            BackColor = Color.FromArgb(158, 123, 11);
            ForeColor = Color.Black;
            ImeMode = ImeMode.NoControl;
            Location = location;
            Margin = new Padding(0);
            MarqueeAnimationSpeed = 0;
            Maximum = 1;
            MinimumSize = new Size(137, 8);
            Size = new Size(137, 8);
            Step = 1;
            Style = ProgressBarStyle.Continuous;
        }
    }
}
