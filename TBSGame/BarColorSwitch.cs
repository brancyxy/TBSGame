using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

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

        public static void SetBarColor(ref ProgressBar bar)
        {
            var v = bar.Value;
            var m = bar.Maximum;
            if ((double)v/m>(double)2/3) SetState(bar, 1);
            else if ((double)v/m>(double)1/3) SetState(bar, 3);
            else SetState(bar, 2);
        }
    }
}
