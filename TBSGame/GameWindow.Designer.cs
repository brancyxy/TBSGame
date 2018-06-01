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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Panel();
            this.selectedUnitName = new System.Windows.Forms.Label();
            this.APdisplay = new System.Windows.Forms.Label();
            this.APlabel = new System.Windows.Forms.Label();
            this.APbar = new System.Windows.Forms.ProgressBar();
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.TitleBar.SuspendLayout();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.White;
            this.TitleBar.Controls.Add(this.Minimize);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.CloseButton);
            resources.ApplyResources(this.TitleBar, "TitleBar");
            this.TitleBar.Name = "TitleBar";
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::TBSGame.Properties.Resources.Minimize;
            resources.ApplyResources(this.Minimize, "Minimize");
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.Name = "Minimize";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // CloseButton
            // 
            resources.ApplyResources(this.CloseButton, "CloseButton");
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.UseMnemonic = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.APdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // GameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.info);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.PlayerNameDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Label APlabel;
        private System.Windows.Forms.ProgressBar APbar;
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Label APdisplay;
        private System.Windows.Forms.Label selectedUnitName;
        private System.Windows.Forms.Panel actionPanel;
    }
}

