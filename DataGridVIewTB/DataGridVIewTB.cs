using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DataGridVIewTB
{
    public partial class DataGridVIewTB : DataGridView
    {

        public DataGridVIewTB()
        {
            InitializeComponent();
        }
       
        public void SetToggleButton(int row, int col)
        {
            SetToggleButton("", row, col);
        }

        public void SetToggleButton(String strTxt, int n, int m)
        {
            ToggleButtonCell cell = new ToggleButtonCell();
            cell.Value = strTxt;

            if (this.Rows.Count < n) this.Rows.Add();
            this.Rows[n].Cells[m] = cell;
        }

        public void OnToggle(int row, int col)
        {
            this.OnCellMouseUp(new DataGridViewCellMouseEventArgs(row, col, 0, 0, null));
        }

        public int Clicked(int n, int m) 
        {
            if (!(this.Rows[n].Cells[m] is ToggleButtonCell)) return -1;
            return (this.Rows[n].Cells[m] as ToggleButtonCell).OnToggle ? 1 : 0;
        }
        
        private class ToggleButtonCell : DataGridViewButtonCell
        {
            public bool OnToggle { get; set; }

            protected override void OnMouseUp(DataGridViewCellMouseEventArgs e)
            {
                if (!OnToggle) OnToggle = true;
                else
                {
                    base.OnMouseUp(e);
                    OnToggle = false;
                }
            }

            protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
            {
                if (OnToggle) return;
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
        }


    }

   

}
