using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Util
{
    class ToggleButtonDataGridView : DataGridViewButtonCell
    {
        public
            List<bool> toggleList;

        ToggleButtonDataGridView(){
            
        }

        protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;

            if (toggleList[index])
            {
                toggleList[index] = false;
            }
            else
            {
                toggleList[index] = true;
                base.OnMouseUp(e);
            }

        }
    }
}
