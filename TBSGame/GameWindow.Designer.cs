using System.Drawing;

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
            this.unitCoords = new System.Windows.Forms.Label();
            this.moveArea = new System.Windows.Forms.Panel();
            this.moveY = new System.Windows.Forms.TextBox();
            this.moveX = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.unitDescDisplay = new System.Windows.Forms.RichTextBox();
            this.unitNameDisplay = new System.Windows.Forms.Label();
            this.unitDMGdisplay = new System.Windows.Forms.Label();
            this.dmgIcon = new System.Windows.Forms.PictureBox();
            this.unitHPdisplay = new System.Windows.Forms.Label();
            this.unitHPbar = new System.Windows.Forms.ProgressBar();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.APIcon = new System.Windows.Forms.PictureBox();
            this.unitAPdisplay = new System.Windows.Forms.Label();
            this.unitAPbar = new System.Windows.Forms.ProgressBar();
            this.PlayerNameDisplay = new System.Windows.Forms.Label();
            this.gameArea = new System.Windows.Forms.Panel();
            this.mapSelector = new System.Windows.Forms.Panel();
            this.p2Label = new System.Windows.Forms.Label();
            this.p2NameBox = new System.Windows.Forms.TextBox();
            this.p1Label = new System.Windows.Forms.Label();
            this.p1NameBox = new System.Windows.Forms.TextBox();
            this.Help = new System.Windows.Forms.Label();
            this.mapOpener = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.infoArea = new System.Windows.Forms.Panel();
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
            this.unitInfo.SuspendLayout();
            this.moveArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).BeginInit();
            this.gameArea.SuspendLayout();
            this.mapSelector.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.infoArea.SuspendLayout();
            this.recruitInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP)).BeginInit();
            this.townMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townHPBox)).BeginInit();
            this.tileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // unitInfo
            // 
            this.unitInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.unitInfo.Controls.Add(this.unitCoords);
            this.unitInfo.Controls.Add(this.moveArea);
            this.unitInfo.Controls.Add(this.unitDescDisplay);
            this.unitInfo.Controls.Add(this.unitNameDisplay);
            this.unitInfo.Controls.Add(this.unitDMGdisplay);
            this.unitInfo.Controls.Add(this.dmgIcon);
            this.unitInfo.Controls.Add(this.unitHPdisplay);
            this.unitInfo.Controls.Add(this.unitHPbar);
            this.unitInfo.Controls.Add(this.lifeIcon);
            this.unitInfo.Controls.Add(this.APIcon);
            this.unitInfo.Controls.Add(this.unitAPdisplay);
            this.unitInfo.Controls.Add(this.unitAPbar);
            resources.ApplyResources(this.unitInfo, "unitInfo");
            this.unitInfo.Name = "unitInfo";
            // 
            // unitCoords
            // 
            resources.ApplyResources(this.unitCoords, "unitCoords");
            this.unitCoords.Name = "unitCoords";
            // 
            // moveArea
            // 
            this.moveArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(65)))), ((int)(((byte)(5)))));
            this.moveArea.Controls.Add(this.moveY);
            this.moveArea.Controls.Add(this.moveX);
            this.moveArea.Controls.Add(this.moveButton);
            resources.ApplyResources(this.moveArea, "moveArea");
            this.moveArea.Name = "moveArea";
            // 
            // moveY
            // 
            resources.ApplyResources(this.moveY, "moveY");
            this.moveY.Name = "moveY";
            // 
            // moveX
            // 
            resources.ApplyResources(this.moveX, "moveX");
            this.moveX.Name = "moveX";
            // 
            // moveButton
            // 
            resources.ApplyResources(this.moveButton, "moveButton");
            this.moveButton.Name = "moveButton";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.Action);
            // 
            // unitDescDisplay
            // 
            this.unitDescDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            this.unitDescDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.unitDescDisplay, "unitDescDisplay");
            this.unitDescDisplay.Name = "unitDescDisplay";
            this.unitDescDisplay.ReadOnly = true;
            // 
            // unitNameDisplay
            // 
            resources.ApplyResources(this.unitNameDisplay, "unitNameDisplay");
            this.unitNameDisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitNameDisplay.ForeColor = System.Drawing.Color.Black;
            this.unitNameDisplay.Name = "unitNameDisplay";
            // 
            // unitDMGdisplay
            // 
            resources.ApplyResources(this.unitDMGdisplay, "unitDMGdisplay");
            this.unitDMGdisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitDMGdisplay.ForeColor = System.Drawing.Color.Transparent;
            this.unitDMGdisplay.Name = "unitDMGdisplay";
            // 
            // dmgIcon
            // 
            resources.ApplyResources(this.dmgIcon, "dmgIcon");
            this.dmgIcon.Name = "dmgIcon";
            this.dmgIcon.TabStop = false;
            // 
            // unitHPdisplay
            // 
            resources.ApplyResources(this.unitHPdisplay, "unitHPdisplay");
            this.unitHPdisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitHPdisplay.Name = "unitHPdisplay";
            // 
            // unitHPbar
            // 
            this.unitHPbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.unitHPbar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.unitHPbar, "unitHPbar");
            this.unitHPbar.MarqueeAnimationSpeed = 0;
            this.unitHPbar.Maximum = 10;
            this.unitHPbar.Name = "unitHPbar";
            this.unitHPbar.Step = 1;
            this.unitHPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.unitHPbar.Tag = "";
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
            // unitAPdisplay
            // 
            resources.ApplyResources(this.unitAPdisplay, "unitAPdisplay");
            this.unitAPdisplay.BackColor = System.Drawing.Color.Transparent;
            this.unitAPdisplay.ForeColor = System.Drawing.Color.Black;
            this.unitAPdisplay.Name = "unitAPdisplay";
            // 
            // unitAPbar
            // 
            this.unitAPbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.unitAPbar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.unitAPbar, "unitAPbar");
            this.unitAPbar.MarqueeAnimationSpeed = 0;
            this.unitAPbar.Maximum = 10;
            this.unitAPbar.Name = "unitAPbar";
            this.unitAPbar.Step = 1;
            this.unitAPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.unitAPbar.Tag = "";
            // 
            // PlayerNameDisplay
            // 
            resources.ApplyResources(this.PlayerNameDisplay, "PlayerNameDisplay");
            this.PlayerNameDisplay.Name = "PlayerNameDisplay";
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameArea.Controls.Add(this.mapSelector);
            resources.ApplyResources(this.gameArea, "gameArea");
            this.gameArea.Name = "gameArea";
            // 
            // mapSelector
            // 
            this.mapSelector.Controls.Add(this.p2Label);
            this.mapSelector.Controls.Add(this.p2NameBox);
            this.mapSelector.Controls.Add(this.p1Label);
            this.mapSelector.Controls.Add(this.p1NameBox);
            this.mapSelector.Controls.Add(this.Help);
            this.mapSelector.Controls.Add(this.mapOpener);
            resources.ApplyResources(this.mapSelector, "mapSelector");
            this.mapSelector.Name = "mapSelector";
            // 
            // p2Label
            // 
            resources.ApplyResources(this.p2Label, "p2Label");
            this.p2Label.Name = "p2Label";
            // 
            // p2NameBox
            // 
            resources.ApplyResources(this.p2NameBox, "p2NameBox");
            this.p2NameBox.Name = "p2NameBox";
            // 
            // p1Label
            // 
            resources.ApplyResources(this.p1Label, "p1Label");
            this.p1Label.Name = "p1Label";
            // 
            // p1NameBox
            // 
            resources.ApplyResources(this.p1NameBox, "p1NameBox");
            this.p1NameBox.Name = "p1NameBox";
            // 
            // Help
            // 
            resources.ApplyResources(this.Help, "Help");
            this.Help.Name = "Help";
            // 
            // mapOpener
            // 
            this.mapOpener.BackColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.mapOpener, "mapOpener");
            this.mapOpener.Name = "mapOpener";
            this.mapOpener.UseVisualStyleBackColor = false;
            this.mapOpener.Click += new System.EventHandler(this.SelectMap);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.topPanel.Controls.Add(this.endTurnButton);
            this.topPanel.Controls.Add(this.PlayerNameDisplay);
            resources.ApplyResources(this.topPanel, "topPanel");
            this.topPanel.Name = "topPanel";
            // 
            // endTurnButton
            // 
            resources.ApplyResources(this.endTurnButton, "endTurnButton");
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.UseVisualStyleBackColor = true;
            // 
            // infoArea
            // 
            this.infoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infoArea.Controls.Add(this.recruitInfo);
            this.infoArea.Controls.Add(this.townMenu);
            this.infoArea.Controls.Add(this.logger);
            this.infoArea.Controls.Add(this.tileInfo);
            this.infoArea.Controls.Add(this.unitInfo);
            resources.ApplyResources(this.infoArea, "infoArea");
            this.infoArea.Name = "infoArea";
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
            resources.ApplyResources(this.recruitInfo, "recruitInfo");
            this.recruitInfo.Name = "recruitInfo";
            // 
            // recruit
            // 
            this.recruit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.recruit, "recruit");
            this.recruit.Name = "recruit";
            this.recruit.UseVisualStyleBackColor = false;
            // 
            // recUnitTime
            // 
            resources.ApplyResources(this.recUnitTime, "recUnitTime");
            this.recUnitTime.Name = "recUnitTime";
            // 
            // recUnitName
            // 
            resources.ApplyResources(this.recUnitName, "recUnitName");
            this.recUnitName.BackColor = System.Drawing.Color.Transparent;
            this.recUnitName.Name = "recUnitName";
            // 
            // recUnitDMG
            // 
            resources.ApplyResources(this.recUnitDMG, "recUnitDMG");
            this.recUnitDMG.BackColor = System.Drawing.Color.Transparent;
            this.recUnitDMG.ForeColor = System.Drawing.Color.Transparent;
            this.recUnitDMG.Name = "recUnitDMG";
            // 
            // DMG
            // 
            resources.ApplyResources(this.DMG, "DMG");
            this.DMG.Name = "DMG";
            this.DMG.TabStop = false;
            // 
            // recUnitHP
            // 
            resources.ApplyResources(this.recUnitHP, "recUnitHP");
            this.recUnitHP.BackColor = System.Drawing.Color.Transparent;
            this.recUnitHP.Name = "recUnitHP";
            // 
            // HP
            // 
            resources.ApplyResources(this.HP, "HP");
            this.HP.Name = "HP";
            this.HP.TabStop = false;
            // 
            // AP
            // 
            resources.ApplyResources(this.AP, "AP");
            this.AP.Name = "AP";
            this.AP.TabStop = false;
            // 
            // recUnitAP
            // 
            resources.ApplyResources(this.recUnitAP, "recUnitAP");
            this.recUnitAP.BackColor = System.Drawing.Color.Transparent;
            this.recUnitAP.ForeColor = System.Drawing.Color.Black;
            this.recUnitAP.Name = "recUnitAP";
            // 
            // townMenu
            // 
            this.townMenu.Controls.Add(this.townCoords);
            this.townMenu.Controls.Add(this.recruitArea);
            this.townMenu.Controls.Add(this.label1);
            this.townMenu.Controls.Add(this.townHPdisplay);
            this.townMenu.Controls.Add(this.townHPbar);
            this.townMenu.Controls.Add(this.townHPBox);
            resources.ApplyResources(this.townMenu, "townMenu");
            this.townMenu.Name = "townMenu";
            // 
            // townCoords
            // 
            resources.ApplyResources(this.townCoords, "townCoords");
            this.townCoords.Name = "townCoords";
            // 
            // recruitArea
            // 
            this.recruitArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            resources.ApplyResources(this.recruitArea, "recruitArea");
            this.recruitArea.Name = "recruitArea";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // townHPdisplay
            // 
            resources.ApplyResources(this.townHPdisplay, "townHPdisplay");
            this.townHPdisplay.BackColor = System.Drawing.Color.Transparent;
            this.townHPdisplay.Name = "townHPdisplay";
            // 
            // townHPbar
            // 
            this.townHPbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(123)))), ((int)(((byte)(11)))));
            this.townHPbar.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.townHPbar, "townHPbar");
            this.townHPbar.MarqueeAnimationSpeed = 0;
            this.townHPbar.Maximum = 10;
            this.townHPbar.Name = "townHPbar";
            this.townHPbar.Step = 1;
            this.townHPbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.townHPbar.Tag = "";
            // 
            // townHPBox
            // 
            resources.ApplyResources(this.townHPBox, "townHPBox");
            this.townHPBox.Name = "townHPBox";
            this.townHPBox.TabStop = false;
            // 
            // logger
            // 
            this.logger.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(64)))), ((int)(((byte)(5)))));
            this.logger.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logger.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.logger, "logger");
            this.logger.Name = "logger";
            this.logger.ReadOnly = true;
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
            resources.ApplyResources(this.tileInfo, "tileInfo");
            this.tileInfo.Name = "tileInfo";
            // 
            // tileCoords
            // 
            resources.ApplyResources(this.tileCoords, "tileCoords");
            this.tileCoords.Name = "tileCoords";
            // 
            // tileDEFrate
            // 
            resources.ApplyResources(this.tileDEFrate, "tileDEFrate");
            this.tileDEFrate.Name = "tileDEFrate";
            // 
            // tileAPrate
            // 
            resources.ApplyResources(this.tileAPrate, "tileAPrate");
            this.tileAPrate.Name = "tileAPrate";
            // 
            // DEFrate
            // 
            resources.ApplyResources(this.DEFrate, "DEFrate");
            this.DEFrate.Name = "DEFrate";
            // 
            // APrate
            // 
            resources.ApplyResources(this.APrate, "APrate");
            this.APrate.Name = "APrate";
            // 
            // tileImage
            // 
            resources.ApplyResources(this.tileImage, "tileImage");
            this.tileImage.Name = "tileImage";
            this.tileImage.TabStop = false;
            // 
            // tileName
            // 
            resources.ApplyResources(this.tileName, "tileName");
            this.tileName.Name = "tileName";
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.unitInfo.ResumeLayout(false);
            this.unitInfo.PerformLayout();
            this.moveArea.ResumeLayout(false);
            this.moveArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APIcon)).EndInit();
            this.gameArea.ResumeLayout(false);
            this.mapSelector.ResumeLayout(false);
            this.mapSelector.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.infoArea.ResumeLayout(false);
            this.recruitInfo.ResumeLayout(false);
            this.recruitInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AP)).EndInit();
            this.townMenu.ResumeLayout(false);
            this.townMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.townHPBox)).EndInit();
            this.tileInfo.ResumeLayout(false);
            this.tileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel unitInfo;
        private System.Windows.Forms.ProgressBar unitAPbar;
        private System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Label unitAPdisplay;
        private System.Windows.Forms.PictureBox APIcon;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox lifeIcon;
        private System.Windows.Forms.Label unitHPdisplay;
        private System.Windows.Forms.ProgressBar unitHPbar;
        private System.Windows.Forms.Label unitNameDisplay;
        private System.Windows.Forms.Label unitDMGdisplay;
        private System.Windows.Forms.PictureBox dmgIcon;
        private System.Windows.Forms.Panel tileInfo;
        private System.Windows.Forms.Label DEFrate;
        private System.Windows.Forms.Label APrate;
        private System.Windows.Forms.PictureBox tileImage;
        private System.Windows.Forms.Label tileName;
        private System.Windows.Forms.Panel mapSelector;
        private System.Windows.Forms.Button mapOpener;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.TextBox p1NameBox;
        private System.Windows.Forms.Label p2Label;
        private System.Windows.Forms.TextBox p2NameBox;
        private System.Windows.Forms.Label p1Label;
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
        private System.Windows.Forms.RichTextBox unitDescDisplay;
        private System.Windows.Forms.Panel moveArea;
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
        private System.Windows.Forms.TextBox moveY;
        private System.Windows.Forms.TextBox moveX;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label unitCoords;
    }
}

