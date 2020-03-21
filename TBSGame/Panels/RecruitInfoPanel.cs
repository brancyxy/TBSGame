using System.Drawing;
using System.Windows.Forms;
using TBSGame.MapHandler;
using TBSGame.Misc;
using TBSGame.Properties;

namespace TBSGame.Panels
{
    class RecruitInfoPanel : Panel
    {
        private DisplayLabel unitName,
                             unitHealth,
                             unitDamage,
                             unitActionPoints,
                             unitRecruitTime;

        public Button recruit;

        public UnitInfo RecruitingUnit { get; private set; }

        public RecruitInfoPanel()
        {

            Location = new Point(0, 0);
            Size = new Size(308, 148);

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
            unitName.Font = new Font(unitName.Font.FontFamily,
                                     unitName.Font.Size * height);

            unitHealth.Font = new Font(unitHealth.Font.FontFamily,
                                       unitHealth.Font.Size * height);

            unitDamage.Font = new Font(unitDamage.Font.FontFamily,
                                       unitDamage.Font.Size * height);

            unitActionPoints.Font = new Font(unitActionPoints.Font.FontFamily,
                                             unitActionPoints.Font.Size * height);

            unitRecruitTime.Font = new Font(unitRecruitTime.Font.FontFamily,
                                            unitRecruitTime.Font.Size * height);

            recruit.Font = new Font(recruit.Font.FontFamily,
                                    recruit.Font.Size * height);
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            unitName = new DisplayLabel(new Point(80, 10));
            Controls.Add(unitName);

            unitHealth = new DisplayLabel(new Point(15, 30));
            Controls.Add(unitHealth);

            unitDamage = new DisplayLabel(new Point(165, 30));
            Controls.Add(unitDamage);

            unitActionPoints = new DisplayLabel(new Point(15, 60));
            Controls.Add(unitActionPoints);

            unitRecruitTime = new DisplayLabel(new Point(165, 60));
            Controls.Add(unitRecruitTime);

            recruit = new Button()
            {
                Font = new Font("Bookman Old Style", 11.5F),
                Location = new Point(19, 102),
                Size = new Size(266, 30),
                Text = "Recruit",
                UseVisualStyleBackColor = false
            };
            Controls.Add(recruit);

            Controls.Add(new IconPictureBox(Resources.heart, new Point(0, 30)));
            Controls.Add(new IconPictureBox(Resources.sword, new Point(150, 30)));
            Controls.Add(new IconPictureBox(Resources.energy, new Point(0, 60)));
            Controls.Add(new IconPictureBox(Resources.time, new Point(150, 60)));
        }
        /// <summary>
        /// Sets the labels to display the stats of the recruiting unit.
        /// </summary>
        public void RecruiterClick(UnitInfo unit)
        {
            RecruitingUnit = unit;
            unitName.Text = unit.Name;
            unitHealth.Text = unit.Health + "";
            unitDamage.Text = $"{unit.MinDamage}-{unit.MaxDamage}";
            unitActionPoints.Text = unit.ActionPoints + "";
            unitRecruitTime.Text = unit.RecruitTime + "";
        }
    }
}
