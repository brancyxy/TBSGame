using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBSGame.Misc;
using TBSGame.Properties;

namespace TBSGame.Panels
{
    class UnitInfoPanel : Panel
    {
        public Label UnitCoords { private set; get; }
        public RichTextBox UnitDescDisplay { private set; get; }
        public Label UnitNameDisplay { private set; get; }
        public Label UnitHealthDisplay { private set; get; }
        public ProgressBar UnitHealthBar { private set; get; }
        public Label UnitDamageDisplay { private set; get; }
        public Label UnitActionPointDisplay { private set; get; }
        public ProgressBar UnitActionPointBar { private set; get; }
        private IconPictureBox HealthIcon { get; set; }
        private IconPictureBox DamageIcon { get; set; }
        private IconPictureBox ActionPointIcon { get; set; }



        public UnitInfoPanel()
        {
            Size = new Size(190, 250);
            Location = new Point(0, 114);
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
            UnitNameDisplay.Font = new Font(UnitNameDisplay.Font.FontFamily,
                                            UnitNameDisplay.Font.Size * height);

            UnitCoords.Font = new Font(UnitCoords.Font.FontFamily,
                                       UnitCoords.Font.Size * height);

            UnitHealthDisplay.Font = new Font(UnitHealthDisplay.Font.FontFamily,
                                              UnitHealthDisplay.Font.Size * height);

            UnitDescDisplay.Font = new Font(UnitDescDisplay.Font.FontFamily,
                                            UnitDescDisplay.Font.Size * height);

            UnitDamageDisplay.Font = new Font(UnitDamageDisplay.Font.FontFamily,
                                              UnitDamageDisplay.Font.Size * height);

            UnitActionPointDisplay.Font = new Font(UnitActionPointDisplay.Font.FontFamily,
                                                   UnitActionPointDisplay.Font.Size * height);
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            UnitNameDisplay = new Label()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                ForeColor = Color.Black,
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 15),
                Margin = new Padding(0),
                MinimumSize = new Size(137, 0),
                Size = new Size(137, 12),
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(UnitNameDisplay);

            UnitCoords = new Label()
            {
                Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F),
                AutoSize = true,
                Location = new Point(27, 25),
                Margin = new Padding(0),
                MinimumSize = new Size(114, 0),
                Size = new Size(114, 12),
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(UnitCoords);

            UnitHealthDisplay = new Label()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 48),
                Margin = new Padding(0),
                MinimumSize = new Size(137, 0),
                Size = new Size(137, 12),
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(UnitHealthDisplay);

            UnitHealthBar = new ProgressBar()
            {
                BackColor = Color.FromArgb(158, 123, 11),
                ForeColor = Color.Black,
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 38),
                Margin = new Padding(0),
                MarqueeAnimationSpeed = 0,
                Maximum = 10,
                MinimumSize = new Size(137, 9),
                Size = new Size(137, 10),
                Step = 1,
                Style = ProgressBarStyle.Continuous,
            };
            Controls.Add(UnitHealthBar);

            UnitDescDisplay = new RichTextBox()
            {
                BackColor = Color.FromArgb(141, 64, 5),
                BorderStyle = BorderStyle.None,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                Location = new Point(8, 152),
                ReadOnly = true,
                Size = new Size(175, 91),
                Text = ""
            };
            Controls.Add(UnitDescDisplay);

            UnitDamageDisplay = new Label()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                ForeColor = Color.Transparent,
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 76),
                Margin = new Padding(0),
                MinimumSize = new Size(137, 0),
                Size = new Size(137, 12),
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter
            };
            Controls.Add(UnitDamageDisplay);

            UnitActionPointDisplay = new Label()
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 6.27F),
                ForeColor = Color.Black,
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 124),
                Margin = new Padding(0),
                MinimumSize = new Size(137, 0),
                Size = new Size(137, 12),
                Text = "",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            Controls.Add(UnitActionPointDisplay);

            UnitActionPointBar = new ProgressBar()
            {
                BackColor = Color.FromArgb(158, 123, 11),
                ForeColor = Color.Black,
                ImeMode = ImeMode.NoControl,
                Location = new Point(27, 114),
                Margin = new Padding(0),
                MarqueeAnimationSpeed = 0,
                Maximum = 10,
                MinimumSize = new Size(137, 10),
                Size = new Size(137, 10),
                Step = 1,
                Style = ProgressBarStyle.Continuous
        };
            Controls.Add(UnitActionPointBar);

            HealthIcon = new IconPictureBox(Resources.heart, new Point(11, 38));
            Controls.Add(HealthIcon);

            DamageIcon = new IconPictureBox(Resources.sword, new Point(11, 76));
            Controls.Add(DamageIcon);

            ActionPointIcon = new IconPictureBox(Resources.energy, new Point(11, 114));
            Controls.Add(ActionPointIcon);
        }
    }
}
