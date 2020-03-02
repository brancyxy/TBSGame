using System.Windows.Forms;
using System.Drawing;

namespace TBSGame.Misc
{
    class IconPictureBox : PictureBox
    {
        public IconPictureBox(Image icon, Point location)
        {
            Image = icon;
            ImeMode = ImeMode.NoControl;
            Location = location;
            Size = new Size(15, 15);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
