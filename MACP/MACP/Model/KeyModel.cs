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
        public List<CMacro> macros;

        public KeyModel()
        {
            macros = new List<CMacro>();
        }

        public void Input(CMacro m)
        {
            macros.Add(m);
        }

        public void OnMacro(int index)
        {
            macros[index].OnKey();
        }

    }
}
