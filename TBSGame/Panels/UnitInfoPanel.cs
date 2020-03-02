using System.Drawing;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;

namespace TBSGame.Panels
{
    class UnitInfoPanel : Panel
    {
        private DisplayLabel unitNameDisplay;
        private Label unitCoords;

        private DisplayLabel unitHealthDisplay;
        private ResourceBar unitHealthBar;

        private DisplayLabel unitDamageDisplay;

        private DisplayLabel unitActionPointDisplay;
        private ResourceBar unitActionPointBar;

        private RichTextBox unitDescDisplay;

        public UnitInfoPanel()
        {
            Size = new Size(190, 188);
            Location = new Point(0, 86);
            BackColor = Color.FromArgb(128, 64, 0);

            Init();
            Scale(Utils.scale);
            ScaleFontSize(Utils.scale.Height);

            Visible = false;
        }

        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            unitNameDisplay.Font = new Font(unitNameDisplay.Font.FontFamily,
                                            unitNameDisplay.Font.Size * height);

            unitCoords.Font = new Font(unitCoords.Font.FontFamily,
                                       unitCoords.Font.Size * height);

            unitHealthDisplay.Font = new Font(unitHealthDisplay.Font.FontFamily,
                                              unitHealthDisplay.Font.Size * height);

            unitDescDisplay.Font = new Font(unitDescDisplay.Font.FontFamily,
                                            unitDescDisplay.Font.Size * height);

            unitDamageDisplay.Font = new Font(unitDamageDisplay.Font.FontFamily,
                                              unitDamageDisplay.Font.Size * height);

            unitActionPointDisplay.Font = new Font(unitActionPointDisplay.Font.FontFamily,
                                                   unitActionPointDisplay.Font.Size * height);
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            unitNameDisplay = new DisplayLabel(new Point(27, 12));
            Controls.Add(unitNameDisplay);

            unitCoords = new DisplayLabel(new Point(27, 25));
            Controls.Add(unitCoords);

            unitHealthDisplay = new DisplayLabel(new Point(27, 36));
            Controls.Add(unitHealthDisplay);

            unitHealthBar = new ResourceBar(new Point(27, 29));
            Controls.Add(unitHealthBar);

            unitDescDisplay = new RichTextBox()
            {
                BackColor = Color.FromArgb(141, 64, 5),
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                Location = new Point(8, 152),
                ReadOnly = true,
                Size = new Size(175, 91),
                Text = ""
            };
            Controls.Add(unitDescDisplay);

            unitDamageDisplay = new DisplayLabel(new Point(27, 57));
            Controls.Add(unitDamageDisplay);

            unitActionPointDisplay = new DisplayLabel(new Point(27, 93));
            Controls.Add(unitActionPointDisplay);

            unitActionPointBar = new ResourceBar(new Point(27, 86));
            Controls.Add(unitActionPointBar);

            Controls.Add(new IconPictureBox(Resources.heart, new Point(11, 38)));
            Controls.Add(new IconPictureBox(Resources.sword, new Point(11, 76)));
            Controls.Add(new IconPictureBox(Resources.energy, new Point(11, 114)));
        }
    }
}
