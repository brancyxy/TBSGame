using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public enum MainMenuAction
    {
        START,
        EDITOR,
        EXIT
    }
    public partial class MainMenu : Form
    {
        private MainMenuAction _action;

        /// <summary>
        /// Property value of the pressed button
        /// </summary>
        public MainMenuAction Action { 
            get { return _action; }
            private set
            {
                DialogResult = DialogResult.OK;
                _action = value;
                Close();
            }
        }
        public MainMenu(SizeF scale, bool useFullScreen)
        {
            InitializeComponent();
            if (useFullScreen) WindowState = FormWindowState.Maximized;
            Scale(scale);
            ScaleFontSize(scale.Height);
        }
        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            lbTitle.Font = new Font(lbTitle.Font.FontFamily, lbTitle.Font.Size * height);
            lbDisplay.Font = new Font(lbDisplay.Font.FontFamily, lbDisplay.Font.Size * height);
            btnPlay.Font = new Font(btnPlay.Font.FontFamily, btnPlay.Font.Size * height);
            btnOptions.Font = new Font(btnOptions.Font.FontFamily, btnOptions.Font.Size * height);
            btnEditor.Font = new Font(btnEditor.Font.FontFamily, btnEditor.Font.Size * height);
            btnExit.Font = new Font(btnExit.Font.FontFamily, btnExit.Font.Size * height);
        }

        //make the top area move the window if in window mode
        private bool mouseDown;
        private Point lastLocation;
        private void TopField_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void TopField_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && WindowState != FormWindowState.Maximized)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, 
                    (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }
        private void TopField_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //_______________________________________________________________
        private void Exit(object sender, EventArgs e)
        {
            Action = MainMenuAction.EXIT;
        }
        private void Options(object sender, EventArgs e)
        {
            new OptionsMenu().ShowDialog();
        }
        private void Editor(object sender, EventArgs e)
        {
            Action = MainMenuAction.EDITOR;
        }
        private void Play(object sender, EventArgs e)
        {
            Action = MainMenuAction.START;
        }
    }
}
