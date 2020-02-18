using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBSGame.Menus
{
    public partial class OptionsMenu : Form
    {
        public OptionsMenu()
        {
            InitializeComponent();

            cbFullscreen.Checked = bool.Parse(Utils.settings["UI"]["fullscreen"]);

            FillCb();


        }


        /// <summary>
        /// Fills the combobox with resolution values ranging to depending on the screen size
        /// </summary>
        private void FillCb()
        {
            byte scaleDouble = 2;

            while (Fits(scaleDouble))
            {
                cbResolution.Items.Add($"{Utils.BASE_WIDTH * scaleDouble / 2.0f}x"+
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
                if(resX.ToString() == tmp[0] &&
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
                     Utils.BASE_WIDTH* scaleDouble / 2.0f > Screen.PrimaryScreen.Bounds.Width);
        }

        /// <summary>
        /// Makes the window unmovable
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
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
