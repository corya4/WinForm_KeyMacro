using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace MACP
{
    public class WinLib
    {
        #region FlndWindow
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern int UnregisterHotKey(int hwnd, int id);

        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(int wCode, int wMapType);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        #endregion

        public static Form form { get; set; }
        public bool EXEC = true;

        public static int GetPrivateProfileInteger(String section, String key, String filePath)
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, retVal.Capacity, filePath);

            return Convert.ToInt32(retVal.ToString());
        }

        public static String GetPrivateProfileString(String section, String key, String filePath)
        {
            StringBuilder retVal = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", retVal, retVal.Capacity, filePath);

            return retVal.ToString();
        }

        public static KeyValuePair<Keys, int> InputKey(Message m)
        {
            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
            int modified = (int)m.LParam & 0xFFFF;
            KeyValuePair<Keys, int> keys = new KeyValuePair<Keys, int>(key, modified);

            return keys;
        }

    }
}
