using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public partial class MapSelector : Form
    {
        public string SelectedMapFileName { get; private set; }

        public MapSelector(SizeF scale, bool useFullScreen)
        {
            InitializeComponent();
            Filldgv();
            if (useFullScreen) WindowState = FormWindowState.Maximized;
            Scale(scale);
            ScaleFontSize(scale.Height);
        }

        private void ScaleFontSize(float height)
        {
            lbTitle.Font = new Font(lbTitle.Font.FontFamily, lbTitle.Font.Size * height);
            selectMap.Font = new Font(selectMap.Font.FontFamily, selectMap.Font.Size * height);
            rtbMapDebugLog.Font = new Font(rtbMapDebugLog.Font.FontFamily, rtbMapDebugLog.Font.Size * height);
            dgvMapSelector.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMapSelector.ColumnHeadersDefaultCellStyle.Font.FontFamily,
                                                                         dgvMapSelector.ColumnHeadersDefaultCellStyle.Font.Size * height);
            dgvMapSelector.DefaultCellStyle.Font = new Font(dgvMapSelector.DefaultCellStyle.Font.FontFamily, 
                                                            dgvMapSelector.DefaultCellStyle.Font.Size * height);
        }

        private void Filldgv()
        {
            var maps = Directory
                        .EnumerateFiles(Utils.MAP_FOLDER, "*.zip")
                        .Select(Path.GetFileNameWithoutExtension)
                        .ToArray();

            foreach (var m in maps)
            {
                try
                {
                    var tmp = m.Split(' ');

                    int playerCount = int.Parse(RemoveParentheses(tmp[0]));
                    tmp = RemovePlayerCountFromMapFileName(tmp);

                    tmp = string.Join(" ", tmp)
                                .Split('-');
                    string creatorName = tmp[tmp.Length - 1];
                    tmp = RemoveCreatorNameFromMapFileName(tmp);


                    string name = string.Join("-", tmp);
                    dgvMapSelector.Rows.Add(playerCount, name, creatorName, m + ".zip");
                }
                catch (Exception ex)
                {
                    rtbMapDebugLog.Text += $"Error at map file {m}, error description: {ex}" + Environment.NewLine;
                }
            }
            rtbMapDebugLog.Text += ((dgvMapSelector.RowCount > 0)
                                    ? rtbMapDebugLog.Text += $"Successfully loaded {dgvMapSelector.RowCount} maps!"
                                    : rtbMapDebugLog.Text += $"No maps found") + Environment.NewLine;
        }

        private string RemoveParentheses(string v)
        {
            return v.TrimStart('(', '[', '{')
                    .TrimEnd(')', ']', '}');
        }
        private string[] RemoveCreatorNameFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(tmpL.Count - 1);

            return tmpL.ToArray();
        }
        private string[] RemovePlayerCountFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(0);

            return tmpL.ToArray();
        }

        private void SelectFromList(object sender, EventArgs e)
        {
            SelectedMapFileName = dgvMapSelector[3, dgvMapSelector.SelectedRows[0].Index]
                                                    .Value
                                                    .ToString();
        }

        private void Select(object sender, EventArgs e)
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
    }
}
