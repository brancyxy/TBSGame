using System.Drawing;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;

namespace TBSGame.Panels
{
    class TownInfoPanel : Panel
    {
        private DisplayLabel townCoords;

        private ResourceBar townHealthBar;
        private DisplayLabel townHealthDisplay;
        public TownInfoPanel()
        {
            Location = new Point(0, 148);
            Size = new Size(190, 135);

            Init();

            Scale(Utils.scale);
            ScaleFontSize(Utils.scale.Height);
        }

        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            townCoords.Font = new Font(townCoords.Font.FontFamily,
                                       townCoords.Font.Size * height);

            townHealthDisplay.Font = new Font(townHealthDisplay.Font.FontFamily,
                                              townHealthDisplay.Font.Size * height);
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            Controls.Add(new DisplayLabel(new Point(27, 42))
                        {
                            Text = "Town"
                        });

            townCoords = new DisplayLabel(new Point(27, 57));
            Controls.Add(townCoords);

            Controls.Add(new IconPictureBox(Resources.heart, new Point(11, 85)));

            townHealthBar = new ResourceBar(new Point(30, 85));
            Controls.Add(townHealthBar);

            townHealthDisplay = new DisplayLabel(new Point(30, 97));
            Controls.Add(townHealthDisplay);
        }
    }
}
