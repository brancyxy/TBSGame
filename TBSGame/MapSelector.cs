using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace TBSGame
{
    public partial class MapSelector : Form
    {
        const string MAP_FOLDER = @"Maps\";
        public string SelectedMapFileName {get; private set;}

        public MapSelector()
        {
            InitializeComponent();
            Filldgv();
        }

        private void Filldgv()
        {
            var maps = Directory
                        .EnumerateFiles(MAP_FOLDER, "*.zip")
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToArray();

            foreach (var m in maps)
            {
                try
                {
                    var tmp = m.Split(' ');

                    int playerCount = int.Parse(removeParentheses(tmp[0]));
                    tmp = RemovePlayerCountFromMapFileName(tmp);

                    tmp = string.Join(" ", tmp)
                                .Split('-');
                    string creatorName = tmp[tmp.Length-1];
                    tmp = RemoveCreatorNameFromMapFileName(tmp);


                    string name = string.Join("-", tmp);
                    dgvMapSelector.Rows.Add(playerCount, name, creatorName, m + ".zip");
                }
                catch(Exception ex)
                {
                    rtbMapDebugLog.Text += $"Error at map file {m}, error description: {ex}" + Environment.NewLine;
                }
            }
            rtbMapDebugLog.Text += ((dgvMapSelector.RowCount > 0)
                                    ? rtbMapDebugLog.Text += $"Successfully loaded {dgvMapSelector.RowCount} maps!"
                                    : rtbMapDebugLog.Text += $"No maps found") + Environment.NewLine;
        }

        private string removeParentheses(string v)
        {
            return v.TrimStart('(', '[', '{')
                    .TrimEnd(')', ']', '}');
        }
        private string[] RemoveCreatorNameFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(tmpL.Count-1);

            return tmpL.ToArray();
        }
        private string[] RemovePlayerCountFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(0);

            return tmpL.ToArray();
        }

        private void dgvMapSelector_SelectionChanged(object sender, EventArgs e)
        {
            SelectedMapFileName = dgvMapSelector[3, dgvMapSelector.SelectedRows[0].Index]
                                                    .Value
                                                    .ToString();
        }

        private void selectMap_Click(object sender, EventArgs e)
        {
            if (SelectedMapFileName != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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
            if (mouseDown && this.WindowState != FormWindowState.Maximized)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void TopField_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
