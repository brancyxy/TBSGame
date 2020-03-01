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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.gameArea = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.infoArea = new System.Windows.Forms.Panel();
            this.townMenu = new System.Windows.Forms.Panel();
            this.townCoords = new System.Windows.Forms.Label();
            this.recruitArea = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.townHPdisplay = new System.Windows.Forms.Label();
            this.townHPbar = new System.Windows.Forms.ProgressBar();
            this.townHPBox = new System.Windows.Forms.PictureBox();
            this.logger = new System.Windows.Forms.RichTextBox();
            this.tileInfo = new System.Windows.Forms.Panel();
            this.tileCoords = new System.Windows.Forms.Label();
            this.tileDEFrate = new System.Windows.Forms.Label();
            this.tileAPrate = new System.Windows.Forms.Label();
            this.DEFrate = new System.Windows.Forms.Label();
            this.APrate = new System.Windows.Forms.Label();
            this.tileImage = new System.Windows.Forms.PictureBox();
            this.tileName = new System.Windows.Forms.Label();
            this.recruitInfo = new System.Windows.Forms.Panel();
            this.recruit = new System.Windows.Forms.Button();
            this.recUnitTime = new System.Windows.Forms.Label();
            this.recUnitName = new System.Windows.Forms.Label();
            this.recUnitDMG = new System.Windows.Forms.Label();
            this.DMG = new System.Windows.Forms.PictureBox();
            this.recUnitHP = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.PictureBox();
            this.AP = new System.Windows.Forms.PictureBox();
            this.recUnitAP = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.infoArea.SuspendLayout();
            this.townMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townHPBox)).BeginInit();
            this.tileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).BeginInit();
            this.recruitInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerNameDisplay
            // 
            this.PlayerNameDisplay.AutoSize = true;
            this.PlayerNameDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PlayerNameDisplay.Location = new System.Drawing.Point(186, 12);
            this.PlayerNameDisplay.Name = "PlayerNameDisplay";
            this.PlayerNameDisplay.Size = new System.Drawing.Size(10, 13);
            this.PlayerNameDisplay.TabIndex = 0;
            this.PlayerNameDisplay.Text = " ";
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameArea.Location = new System.Drawing.Point(19, 57);
            this.gameArea.Margin = new System.Windows.Forms.Padding(0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(380, 380);
            this.gameArea.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.topPanel.Controls.Add(this.endTurnButton);
            this.topPanel.Controls.Add(this.PlayerNameDisplay);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(418, 38);
            this.topPanel.TabIndex = 5;
            // 
            // endTurnButton
            // 
            this.endTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.endTurnButton.Location = new System.Drawing.Point(350, 8);
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
            this.infoArea.Controls.Add(this.townMenu);
            this.infoArea.Controls.Add(this.logger);
            this.infoArea.Controls.Add(this.tileInfo);
            this.infoArea.Location = new System.Drawing.Point(418, 0);
            this.infoArea.Name = "infoArea";
            this.infoArea.Size = new System.Drawing.Size(250, 600);
            this.infoArea.TabIndex = 6;
            // 
            // townMenu
            // 
            this.townMenu.Controls.Add(this.townCoords);
            this.townMenu.Controls.Add(this.recruitArea);
            this.townMenu.Controls.Add(this.label1);
            this.townMenu.Controls.Add(this.townHPdisplay);
            this.townMenu.Controls.Add(this.townHPbar);
            this.townMenu.Controls.Add(this.townHPBox);
            this.townMenu.Location = new System.Drawing.Point(0, 350);
            this.townMenu.Name = "townMenu";
            this.townMenu.Size = new System.Drawing.Size(250, 250);
            this.townMenu.TabIndex = 5;
            this.townMenu.Visible = false;
            // 
            // townCoords
            // 
            this.townCoords.AutoSize = true;
            this.townCoords.Location = new System.Drawing.Point(95, 18);
            this.townCoords.MaximumSize = new System.Drawing.Size(50, 12);
            this.townCoords.MinimumSize = new System.Drawing.Size(50, 12);
            this.townCoords.Name = "townCoords";
            this.townCoords.Size = new System.Drawing.Size(50, 12);
            this.townCoords.TabIndex = 18;
            this.townCoords.Text = "X;Y";
            this.townCoords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recruitArea
            // 
            this.recruitArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            this.recruitArea.Location = new System.Drawing.Point(0, 80);
            this.recruitArea.Name = "recruitArea";
            this.recruitArea.Size = new System.Drawing.Size(250, 170);
            this.recruitArea.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Town";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // townHPdisplay
            // 
            this.townHPdisplay.AutoSize = true;
            this.townHPdisplay.BackColor = System.Drawing.Color.Transparent;
            this.townHPdisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.townHPdisplay.Location = new System.Drawing.Point(35, 63);
            this.townHPdisplay.Margin = new System.Windows.Forms.Padding(0);
            this.townHPdisplay.MaximumSize = new System.Drawing.Size(180, 0);
            this.townHPdisplay.MinimumSize = new System.Drawing.Size(180, 0);
            this.townHPdisplay.Name = "townHPdisplay";
            this.townHPdisplay.Size = new System.Drawing.Size(180, 13);
            this.townHPdisplay.TabIndex = 15;
            this.townHPdisplay.Text = "0/0";
            this.townHPdisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // townHPbar
            // 
            this.townHPbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.townHPbar.ForeColor = System.Drawing.Color.Black;
            this.townHPbar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.townHPbar.Location = new System.Drawing.Point(35, 50);
            this.townHPbar.Margin = new System.Windows.Forms.Padding(0);
            this.townHPbar.MarqueeAnimationSpeed = 0;
            this.townHPbar.Maximum = 10;
            this.townHPbar.MaximumSize = new System.Drawing.Size(180, 13);
            this.townHPbar.Name = "townHPbar";
            this.townHPbar.Size = new System.Drawing.Size(180, 13);
            this.townHPbar.Step = 1;
            this.townHPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.townHPbar.TabIndex = 14;
            this.townHPbar.Tag = "";
            // 
            // townHPBox
            // 
            this.townHPBox.Image = ((System.Drawing.Image)(resources.GetObject("townHPBox.Image")));
            this.townHPBox.InitialImage = null;
            this.townHPBox.Location = new System.Drawing.Point(15, 50);
            this.townHPBox.Name = "townHPBox";
            this.townHPBox.Size = new System.Drawing.Size(15, 15);
            this.townHPBox.TabIndex = 0;
            this.townHPBox.TabStop = false;
            // 
            // logger
            // 
            this.logger.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.logger.ForeColor = System.Drawing.Color.White;
            this.logger.Location = new System.Drawing.Point(8, 8);
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
            this.logger.Size = new System.Drawing.Size(175, 58);
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
            this.tileInfo.Location = new System.Drawing.Point(0, 450);
            this.tileInfo.Name = "tileInfo";
            this.tileInfo.Size = new System.Drawing.Size(250, 150);
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
            // tileImage
            // 
            this.tileImage.Location = new System.Drawing.Point(105, 50);
            this.tileImage.Margin = new System.Windows.Forms.Padding(0);
            this.tileImage.Name = "tileImage";
            this.tileImage.Size = new System.Drawing.Size(25, 25);
            this.tileImage.TabIndex = 1;
            this.tileImage.TabStop = false;
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
            // recruitInfo
            // 
            this.recruitInfo.Controls.Add(this.recruit);
            this.recruitInfo.Controls.Add(this.recUnitTime);
            this.recruitInfo.Controls.Add(this.recUnitName);
            this.recruitInfo.Controls.Add(this.recUnitDMG);
            this.recruitInfo.Controls.Add(this.DMG);
            this.recruitInfo.Controls.Add(this.recUnitHP);
            this.recruitInfo.Controls.Add(this.HP);
            this.recruitInfo.Controls.Add(this.AP);
            this.recruitInfo.Controls.Add(this.recUnitAP);
            this.recruitInfo.Location = new System.Drawing.Point(674, 55);
            this.recruitInfo.Name = "recruitInfo";
            this.recruitInfo.Size = new System.Drawing.Size(190, 171);
            this.recruitInfo.TabIndex = 6;
            this.recruitInfo.Tag = "0; 72";
            this.recruitInfo.Visible = false;
            // 
            // recruit
            // 
            this.recruit.BackColor = System.Drawing.Color.Transparent;
            this.recruit.Font = new System.Drawing.Font("Bookman Old Style", 11.4F);
            this.recruit.Location = new System.Drawing.Point(19, 122);
            this.recruit.Name = "recruit";
            this.recruit.Size = new System.Drawing.Size(162, 30);
            this.recruit.TabIndex = 23;
            this.recruit.Text = "Recruit";
            this.recruit.UseVisualStyleBackColor = false;
            // 
            // recUnitTime
            // 
            this.recUnitTime.AutoSize = true;
            this.recUnitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.recUnitTime.Location = new System.Drawing.Point(19, 100);
            this.recUnitTime.MaximumSize = new System.Drawing.Size(200, 0);
            this.recUnitTime.MinimumSize = new System.Drawing.Size(200, 0);
            this.recUnitTime.Name = "recUnitTime";
            this.recUnitTime.Size = new System.Drawing.Size(200, 12);
            this.recUnitTime.TabIndex = 22;
            this.recUnitTime.Text = "Time: X turns";
            // 
            // recUnitName
            // 
            this.recUnitName.AutoSize = true;
            this.recUnitName.BackColor = System.Drawing.Color.Transparent;
            this.recUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.recUnitName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recUnitName.Location = new System.Drawing.Point(34, 27);
            this.recUnitName.Margin = new System.Windows.Forms.Padding(0);
            this.recUnitName.MinimumSize = new System.Drawing.Size(137, 0);
            this.recUnitName.Name = "recUnitName";
            this.recUnitName.Size = new System.Drawing.Size(137, 12);
            this.recUnitName.TabIndex = 21;
            this.recUnitName.Text = "Unit name";
            this.recUnitName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recUnitDMG
            // 
            this.recUnitDMG.AutoSize = true;
            this.recUnitDMG.BackColor = System.Drawing.Color.Transparent;
            this.recUnitDMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.recUnitDMG.ForeColor = System.Drawing.Color.Transparent;
            this.recUnitDMG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recUnitDMG.Location = new System.Drawing.Point(34, 65);
            this.recUnitDMG.Margin = new System.Windows.Forms.Padding(0);
            this.recUnitDMG.MinimumSize = new System.Drawing.Size(137, 0);
            this.recUnitDMG.Name = "recUnitDMG";
            this.recUnitDMG.Size = new System.Drawing.Size(137, 12);
            this.recUnitDMG.TabIndex = 20;
            this.recUnitDMG.Text = "0";
            this.recUnitDMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DMG
            // 
            this.DMG.Image = ((System.Drawing.Image)(resources.GetObject("DMG.Image")));
            this.DMG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DMG.Location = new System.Drawing.Point(19, 65);
            this.DMG.Name = "DMG";
            this.DMG.Size = new System.Drawing.Size(11, 11);
            this.DMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DMG.TabIndex = 19;
            this.DMG.TabStop = false;
            // 
            // recUnitHP
            // 
            this.recUnitHP.AutoSize = true;
            this.recUnitHP.BackColor = System.Drawing.Color.Transparent;
            this.recUnitHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.recUnitHP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recUnitHP.Location = new System.Drawing.Point(34, 49);
            this.recUnitHP.Margin = new System.Windows.Forms.Padding(0);
            this.recUnitHP.MinimumSize = new System.Drawing.Size(137, 0);
            this.recUnitHP.Name = "recUnitHP";
            this.recUnitHP.Size = new System.Drawing.Size(137, 12);
            this.recUnitHP.TabIndex = 18;
            this.recUnitHP.Text = "0";
            this.recUnitHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HP
            // 
            this.HP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HP.Image = ((System.Drawing.Image)(resources.GetObject("HP.Image")));
            this.HP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HP.Location = new System.Drawing.Point(19, 49);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(11, 11);
            this.HP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HP.TabIndex = 16;
            this.HP.TabStop = false;
            // 
            // AP
            // 
            this.AP.Image = ((System.Drawing.Image)(resources.GetObject("AP.Image")));
            this.AP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AP.Location = new System.Drawing.Point(19, 80);
            this.AP.Margin = new System.Windows.Forms.Padding(0);
            this.AP.Name = "AP";
            this.AP.Size = new System.Drawing.Size(11, 11);
            this.AP.TabIndex = 15;
            this.AP.TabStop = false;
            // 
            // recUnitAP
            // 
            this.recUnitAP.AutoSize = true;
            this.recUnitAP.BackColor = System.Drawing.Color.Transparent;
            this.recUnitAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.recUnitAP.ForeColor = System.Drawing.Color.Black;
            this.recUnitAP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recUnitAP.Location = new System.Drawing.Point(34, 80);
            this.recUnitAP.Margin = new System.Windows.Forms.Padding(0);
            this.recUnitAP.MinimumSize = new System.Drawing.Size(137, 0);
            this.recUnitAP.Name = "recUnitAP";
            this.recUnitAP.Size = new System.Drawing.Size(137, 12);
            this.recUnitAP.TabIndex = 14;
            this.recUnitAP.Text = "0";
            this.recUnitAP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.recruitInfo);
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
            this.townMenu.ResumeLayout(false);
            this.townMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townHPBox)).EndInit();
            this.tileInfo.ResumeLayout(false);
            this.tileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).EndInit();
            this.recruitInfo.ResumeLayout(false);
            this.recruitInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP)).EndInit();
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
        private System.Windows.Forms.Panel townMenu;
        private System.Windows.Forms.Panel recruitArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label townHPdisplay;
        private System.Windows.Forms.ProgressBar townHPbar;
        private System.Windows.Forms.PictureBox townHPBox;
        private System.Windows.Forms.Label townCoords;
        private System.Windows.Forms.Button endTurnButton;
        internal System.Windows.Forms.Panel gameArea;
        internal System.Windows.Forms.Panel infoArea;
        private System.Windows.Forms.Panel recruitInfo;
        private System.Windows.Forms.Button recruit;
        private System.Windows.Forms.Label recUnitTime;
        private System.Windows.Forms.Label recUnitName;
        private System.Windows.Forms.Label recUnitDMG;
        private System.Windows.Forms.PictureBox DMG;
        private System.Windows.Forms.Label recUnitHP;
        private System.Windows.Forms.PictureBox HP;
        private System.Windows.Forms.PictureBox AP;
        private System.Windows.Forms.Label recUnitAP;
    }
}

