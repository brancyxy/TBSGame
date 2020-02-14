namespace TBSGame.Menus
{
    partial class MainMenu
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
            this.TopField = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.TopField.SuspendLayout();
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
            this.TopField.TabIndex = 7;
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
            this.lbTitle.Size = new System.Drawing.Size(81, 18);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 342);
            this.Controls.Add(this.TopField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Map selector";
            this.TopField.ResumeLayout(false);
            this.TopField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopField;
        private System.Windows.Forms.Label lbTitle;
    }
}