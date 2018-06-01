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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string p1Name = p1NameIn.Text;
            string p2Name = p2NameIn.Text;

            GameWindow game =new GameWindow((p1Name == "")?"Player 1":p1Name, (p2Name == "") ? "Player 2" : p2Name);
            Hide();
            game.Show();
            Close();
        }
    }
}
