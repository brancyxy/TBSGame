namespace TBSGame.Menus
{
    partial class MapSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopField = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dgvMapSelector = new System.Windows.Forms.DataGridView();
            this.mapPlayerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtbMapDebugLog = new System.Windows.Forms.RichTextBox();
            this.rtbMapDebugLogPadding = new System.Windows.Forms.Panel();
            this.selectMap = new System.Windows.Forms.Button();
            this.TopField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapSelector)).BeginInit();
            this.rtbMapDebugLogPadding.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopField
            // 
            this.TopField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopField.Controls.Add(this.lbTitle);
            this.TopField.Location = new System.Drawing.Point(0, 0);
            this.TopField.Name = "TopField";
            this.TopField.Size = new System.Drawing.Size(608, 35);
            this.TopField.TabIndex = 6;
            this.TopField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseDown);
            this.TopField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseMove);
            this.TopField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseUp);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.ForeColor = System.Drawing.Color.Black;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(94, 18);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Map selector";
            // 
            // dgvMapSelector
            // 
            this.dgvMapSelector.AllowUserToAddRows = false;
            this.dgvMapSelector.AllowUserToDeleteRows = false;
            this.dgvMapSelector.AllowUserToResizeColumns = false;
            this.dgvMapSelector.AllowUserToResizeRows = false;
            this.dgvMapSelector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMapSelector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMapSelector.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMapSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMapSelector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMapSelector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMapSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapSelector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mapPlayerCount,
            this.mapName,
            this.mapCreator,
            this.MapFileName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Handwriting", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMapSelector.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMapSelector.EnableHeadersVisualStyles = false;
            this.dgvMapSelector.Location = new System.Drawing.Point(0, 35);
            this.dgvMapSelector.MultiSelect = false;
            this.dgvMapSelector.Name = "dgvMapSelector";
            this.dgvMapSelector.ReadOnly = true;
            this.dgvMapSelector.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMapSelector.RowHeadersVisible = false;
            this.dgvMapSelector.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMapSelector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMapSelector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMapSelector.Size = new System.Drawing.Size(350, 307);
            this.dgvMapSelector.TabIndex = 7;
            this.dgvMapSelector.SelectionChanged += new System.EventHandler(this.SelectFromList);
            // 
            // mapPlayerCount
            // 
            this.mapPlayerCount.FillWeight = 35F;
            this.mapPlayerCount.HeaderText = "Players";
            this.mapPlayerCount.MaxInputLength = 2;
            this.mapPlayerCount.MinimumWidth = 62;
            this.mapPlayerCount.Name = "mapPlayerCount";
            this.mapPlayerCount.ReadOnly = true;
            // 
            // mapName
            // 
            this.mapName.FillWeight = 70.64115F;
            this.mapName.HeaderText = "Name";
            this.mapName.MinimumWidth = 160;
            this.mapName.Name = "mapName";
            this.mapName.ReadOnly = true;
            // 
            // mapCreator
            // 
            this.mapCreator.FillWeight = 45F;
            this.mapCreator.HeaderText = "Created By";
            this.mapCreator.MinimumWidth = 100;
            this.mapCreator.Name = "mapCreator";
            this.mapCreator.ReadOnly = true;
            // 
            // MapFileName
            // 
            this.MapFileName.HeaderText = "File";
            this.MapFileName.Name = "MapFileName";
            this.MapFileName.ReadOnly = true;
            this.MapFileName.Visible = false;
            // 
            // rtbMapDebugLog
            // 
            this.rtbMapDebugLog.BackColor = System.Drawing.Color.White;
            this.rtbMapDebugLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMapDebugLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMapDebugLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMapDebugLog.ForeColor = System.Drawing.Color.Black;
            this.rtbMapDebugLog.HideSelection = false;
            this.rtbMapDebugLog.Location = new System.Drawing.Point(5, 5);
            this.rtbMapDebugLog.Name = "rtbMapDebugLog";
            this.rtbMapDebugLog.ReadOnly = true;
            this.rtbMapDebugLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbMapDebugLog.Size = new System.Drawing.Size(248, 90);
            this.rtbMapDebugLog.TabIndex = 8;
            this.rtbMapDebugLog.Text = "";
            // 
            // rtbMapDebugLogPadding
            // 
            this.rtbMapDebugLogPadding.BackColor = System.Drawing.Color.White;
            this.rtbMapDebugLogPadding.Controls.Add(this.rtbMapDebugLog);
            this.rtbMapDebugLogPadding.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rtbMapDebugLogPadding.Location = new System.Drawing.Point(350, 35);
            this.rtbMapDebugLogPadding.Name = "rtbMapDebugLogPadding";
            this.rtbMapDebugLogPadding.Padding = new System.Windows.Forms.Padding(5);
            this.rtbMapDebugLogPadding.Size = new System.Drawing.Size(258, 100);
            this.rtbMapDebugLogPadding.TabIndex = 9;
            // 
            // selectMap
            // 
            this.selectMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.selectMap.FlatAppearance.BorderSize = 0;
            this.selectMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMap.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectMap.Location = new System.Drawing.Point(410, 264);
            this.selectMap.Name = "selectMap";
            this.selectMap.Size = new System.Drawing.Size(146, 40);
            this.selectMap.TabIndex = 10;
            this.selectMap.Text = "Select";
            this.selectMap.UseVisualStyleBackColor = false;
            this.selectMap.Click += new System.EventHandler(this.Select);
            // 
            // MapSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 342);
            this.Controls.Add(this.selectMap);
            this.Controls.Add(this.dgvMapSelector);
            this.Controls.Add(this.TopField);
            this.Controls.Add(this.rtbMapDebugLogPadding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapSelector";
            this.Text = "Map selector";
            this.TopField.ResumeLayout(false);
            this.TopField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapSelector)).EndInit();
            this.rtbMapDebugLogPadding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopField;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dgvMapSelector;
        private System.Windows.Forms.RichTextBox rtbMapDebugLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapPlayerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapFileName;
        private System.Windows.Forms.Panel rtbMapDebugLogPadding;
        private System.Windows.Forms.Button selectMap;
    }
}