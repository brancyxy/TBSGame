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
            this.lifeDisplay = new System.Windows.Forms.Label();
            this.lifeBar = new System.Windows.Forms.ProgressBar();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.APIcon = new System.Windows.Forms.PictureBox();
            this.APdisplay = new System.Windows.Forms.Label();
            this.APbar = new System.Windows.Forms.ProgressBar();
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dmgIcon = new System.Windows.Forms.PictureBox();
            this.dmgDisplay = new System.Windows.Forms.Label();
            this.unitNameDisplay = new System.Windows.Forms.Label();
            this.infoArea = new System.Windows.Forms.Panel();
            this.descriptionDisplay = new System.Windows.Forms.Label();
            this.unitInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).BeginInit();
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
            this.unitInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.info_Paint);
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
            this.lifeIcon.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.PlayerNameDisplay);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // dmgIcon
            // 
            resources.ApplyResources(this.dmgIcon, "dmgIcon");
            this.dmgIcon.Name = "dmgIcon";
            this.dmgIcon.TabStop = false;
            // 
            // dmgDisplay
            // 
            resources.ApplyResources(this.dmgDisplay, "dmgDisplay");
            this.dmgDisplay.BackColor = System.Drawing.Color.Transparent;
            this.dmgDisplay.Name = "dmgDisplay";
            // 
            // unitNameDisplay
            // 
            resources.ApplyResources(this.unitNameDisplay, "unitNameDisplay");
            this.unitNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitNameDisplay.Name = "unitNameDisplay";
            // 
            // infoArea
            // 
            this.infoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infoArea.Controls.Add(this.unitInfo);
            resources.ApplyResources(this.infoArea, "infoArea");
            this.infoArea.Name = "infoArea";
            // 
            // descriptionDisplay
            // 
            resources.ApplyResources(this.descriptionDisplay, "descriptionDisplay");
            this.descriptionDisplay.BackColor = System.Drawing.Color.Transparent;
            this.descriptionDisplay.Name = "descriptionDisplay";
            // 
            // GameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.Controls.Add(this.infoArea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameWindow";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.unitInfo.ResumeLayout(false);
            this.unitInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).EndInit();
            this.infoArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel unitInfo;
        private System.Windows.Forms.ProgressBar APbar;
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Label APdisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox APIcon;
        private System.Windows.Forms.Panel panel2;
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

