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
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.infoArea = new System.Windows.Forms.Panel();
            this.logger = new System.Windows.Forms.RichTextBox();
            this.gameAreaBorder = new System.Windows.Forms.Panel();
            this.Quit = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.infoArea.SuspendLayout();
            this.gameAreaBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerNameDisplay
            // 
            this.PlayerNameDisplay.AutoSize = true;
            this.PlayerNameDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PlayerNameDisplay.Location = new System.Drawing.Point(100, 12);
            this.PlayerNameDisplay.Name = "PlayerNameDisplay";
            this.PlayerNameDisplay.Size = new System.Drawing.Size(0, 13);
            this.PlayerNameDisplay.TabIndex = 0;
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameArea.Location = new System.Drawing.Point(0, 0);
            this.gameArea.Margin = new System.Windows.Forms.Padding(0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(300, 300);
            this.gameArea.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.topPanel.Controls.Add(this.Quit);
            this.topPanel.Controls.Add(this.btnEndTurn);
            this.topPanel.Controls.Add(this.PlayerNameDisplay);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(300, 42);
            this.topPanel.TabIndex = 5;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopField_MouseUp);
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.btnEndTurn.Location = new System.Drawing.Point(220, 8);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(57, 24);
            this.btnEndTurn.TabIndex = 1;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.NextPlayer);
            // 
            // infoArea
            // 
            this.infoArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            // gameAreaBorder
            // 
            this.gameAreaBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gameAreaBorder.Controls.Add(this.gameArea);
            this.gameAreaBorder.Location = new System.Drawing.Point(0, 42);
            this.gameAreaBorder.Margin = new System.Windows.Forms.Padding(0);
            this.gameAreaBorder.Name = "gameAreaBorder";
            this.gameAreaBorder.Size = new System.Drawing.Size(300, 300);
            this.gameAreaBorder.TabIndex = 5;
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.27F);
            this.Quit.Location = new System.Drawing.Point(12, 8);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(57, 24);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(608, 342);
            this.Controls.Add(this.gameAreaBorder);
            this.Controls.Add(this.infoArea);
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
            this.gameAreaBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.RichTextBox logger;
        private System.Windows.Forms.Button btnEndTurn;
        internal System.Windows.Forms.Panel infoArea;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.Panel gameAreaBorder;
        public System.Windows.Forms.Label PlayerNameDisplay;
        private System.Windows.Forms.Button Quit;
    }
}

