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

            Scale(Utils.scale);
            ScaleFontSize(Utils.scale.Height);
        }

        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            tileName.Font = new Font(tileName.Font.FontFamily,
                                     tileName.Font.Size * height);

            tileCoords.Font = new Font(tileCoords.Font.FontFamily,
                                       tileCoords.Font.Size * height);

            tileActionPointReductionDisplay.Font = new Font(tileActionPointReductionDisplay.Font.FontFamily,
                                                            tileActionPointReductionDisplay.Font.Size * height);

            tileDefenseBonusDisplay.Font = new Font(tileDefenseBonusDisplay.Font.FontFamily,
                                                    tileDefenseBonusDisplay.Font.Size * height);

            tileActionPointReductionText.Font = new Font(tileActionPointReductionText.Font.FontFamily,
                                                         tileActionPointReductionText.Font.Size * height);

            tileDefenseBonusText.Font = new Font(tileDefenseBonusText.Font.FontFamily,
                                                 tileDefenseBonusText.Font.Size * height);
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
