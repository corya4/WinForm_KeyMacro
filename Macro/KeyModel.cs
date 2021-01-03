using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Macro
{
    
    class KeyModel
    {
        /*
        None = 0,
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8
        */

        public List<CMacro> macros;

        public KeyModel()
        {
            macros = new List<CMacro>();
        }

        public void Input(CMacro m)
        {
            macros.Add(m);
        }

        public void OnMacro(Keys Onkey, int modified)
        {

            foreach(CMacro c in macros)
            {
                if(c.regist == Onkey)
                {
                    c.OnKey();
                    break;
                }

            }
            

        }

    }
}
