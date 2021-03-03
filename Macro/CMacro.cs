using MACP.Model;
using MACP.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Macro
{
    
    class CMacro
    {
        public String m_title;
        public AddKey regist;
        public int modified;
        public List<Keys> keys;
        public List<int> shifts;
        public List<int> ctrls;
        public List<int> alts;

        const int DOWN =  0x00;
        const int UP = 0x02;
        const int ALT = 18;
        const int CTRL = 17;
        const int SHIFT = 16;

        int index;

        public CMacro(String title)
        {
            m_title = title;
            regist = new AddKey();
            keys = new List<Keys>();
            shifts = new List<int>();
            ctrls = new List<int>();
            alts = new List<int>();
        }

        public void OnKey()
        {
            for(int i = 0; i < keys.Count; i++)
            {
                index = i;

                KeyDown();
                KeyUp();
            }

        }

        private void KeyDown()
        {
            WinLib.EXEC = false;

            if (alts[index] == 1) WinLib.keybd_event(Convert.ToByte(ALT), 0, DOWN, 0);
            if (ctrls[index] == 1) WinLib.keybd_event(Convert.ToByte(CTRL), 0, DOWN, 0);
            if (shifts[index] == 1) WinLib.keybd_event(Convert.ToByte(SHIFT), 0, DOWN, 0);
            WinLib.keybd_event(Convert.ToByte(keys[index]), 0, DOWN, 0);
        }

        private void KeyUp()
        {
            WinLib.keybd_event(Convert.ToByte(keys[index]), 0, UP, 0);
            if (shifts[index] == 1) WinLib.keybd_event(Convert.ToByte(SHIFT), 0, UP, 0);
            if (ctrls[index] == 1) WinLib.keybd_event(Convert.ToByte(CTRL), 0, UP, 0);
            if (alts[index] == 1) WinLib.keybd_event(Convert.ToByte(ALT), 0, UP, 0);

            WinLib.EXEC = true;
        }
        
    }
}
