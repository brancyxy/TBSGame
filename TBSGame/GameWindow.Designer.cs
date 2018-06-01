namespace TBSGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.info = new System.Windows.Forms.Panel();
            this.selectedUnitName = new System.Windows.Forms.Label();
            this.APdisplay = new System.Windows.Forms.Label();
            this.APlabel = new System.Windows.Forms.Label();
            this.APbar = new System.Windows.Forms.ProgressBar();
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.info.Controls.Add(this.selectedUnitName);
            this.info.Controls.Add(this.APdisplay);
            this.info.Controls.Add(this.APlabel);
            this.info.Controls.Add(this.APbar);
            resources.ApplyResources(this.info, "info");
            this.info.Name = "info";
            // 
            // selectedUnitName
            // 
            resources.ApplyResources(this.selectedUnitName, "selectedUnitName");
            this.selectedUnitName.Name = "selectedUnitName";
            // 
            // APdisplay
            // 
            resources.ApplyResources(this.APdisplay, "APdisplay");
            this.APdisplay.BackColor = System.Drawing.Color.White;
            this.APdisplay.Name = "APdisplay";
            // 
            // APlabel
            // 
            resources.ApplyResources(this.APlabel, "APlabel");
            this.APlabel.Name = "APlabel";
            // 
            // APbar
            // 
            this.APbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.APbar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.APbar, "APbar");
            this.APbar.MarqueeAnimationSpeed = 0;
            this.APbar.Maximum = 12;
            this.APbar.Name = "APbar";
            this.APbar.Step = 1;
            this.APbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.APbar.Tag = "";
            // 
            // PlayerNameDisplay
            // 
            resources.ApplyResources(this.PlayerNameDisplay, "PlayerNameDisplay");
            this.PlayerNameDisplay.Name = "PlayerNameDisplay";
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.actionPanel, "actionPanel");
            this.actionPanel.Name = "actionPanel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.PlayerNameDisplay);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // GameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Label APlabel;
        private System.Windows.Forms.ProgressBar APbar;
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Label APdisplay;
        private System.Windows.Forms.Label selectedUnitName;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel panel1;
    }
}

