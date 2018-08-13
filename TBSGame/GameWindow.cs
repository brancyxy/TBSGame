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
    public partial class GameWindow : Form
    {

        Map map;

        public GameWindow()
        {
            InitializeComponent();
            
        }

        private void SelectMap(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MAP|map.YFY";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofd.FileName);

                map = new Map(File.ReadMap(file.FullName), file.DirectoryName);

                {
                    mapSelector.Dispose();
                    mapSelector.SendToBack();
                    mapSelector.Visible = false;
                }  //map selector removal 
            }
        }
    }
}
