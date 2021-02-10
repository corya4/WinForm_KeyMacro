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

        public CMacro(String title)
        {
            m_title = title;
            regist = new AddKey();
            keys = new List<Keys>();
            shifts = new List<int>();
            ctrls = new List<int>();
        }

        public void OnKey()
        {
            for(int i = 0; i < keys.Count; i++)
            {
                /*
                 * keys리스트의 키를 입력함.
                 */
            }

        }


    }
}
