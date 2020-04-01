using System;
using System.Drawing;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public enum MainMenuAction
    {
        EXIT,
        START,
        EDITOR
    }
    public partial class MainMenu : Form
    {
        private MainMenuAction _action = new MainMenuAction();

        /// <summary>
        /// Property value of the pressed button
        /// </summary>
        public MainMenuAction Action
        {
            get { return _action; }
            private set
            {
                DialogResult = DialogResult.OK;
                _action = value;
                Close();
            }
        }
        public MainMenu(bool useFullScreen)
        {
            Focus();
            InitializeComponent();
            if (useFullScreen) WindowState = FormWindowState.Maximized;

            Scale(Utils.scale);
            ScaleFont(Utils.scale);
        }
        /// <summary>
        /// Extends the base scale method to scale the font size
        /// </summary>
        public void ScaleFont(SizeF scale)
        {
            lbTitle.Font = new Font(lbTitle.Font.FontFamily, lbTitle.Font.Size * scale.Height);
            lbDisplay.Font = new Font(lbDisplay.Font.FontFamily, lbDisplay.Font.Size * scale.Height);
            btnPlay.Font = new Font(btnPlay.Font.FontFamily, btnPlay.Font.Size * scale.Height);
            btnOptions.Font = new Font(btnOptions.Font.FontFamily, btnOptions.Font.Size * scale.Height);
            btnEditor.Font = new Font(btnEditor.Font.FontFamily, btnEditor.Font.Size * scale.Height);
            btnExit.Font = new Font(btnExit.Font.FontFamily, btnExit.Font.Size * scale.Height);
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
            var opts = new OptionsMenu();
            opts.ShowDialog();
            opts.Dispose();
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
