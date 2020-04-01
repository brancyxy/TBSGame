using System.Drawing;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;
using TBSGame.Units;

namespace TBSGame.Panels
{
    class TownInfoPanel : Panel
    {
        private DisplayLabel townCoords,
                             townHealthDisplay,
                             townText;

        private ResourceBar townHealthBar;
        public TownInfoPanel()
        {
            Location = new Point(0, 148);
            Size = new Size(190, 135);

            Init();

            ScaleFont(Utils.scale);
        }
        /// <summary>
        /// Sets the display texts for the stats of the town.
        /// </summary>
        /// <param name="t">The town</param>
        public void TownClick(Town t)
        {
            townCoords.Text = $"{t.Coords.X};{t.Coords.Y}";
            townHealthBar.Maximum = t.MaxHealth;
            townHealthBar.Value = t.CurrentHealth;
            townHealthDisplay.Text = $"{t.CurrentHealth}/{t.MaxHealth}";
        }

        /// <summary>
        /// Extends the base scale method to scale the font size
        /// </summary>
        public void ScaleFont(SizeF scale)
        {
            Font scaledFont = DisplayLabel.ScaledFont(scale.Height);

            townCoords.Font = scaledFont;
            townHealthDisplay.Font = scaledFont;
            townText.Font = scaledFont;
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            townText = new DisplayLabel(new Point(27, 42))
            {
                Text = "Town"
            };
            Controls.Add(townText);

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
