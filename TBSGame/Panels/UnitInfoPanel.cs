using System.Drawing;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;
using TBSGame.Units;

namespace TBSGame.Panels
{
    class UnitInfoPanel : Panel
    {
        private DisplayLabel unitNameDisplay;
        private DisplayLabel unitCoords;

        private DisplayLabel unitHealthDisplay;
        private ResourceBar unitHealthBar;

        private DisplayLabel unitDamageDisplay;

        private DisplayLabel unitActionPointDisplay;
        private ResourceBar unitActionPointBar;

        private RichTextBox unitDescDisplay;

        public UnitInfoPanel()
        {
            Size = new Size(308, 216);
            Location = new Point(0, 126);
            BackColor = Color.FromArgb(128, 64, 0);

            Init();

            ScaleFont(Utils.scale);
        }

        /// <summary>
        /// Extends the base scale method to scale the font size
        /// </summary>
        public void ScaleFont(SizeF scale)
        {
            Font scaledFont = DisplayLabel.ScaledFont(scale.Height);

            unitNameDisplay.Font = scaledFont;
            unitCoords.Font = scaledFont;
            unitHealthDisplay.Font = scaledFont;
            unitDescDisplay.Font = scaledFont;
            unitDamageDisplay.Font = scaledFont;
            unitActionPointDisplay.Font = scaledFont;
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            unitNameDisplay = new DisplayLabel(new Point(100, 12));
            Controls.Add(unitNameDisplay);

            unitCoords = new DisplayLabel(new Point(100, 25));
            Controls.Add(unitCoords);

            unitHealthDisplay = new DisplayLabel(new Point(100, 44));
            Controls.Add(unitHealthDisplay);

            unitHealthBar = new ResourceBar(new Point(100, 38));
            Controls.Add(unitHealthBar);

            unitDescDisplay = new RichTextBox()
            {
                BackColor = Color.FromArgb(141, 64, 5),
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                Location = new Point(8, 142),
                ReadOnly = true,
                Size = new Size(292, 71),
                Text = ""
            };
            Controls.Add(unitDescDisplay);

            unitDamageDisplay = new DisplayLabel(new Point(100, 76));
            Controls.Add(unitDamageDisplay);

            unitActionPointDisplay = new DisplayLabel(new Point(100, 110));
            Controls.Add(unitActionPointDisplay);

            unitActionPointBar = new ResourceBar(new Point(100, 104));
            Controls.Add(unitActionPointBar);

            Controls.Add(new IconPictureBox(Resources.heart, new Point(75, 38)));
            Controls.Add(new IconPictureBox(Resources.sword, new Point(75, 76)));
            Controls.Add(new IconPictureBox(Resources.energy, new Point(75, 104)));
        }

        /// <summary>
        /// Sets the values of the labels to the clicked unit
        /// </summary>
        public void UnitClick(Unit u)
        {
            unitNameDisplay.Text = u.UnitName;

            unitCoords.Text = $"{u.Coords.X}:{u.Coords.Y}";

            unitHealthDisplay.Text = $"{u.CurrentHealth}/{u.MaxHealth}";
            unitHealthBar.Maximum = u.MaxHealth;
            unitHealthBar.Value = u.CurrentHealth;

            unitDamageDisplay.Text = $"{u.MinDamage}-{u.MaxDamage}";

            unitActionPointDisplay.Text = $"{u.CurrentActionPoints}/{u.MaxActionPoints}";
            unitActionPointBar.Maximum = u.MaxActionPoints;
            unitActionPointBar.Value = u.CurrentActionPoints;

            unitDescDisplay.Text = u.Description;
        }
    }
}
