using MACP.Macro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Controll
{
    static class AMD
    {
        static public DataGridView viewer;

        static public void AddMacro(object data)
        {
            CMacro macro = data as CMacro;
            viewer.Rows.Add(macro.m_title);
        }
        

    }
}
