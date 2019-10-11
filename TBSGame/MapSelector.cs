using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame
{
    public partial class MapSelector : Form
    {
        public MapSelector()
        {
            InitializeComponent();
        }

        FileInfo OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "|map.YFY|zip archives(*.zip) | *.zip"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofd.FileName);

                this.WindowState = FormWindowState.Minimized;
                return file;
            }
            return null;
        } // remove .YFY after zip
        private void mapOpener_Click(object sender, EventArgs e)
        {
            try
            {
                var file = OpenFile();
                if (file == null) throw new Exception();


                string[] pName = new string[2];
                pName[0] = (p1NameBox.Text != "") ? p1NameBox.Text : "Player 1";
                pName[1] = (p2NameBox.Text != "") ? p2NameBox.Text : "Player 2";


                var tmp = new GameWindow(file, pName);
            }
            catch(Exception) { }

            
        }
    }
}
