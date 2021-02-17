using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Util
{
    class ToggleButtonCell : DataGridViewButtonCell
    {
        public bool toggle;


        protected override void OnMouseDown(DataGridViewCellMouseEventArgs e)
        {
            if (!toggle)
            {
                toggle = true;
            }
            else
            {
                base.OnMouseUp(e);
                toggle = false;
            }
        }

       protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
        {
            if (!toggle)
            {
                toggle = true;
            }
            else
            {
                base.OnMouseDown(e);
                toggle = false;
            }

        }
    }
}
