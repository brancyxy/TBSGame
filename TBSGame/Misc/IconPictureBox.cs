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
            Size = new Size(11, 11);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
