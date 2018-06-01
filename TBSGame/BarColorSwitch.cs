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
    }
}
