using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TBSGame
{
    public static class BarColorSwitch
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero); // 1 = (green); 2 = (red); 3 = (yellow)
        }

        public static void SetBarColor(ref Label label, ref ProgressBar bar)
        {
            label.Text = Convert.ToString(bar.Value);
            if (1 > (float)bar.Value/bar.Maximum) SetState(bar, 1);
            else if (2 / 3 > (float)bar.Value / bar.Maximum) SetState(bar, 3);
            else SetState(bar, 2);
        }
    }
}
