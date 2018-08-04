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
            this.unitInfo = new System.Windows.Forms.Panel();
            this.descriptionDisplay = new System.Windows.Forms.Label();
            this.unitNameDisplay = new System.Windows.Forms.Label();
            this.dmgDisplay = new System.Windows.Forms.Label();
            this.dmgIcon = new System.Windows.Forms.PictureBox();
            this.lifeDisplay = new System.Windows.Forms.Label();
            this.lifeBar = new System.Windows.Forms.ProgressBar();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.APIcon = new System.Windows.Forms.PictureBox();
            this.APdisplay = new System.Windows.Forms.Label();
            this.APbar = new System.Windows.Forms.ProgressBar();
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.gameArea = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.infoArea = new System.Windows.Forms.Panel();
            this.unitInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).BeginInit();
            this.topPanel.SuspendLayout();
            this.infoArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitInfo
            // 
            this.unitInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.unitInfo.Controls.Add(this.descriptionDisplay);
            this.unitInfo.Controls.Add(this.unitNameDisplay);
            this.unitInfo.Controls.Add(this.dmgDisplay);
            this.unitInfo.Controls.Add(this.dmgIcon);
            this.unitInfo.Controls.Add(this.lifeDisplay);
            this.unitInfo.Controls.Add(this.lifeBar);
            this.unitInfo.Controls.Add(this.lifeIcon);
            this.unitInfo.Controls.Add(this.APIcon);
            this.unitInfo.Controls.Add(this.APdisplay);
            this.unitInfo.Controls.Add(this.APbar);
            resources.ApplyResources(this.unitInfo, "unitInfo");
            this.unitInfo.Name = "unitInfo";
            // 
            // descriptionDisplay
            // 
            resources.ApplyResources(this.descriptionDisplay, "descriptionDisplay");
            this.descriptionDisplay.BackColor = System.Drawing.Color.Transparent;
            this.descriptionDisplay.Name = "descriptionDisplay";
            // 
            // unitNameDisplay
            // 
            resources.ApplyResources(this.unitNameDisplay, "unitNameDisplay");
            this.unitNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitNameDisplay.Name = "unitNameDisplay";
            // 
            // dmgDisplay
            // 
            resources.ApplyResources(this.dmgDisplay, "dmgDisplay");
            this.dmgDisplay.BackColor = System.Drawing.Color.Transparent;
            this.dmgDisplay.Name = "dmgDisplay";
            // 
            // dmgIcon
            // 
            resources.ApplyResources(this.dmgIcon, "dmgIcon");
            this.dmgIcon.Name = "dmgIcon";
            this.dmgIcon.TabStop = false;
            // 
            // lifeDisplay
            // 
            resources.ApplyResources(this.lifeDisplay, "lifeDisplay");
            this.lifeDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lifeDisplay.Name = "lifeDisplay";
            // 
            // lifeBar
            // 
            this.lifeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.lifeBar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lifeBar, "lifeBar");
            this.lifeBar.MarqueeAnimationSpeed = 0;
            this.lifeBar.Maximum = 10;
            this.lifeBar.Name = "lifeBar";
            this.lifeBar.Step = 1;
            this.lifeBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.lifeBar.Tag = "";
            // 
            // lifeIcon
            // 
            resources.ApplyResources(this.lifeIcon, "lifeIcon");
            this.lifeIcon.Name = "lifeIcon";
            this.lifeIcon.TabStop = false;
            // 
            // APIcon
            // 
            resources.ApplyResources(this.APIcon, "APIcon");
            this.APIcon.Name = "APIcon";
            this.APIcon.TabStop = false;
            // 
            // APdisplay
            // 
            resources.ApplyResources(this.APdisplay, "APdisplay");
            this.APdisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.APdisplay.Name = "APdisplay";
            // 
            // APbar
            // 
            this.APbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.APbar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.APbar, "APbar");
            this.APbar.MarqueeAnimationSpeed = 0;
            this.APbar.Maximum = 10;
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
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.gameArea, "gameArea");
            this.gameArea.Name = "gameArea";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.topPanel.Controls.Add(this.PlayerNameDisplay);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // infoArea
            // 
            this.infoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infoArea.Controls.Add(this.unitInfo);
            resources.ApplyResources(this.infoArea, "infoArea");
            this.infoArea.Name = "infoArea";
            // 
            // GameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.Controls.Add(this.infoArea);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameWindow";
            this.unitInfo.ResumeLayout(false);
            this.unitInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.infoArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel unitInfo;
        private System.Windows.Forms.ProgressBar APbar;
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Label APdisplay;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.PictureBox APIcon;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox lifeIcon;
        private System.Windows.Forms.Label lifeDisplay;
        private System.Windows.Forms.ProgressBar lifeBar;
        private System.Windows.Forms.Label unitNameDisplay;
        private System.Windows.Forms.Label dmgDisplay;
        private System.Windows.Forms.PictureBox dmgIcon;
        private System.Windows.Forms.Label descriptionDisplay;
        private System.Windows.Forms.Panel infoArea;
    }
}

