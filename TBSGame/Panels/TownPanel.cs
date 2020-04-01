using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TBSGame.MapHandler;
using TBSGame.Units;

namespace TBSGame.Panels
{
    class TownPanel : Panel
    {
        public DataGridView dgvSelect;
        public TownInfoPanel townInfo;
        public RecruitInfoPanel recruitInfo;
        private readonly List<UnitInfo> units;

        public TownPanel(List<UnitInfo> units)
        {
            Location = new Point(0, 57);
            Size = new Size(308, 285);
            this.units = units;

            Init();

            ScaleFont(Utils.scale);

            FillDgv();
        }

        private void FillDgv()
        {
            foreach (var unitName in units.Select(x => x.Name))
                dgvSelect.Rows.Add(unitName);
        }

        /// <summary>
        /// Extends the base scale method to scale the font size
        /// </summary>
        public void ScaleFont(SizeF scale)
        {
            dgvSelect.DefaultCellStyle.Font = new Font(dgvSelect.DefaultCellStyle.Font.FontFamily,
                                                       dgvSelect.DefaultCellStyle.Font.Size * Utils.scale.Height);
        }

        /// <summary>
        /// Similar to the designer generated InitializeComponent method, adds the controls
        /// </summary>
        private void Init()
        {
            dgvSelect = new DataGridView()
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeColumns = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.FromArgb(141, 64, 5),
                ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                ColumnHeadersVisible = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                Location = new Point(190, 148),
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Size = new Size(118, 135),
            };
            dgvSelect.SelectionChanged += new EventHandler(SelectUnitFromList);
            dgvSelect.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Unit",
                Name = "Unit",
                ReadOnly = true
            });

            Controls.Add(dgvSelect);

            townInfo = new TownInfoPanel();
            Controls.Add(townInfo);

            recruitInfo = new RecruitInfoPanel();
            Controls.Add(recruitInfo);
        }

        /// <summary>
        /// Sets the stats in the TownInfoPanel. If also the owner of the town, opens up the recruit menu.
        /// </summary>
        /// <param name="t">The town.</param>
        public void TownClick(Town t, bool isOwner)
        {
            townInfo.TownClick(t);
            recruitInfo.Visible = (isOwner && !t.Recruiting && t.Alive);
            dgvSelect.Visible = (isOwner && !t.Recruiting && t.Alive);
        }

        /// <summary>
        /// Determines the selected units and enables the recruit info button.
        /// </summary>
        /// <param name="selectedName">Selected unit name</param>
        private void EnableRecruit(string selectedName)
        {
            recruitInfo.Visible = true;
            recruitInfo.RecruiterClick(units.Single(x => x.Name == selectedName));
        }

        /// <summary>
        /// Runs when an unit is selected from the list of recruitable units.
        /// </summary>
        private void SelectUnitFromList(object sender, EventArgs s)
        {
            EnableRecruit(dgvSelect.SelectedRows[0]
                                   .Cells[0]
                                   .Value
                                   .ToString());
        }
    }
}
