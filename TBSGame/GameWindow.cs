using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }




        /* APdisplay.Text = Convert.ToString(APbar.Value);
         if (APbar.Value > 8) BarColorSwitch.SetState(APbar, 1);
         else if (APbar.Value > 4) BarColorSwitch.SetState(APbar, 3);
         else BarColorSwitch.SetState(APbar, 2);*/



    }
}
