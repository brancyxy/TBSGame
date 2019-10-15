using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.IO.Compression;
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

        public FileInfo SelectedMap { get; private set; }

        FileInfo OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "zip archives(*.zip) | *.zip"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.Dispose();
                return new FileInfo(ofd.FileName);
            }
            ofd.Dispose();
            return null;
        }
        private void mapOpener_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedMap = OpenFile();
                if (SelectedMap == null) throw new Exception();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception) { }

            
        }
    }
}
