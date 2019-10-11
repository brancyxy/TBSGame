namespace TBSGame
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
            this.p2Label = new System.Windows.Forms.Label();
            this.p2NameBox = new System.Windows.Forms.TextBox();
            this.p1Label = new System.Windows.Forms.Label();
            this.p1NameBox = new System.Windows.Forms.TextBox();
            this.helpOpen = new System.Windows.Forms.Label();
            this.mapOpener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p2Label
            // 
            this.p2Label.AutoSize = true;
            this.p2Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.p2Label.Location = new System.Drawing.Point(200, 200);
            this.p2Label.Name = "p2Label";
            this.p2Label.Size = new System.Drawing.Size(77, 13);
            this.p2Label.TabIndex = 5;
            this.p2Label.Text = "Player 2 name:";
            // 
            // p2NameBox
            // 
            this.p2NameBox.Location = new System.Drawing.Point(280, 195);
            this.p2NameBox.Name = "p2NameBox";
            this.p2NameBox.Size = new System.Drawing.Size(100, 20);
            this.p2NameBox.TabIndex = 4;
            // 
            // p1Label
            // 
            this.p1Label.AutoSize = true;
            this.p1Label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.p1Label.Location = new System.Drawing.Point(200, 175);
            this.p1Label.Name = "p1Label";
            this.p1Label.Size = new System.Drawing.Size(77, 13);
            this.p1Label.TabIndex = 3;
            this.p1Label.Text = "Player 1 name:";
            // 
            // p1NameBox
            // 
            this.p1NameBox.Location = new System.Drawing.Point(280, 170);
            this.p1NameBox.Name = "p1NameBox";
            this.p1NameBox.Size = new System.Drawing.Size(100, 20);
            this.p1NameBox.TabIndex = 2;
            // 
            // helpOpen
            // 
            this.helpOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.helpOpen.Location = new System.Drawing.Point(200, 225);
            this.helpOpen.Name = "helpOpen";
            this.helpOpen.Size = new System.Drawing.Size(177, 43);
            this.helpOpen.TabIndex = 1;
            this.helpOpen.Text = "Open a map file. Map files must be named \"map.YFY\", and all their resources must " +
    "be in same directory";
            // 
            // mapOpener
            // 
            this.mapOpener.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mapOpener.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mapOpener.Location = new System.Drawing.Point(250, 275);
            this.mapOpener.Name = "mapOpener";
            this.mapOpener.Size = new System.Drawing.Size(75, 23);
            this.mapOpener.TabIndex = 0;
            this.mapOpener.Text = "Select";
            this.mapOpener.UseVisualStyleBackColor = false;
            this.mapOpener.Click += new System.EventHandler(this.mapOpener_Click);
            // 
            // MapSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.p1Label);
            this.Controls.Add(this.p2Label);
            this.Controls.Add(this.p1NameBox);
            this.Controls.Add(this.p2NameBox);
            this.Controls.Add(this.mapOpener);
            this.Controls.Add(this.helpOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MapSelector";
            this.Text = "Map selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.TextBox p2NameBox;
        private System.Windows.Forms.Label p1Label;
        private System.Windows.Forms.TextBox p1NameBox;
        private System.Windows.Forms.Label helpOpen;
        private System.Windows.Forms.Button mapOpener;
    }
}