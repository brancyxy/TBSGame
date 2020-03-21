using IniParser;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public partial class OptionsMenu : Form
    {
        const string RESET_TEXT = "This will reset the options to the base values. Proceed?",
                     CHANGE_TEXT = "The settings will change, a restart is required. Proceed?",
                     BOX_TITLE = "Change Settings";
        public OptionsMenu()
        {
            InitializeComponent();
            cbFullscreen.Checked = bool.Parse(Utils.settings["UI"]["fullscreen"]);
            FillCb();

            Scale(Utils.scale);

            ScaleFontSize(Utils.scale.Height);
        }
        /// <summary>
        /// Scales the fonts of the texts
        /// </summary>
        /// <param name="height">It scales based on the height scale</param>
        private void ScaleFontSize(float height)
        {
            lbRes.Font = new Font(lbRes.Font.FontFamily, lbRes.Font.Size * height);
            cbFullscreen.Font = new Font(cbFullscreen.Font.FontFamily, cbFullscreen.Font.Size * height);
            btnCancel.Font = new Font(btnCancel.Font.FontFamily, btnCancel.Font.Size * height);
            btnDefault.Font = new Font(btnDefault.Font.FontFamily, btnDefault.Font.Size * height);
            btnOk.Font = new Font(btnOk.Font.FontFamily, btnOk.Font.Size * height);
            cbResolution.Font = new Font(cbResolution.Font.FontFamily, cbResolution.Font.Size * height);
        }

        /// <summary>
        /// Fills the combobox with resolution values ranging to depending on the screen size
        /// </summary>
        private void FillCb()
        {
            byte scaleDouble = 2;

            while (Fits(scaleDouble))
            {
                cbResolution.Items.Add($"{Utils.BASE_WIDTH * scaleDouble / 2.0f}x" +
                                       $"{Utils.BASE_HEIGHT * scaleDouble / 2.0f}");
                scaleDouble++;
            }

            Highlight();
        }

        /// <summary>
        /// Highlights the selected resolution for the combobox. If set to custom, adds a "Custom" option.
        /// </summary>
        private void Highlight()
        {
            bool found = false;
            int resX = int.Parse(Utils.settings["UI"]["res-x"]);
            int resY = int.Parse(Utils.settings["UI"]["res-y"]);
            foreach (var res in cbResolution.Items)
            {
                var tmp = res.ToString().Split('x');
                if (resX.ToString() == tmp[0] &&
                   resY.ToString() == tmp[1])
                {
                    found = true;
                    cbResolution.SelectedItem = res;
                }
            }

            if (!found)
            {
                cbResolution.Items.Add($"Custom ({resX}x{resY})");
                cbResolution.SelectedIndex = cbResolution.Items.Count - 1;
            }
        }

        /// <summary>
        /// Determines whether the screen resolution can fit the new resolution value
        /// </summary>
        /// <param name="scaleDouble">Check is done by half units</param>
        /// <returns>A boolean value whether it's true or not</returns>
        private bool Fits(byte scaleDouble)
        {
            return !(Utils.BASE_HEIGHT * scaleDouble / 2.0f > Screen.PrimaryScreen.Bounds.Height ||
                     Utils.BASE_WIDTH * scaleDouble / 2.0f > Screen.PrimaryScreen.Bounds.Width);
        }

        /// <summary>
        /// Makes the window immovable
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            if (m.Msg == WM_SYSCOMMAND)
            {
                if ((m.WParam.ToInt32() & 0xfff0) == SC_MOVE)
                    return;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Enables and disables the combobox depending on the fullscreen checkbox value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchComboBox(object sender, EventArgs e)
        {
            cbResolution.Enabled = !((CheckBox)sender).Checked;
        }

        /// <summary>
        /// Saves the settings and restarts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save(object sender, EventArgs e)
        {
            if (MessageBox.Show(CHANGE_TEXT, BOX_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Utils.settings["UI"]["fullscreen"] = cbFullscreen.Checked.ToString();
                if (!cbResolution.SelectedItem.ToString().StartsWith("Custom"))
                {
                    var tmp = cbResolution.SelectedItem.ToString().Split('x');
                    Utils.settings["UI"]["res-x"] = tmp[0];
                    Utils.settings["UI"]["res-y"] = tmp[1];
                }

                new FileIniDataParser().WriteFile(Utils.SETTINGS_FILE, Utils.settings, Encoding.UTF8);

                Application.Restart();
            }
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Resets the settings and restarts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            if (MessageBox.Show(RESET_TEXT, BOX_TITLE, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Utils.settings["UI"]["fullscreen"] = "False";
                Utils.settings["UI"]["res-x"] = Utils.BASE_WIDTH.ToString();
                Utils.settings["UI"]["res-y"] = Utils.BASE_HEIGHT.ToString();

                new FileIniDataParser().WriteFile(Utils.SETTINGS_FILE, Utils.settings, Encoding.UTF8);

                Application.Restart();
            }
        }
    }
}
