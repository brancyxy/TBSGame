using System.Drawing;

namespace TBSGame.Menus
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
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.gameArea = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.infoArea = new System.Windows.Forms.Panel();
            this.logger = new System.Windows.Forms.RichTextBox();
            this.tileInfo = new System.Windows.Forms.Panel();
            this.tileCoords = new System.Windows.Forms.Label();
            this.tileDEFrate = new System.Windows.Forms.Label();
            this.tileAPrate = new System.Windows.Forms.Label();
            this.DEFrate = new System.Windows.Forms.Label();
            this.APrate = new System.Windows.Forms.Label();
            this.tileName = new System.Windows.Forms.Label();
            this.tileImage = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.infoArea.SuspendLayout();
            this.tileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameDisplay
            // 
            this.PlayerNameDisplay.AutoSize = true;
            this.PlayerNameDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PlayerNameDisplay.Location = new System.Drawing.Point(100, 12);
            this.PlayerNameDisplay.Name = "PlayerNameDisplay";
            this.PlayerNameDisplay.Size = new System.Drawing.Size(10, 13);
            this.PlayerNameDisplay.TabIndex = 0;
            this.PlayerNameDisplay.Text = " ";
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameArea.Location = new System.Drawing.Point(0, 42);
            this.gameArea.Margin = new System.Windows.Forms.Padding(0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(300, 300);
            this.gameArea.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.topPanel.Controls.Add(this.endTurnButton);
            this.topPanel.Controls.Add(this.PlayerNameDisplay);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(300, 42);
            this.topPanel.TabIndex = 5;
            // 
            // endTurnButton
            // 
            this.endTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.endTurnButton.Location = new System.Drawing.Point(220, 8);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(57, 24);
            this.endTurnButton.TabIndex = 1;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = true;
            this.endTurnButton.Visible = false;
            // 
            // infoArea
            // 
            this.infoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infoArea.Controls.Add(this.tileInfo);
            this.infoArea.Controls.Add(this.logger);
            this.infoArea.Location = new System.Drawing.Point(300, 0);
            this.infoArea.Name = "infoArea";
            this.infoArea.Size = new System.Drawing.Size(308, 342);
            this.infoArea.TabIndex = 6;
            // 
            // logger
            // 
            this.logger.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.7025F);
            this.logger.ForeColor = System.Drawing.Color.White;
            this.logger.Location = new System.Drawing.Point(8, 6);
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(290, 44);
            this.logger.TabIndex = 4;
            this.logger.Text = "";
            // 
            // tileInfo
            // 
            this.tileInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tileInfo.Controls.Add(this.tileCoords);
            this.tileInfo.Controls.Add(this.tileDEFrate);
            this.tileInfo.Controls.Add(this.tileAPrate);
            this.tileInfo.Controls.Add(this.DEFrate);
            this.tileInfo.Controls.Add(this.APrate);
            this.tileInfo.Controls.Add(this.tileImage);
            this.tileInfo.Controls.Add(this.tileName);
            this.tileInfo.Location = new System.Drawing.Point(0, 180);
            this.tileInfo.Name = "tileInfo";
            this.tileInfo.Size = new System.Drawing.Size(308, 162);
            this.tileInfo.TabIndex = 3;
            this.tileInfo.Visible = false;
            // 
            // tileCoords
            // 
            this.tileCoords.AutoSize = true;
            this.tileCoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.tileCoords.Location = new System.Drawing.Point(92, 75);
            this.tileCoords.MaximumSize = new System.Drawing.Size(50, 15);
            this.tileCoords.MinimumSize = new System.Drawing.Size(50, 15);
            this.tileCoords.Name = "tileCoords";
            this.tileCoords.Size = new System.Drawing.Size(50, 15);
            this.tileCoords.TabIndex = 6;
            this.tileCoords.Text = "(xx;xx)";
            this.tileCoords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileDEFrate
            // 
            this.tileDEFrate.AutoSize = true;
            this.tileDEFrate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileDEFrate.Location = new System.Drawing.Point(130, 125);
            this.tileDEFrate.MaximumSize = new System.Drawing.Size(80, 13);
            this.tileDEFrate.MinimumSize = new System.Drawing.Size(80, 13);
            this.tileDEFrate.Name = "tileDEFrate";
            this.tileDEFrate.Size = new System.Drawing.Size(80, 13);
            this.tileDEFrate.TabIndex = 5;
            this.tileDEFrate.Text = "x";
            this.tileDEFrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tileAPrate
            // 
            this.tileAPrate.AutoSize = true;
            this.tileAPrate.Location = new System.Drawing.Point(130, 100);
            this.tileAPrate.MaximumSize = new System.Drawing.Size(80, 13);
            this.tileAPrate.MinimumSize = new System.Drawing.Size(80, 13);
            this.tileAPrate.Name = "tileAPrate";
            this.tileAPrate.Size = new System.Drawing.Size(80, 13);
            this.tileAPrate.TabIndex = 4;
            this.tileAPrate.Text = "x";
            this.tileAPrate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DEFrate
            // 
            this.DEFrate.AutoSize = true;
            this.DEFrate.Location = new System.Drawing.Point(30, 125);
            this.DEFrate.MaximumSize = new System.Drawing.Size(100, 13);
            this.DEFrate.MinimumSize = new System.Drawing.Size(100, 13);
            this.DEFrate.Name = "DEFrate";
            this.DEFrate.Size = new System.Drawing.Size(100, 13);
            this.DEFrate.TabIndex = 3;
            this.DEFrate.Text = "DEF rate:";
            this.DEFrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // APrate
            // 
            this.APrate.AutoSize = true;
            this.APrate.Location = new System.Drawing.Point(30, 100);
            this.APrate.MaximumSize = new System.Drawing.Size(100, 13);
            this.APrate.MinimumSize = new System.Drawing.Size(100, 13);
            this.APrate.Name = "APrate";
            this.APrate.Size = new System.Drawing.Size(100, 13);
            this.APrate.TabIndex = 2;
            this.APrate.Text = "AP consumption:";
            this.APrate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tileName
            // 
            this.tileName.AutoSize = true;
            this.tileName.Location = new System.Drawing.Point(30, 20);
            this.tileName.MaximumSize = new System.Drawing.Size(180, 0);
            this.tileName.MinimumSize = new System.Drawing.Size(180, 0);
            this.tileName.Name = "tileName";
            this.tileName.Size = new System.Drawing.Size(180, 13);
            this.tileName.TabIndex = 0;
            this.tileName.Text = "Tile Name";
            this.tileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileImage
            // 
            this.tileImage.Location = new System.Drawing.Point(100, 43);
            this.tileImage.Margin = new System.Windows.Forms.Padding(0);
            this.tileImage.Name = "tileImage";
            this.tileImage.Size = new System.Drawing.Size(30, 30);
            this.tileImage.TabIndex = 1;
            this.tileImage.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(608, 342);
            this.Controls.Add(this.infoArea);
            this.Controls.Add(this.gameArea);
            this.Controls.Add(this.topPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.infoArea.ResumeLayout(false);
            this.tileInfo.ResumeLayout(false);
            this.tileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel tileInfo;
        private System.Windows.Forms.Label DEFrate;
        private System.Windows.Forms.Label APrate;
        private System.Windows.Forms.PictureBox tileImage;
        private System.Windows.Forms.Label tileName;
        private System.Windows.Forms.Label tileDEFrate;
        private System.Windows.Forms.Label tileAPrate;
        private System.Windows.Forms.Label tileCoords;
        private System.Windows.Forms.RichTextBox logger;
        private System.Windows.Forms.Button endTurnButton;
        internal System.Windows.Forms.Panel infoArea;
        private System.Windows.Forms.Panel gameArea;
    }
}

