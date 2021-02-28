using MACP.Macro;
using MACP.Util;
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

        static int i = 0;
        static public void AddMacro(object data)
        {
            CMacro macro = data as CMacro;
            ToggleButtonCell btnCell = new ToggleButtonCell();

            viewer.Rows.Add();
            btnCell.Value = macro.m_title;
            viewer.Rows[i++].Cells[0] = btnCell; 
        }
        

    }
}
