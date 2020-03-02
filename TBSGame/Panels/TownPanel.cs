using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame.Panels
{
    class TownPanel : Panel
    {
        public DataGridView dgvSelect;
        public TownInfoPanel townInfo;
        public RecruitInfoPanel recruitInfo;
        private DataGridViewColumn Unit;

        public TownPanel()
        {
            Location = new Point(0, 57);
            Size = new Size(308, 285);

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
            dgvSelect.DefaultCellStyle.Font = new Font(dgvSelect.DefaultCellStyle.Font.FontFamily,
                                                       dgvSelect.DefaultCellStyle.Font.Size * height);
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
                //ColumnHeadersVisible = false,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                Location = new Point(190,148),
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Size = new Size(118, 135),
            };
            Unit = new DataGridViewColumn()
            {
                HeaderText = "Unit",
                Name = "Unit",
                ReadOnly = true
            };
            dgvSelect.Columns.Add(Unit);
            Controls.Add(dgvSelect);

            townInfo = new TownInfoPanel();
            Controls.Add(townInfo);

            recruitInfo = new RecruitInfoPanel();
            Controls.Add(recruitInfo);
        }
    }
}
