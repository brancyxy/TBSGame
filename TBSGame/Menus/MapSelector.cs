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

        public MapSelector(bool useFullScreen)
        {
            InitializeComponent();
            Filldgv();
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
            selectMap.Font = new Font(selectMap.Font.FontFamily, selectMap.Font.Size * scale.Height);
            rtbMapDebugLog.Font = new Font(rtbMapDebugLog.Font.FontFamily, rtbMapDebugLog.Font.Size * scale.Height);
            dgvMapSelector.ColumnHeadersDefaultCellStyle.Font = new Font(dgvMapSelector.ColumnHeadersDefaultCellStyle.Font.FontFamily,
                                                                         dgvMapSelector.ColumnHeadersDefaultCellStyle.Font.Size * scale.Width);
            dgvMapSelector.DefaultCellStyle.Font = new Font(dgvMapSelector.DefaultCellStyle.Font.FontFamily,
                                                            dgvMapSelector.DefaultCellStyle.Font.Size * scale.Width);
        }
        /// <summary>
        /// Fills the DataGridView of the map selector. Map file names must have a set format
        /// </summary>
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
                                    ? rtbMapDebugLog.Text += $"Successfully loaded {dgvMapSelector.RowCount} map{((dgvMapSelector.RowCount > 1) ? "s" : "")}!"
                                    : rtbMapDebugLog.Text += $"No maps found") + Environment.NewLine;
        }
        /// <summary>
        /// Removes the brackets from the player count number
        /// </summary>
        /// <param name="v">The part of the processed string that contains the player count</param>
        /// <returns></returns>
        private string RemoveParentheses(string v)
        {
            return v.TrimStart('(', '[', '{')
                    .TrimEnd(')', ']', '}');
        }
        /// <summary>
        /// Helps determining the data of the map file name format. Removes the creator of the map from the processed string
        /// </summary>
        /// <param name="tmp">The name of the file split with space</param>
        /// <returns>Returns a temporary value for further processing</returns>
        private string[] RemoveCreatorNameFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(tmpL.Count - 1);
            return tmpL.ToArray();
        }
        /// <summary>
        /// Helps determining the data of the map file name format. Removes the player count from the processed string
        /// </summary>
        /// <param name="tmp">The name of the file split with space</param>
        /// <returns>Returns a temporary value for further processing</returns>
        private string[] RemovePlayerCountFromMapFileName(string[] tmp)
        {
            var tmpL = tmp.ToList();
            tmpL.RemoveAt(0);

            return tmpL.ToArray();
        }

        /// <summary>
        /// Runs whenever the user selects a map from the list
        /// </summary>
        private void SelectFromList(object sender, EventArgs e)
        {
            SelectedMapFileName = dgvMapSelector[3, dgvMapSelector.SelectedRows[0].Index]
                                                    .Value
                                                    .ToString();
        }

        /// <summary>
        /// Runs when the select button is clicked
        /// </summary>
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
