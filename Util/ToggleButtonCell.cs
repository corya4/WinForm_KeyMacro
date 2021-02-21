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

        /*
         * toggle이 false시에만 이벤트활성화.
         * toggle이 true시에는 눌린 grahpic에서 다시 원형태로 drow함.
         */
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (toggle) return;

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts);
        }

       protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
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
    }
}
