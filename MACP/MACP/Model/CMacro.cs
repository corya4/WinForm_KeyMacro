using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MACP.Macro
{
    
    class CMacro
    {
        const int DOWN = 0x00;
        const int UP = 0x02;
        const int ALT = 18;
        const int CTRL = 17;
        const int SHIFT = 16;

        public String title;                    // MacroName

        public struct Regist
        {
            public Keys Key { get; set; }
            public int modified { get; set; }
        }

        Regist regist;                          // Macro 발생 키
        public List<Keys> keys;                 // Macro 입력 키List
        public List<int> modifieds;             // 보조입력 키List
        private int index;                      // List Index접근변수         

        public CMacro(String title)
        {
            this.title = title;
            regist = new Regist();
            keys = new List<Keys>();
            modifieds = new List<int>();
        }

        public void OnKey()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                index = i;
                Console.WriteLine(index);
                KeyDown();
                KeyUp();
               
            }
        }

        private void KeyDown()
        {
            WinLib.keybd_event(Convert.ToByte(keys[index]), 0, DOWN, 0);
        }

        private void KeyUp()
        {

            WinLib.keybd_event(Convert.ToByte(keys[index]), 0, UP, 0);

        }
        
    }
}
