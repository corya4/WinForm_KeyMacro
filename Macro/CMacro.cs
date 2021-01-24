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
        public int type;
        public Keys regist;
        public List<Keys> keys;
        public List<int> shifts;
        public List<int> ctrls;

        public CMacro(String title)
        {
            m_title = title;
            keys = new List<Keys>();
            shifts = new List<int>();
            ctrls = new List<int>();
        }

        public void OnKey()
        {
            


        }


    }
}
