using System.Drawing;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;
using TBSGame.Units;

namespace TBSGame.Panels
{
    class TileInfoPanel : Panel
    {
        private DisplayLabel tileName,
                             tileCoords,
                             tileActionPointReductionDisplay,
                             tileDefenseBonusDisplay,
                             tileActionPointReductionText,
                             tileDefenseBonusText;

        private PictureBox tileImage;


        public TileInfoPanel()
        {
            BackColor = Color.FromArgb(128, 64, 0);
            Location = new Point(0, 180);
            Size = new Size(308, 162);

            Init();
            ScaleFont(Utils.scale);
        }

        /// <summary>
        /// Extends the base scale method to scale the font size
        /// </summary>
        public void ScaleFont(SizeF scale)
        {
            Font scaledFont = DisplayLabel.ScaledFont(scale.Height);

            tileName.Font = scaledFont;
            tileCoords.Font = scaledFont;
            tileActionPointReductionDisplay.Font = scaledFont;
            tileDefenseBonusDisplay.Font = scaledFont;
            tileActionPointReductionText.Font = scaledFont;
            tileDefenseBonusText.Font = scaledFont;
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            tileName = new DisplayLabel(new Point(70, 15));
            Controls.Add(tileName);

            tileCoords = new DisplayLabel(new Point(70, 70));
            Controls.Add(tileCoords);

            tileImage = new PictureBox()
            {
                Location = new Point(122, 35),
                Margin = new Padding(0),
                Size = new Size(30, 30),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(tileImage);

            tileActionPointReductionDisplay = new DisplayLabel(new Point(160, 100));
            Controls.Add(tileActionPointReductionDisplay);

            tileDefenseBonusDisplay = new DisplayLabel(new Point(160, 125));
            Controls.Add(tileDefenseBonusDisplay);

            tileActionPointReductionText = new DisplayLabel(new Point(25, 100))
            {
                Text = "AP consumption:"
            };
            Controls.Add(tileActionPointReductionText);

            tileDefenseBonusText = new DisplayLabel(new Point(25, 125))
            {
                Text = "DEF rate:"
            };
            Controls.Add(tileDefenseBonusText);

            Controls.Add(new IconPictureBox(Resources.energy, new Point(5, 100)));
            Controls.Add(new IconPictureBox(Resources.shield, new Point(5, 125)));


        }
        /// <summary>
        /// Sets the texts to the stats of the tile
        /// </summary>
        /// <param name="t">The clicked tile</param>
        public void TileClick(Tile t)
        {
            Visible = true;

            tileName.Text = t.Name;
            tileCoords.Text = $"({t.Coords.X};{t.Coords.Y})";
            tileActionPointReductionDisplay.Text = t.ActionPointReduction.ToString();
            tileDefenseBonusDisplay.Text = (t.ArmorBonus * 100).ToString() + '%';
            tileImage.Image = t.BackgroundImage;
        }
    }
}
