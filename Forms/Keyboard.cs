using MACP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Forms
{
    public partial class Keyboard : Form
    {
        List<AddKey> lKey;
        bool mulSel;

        public Keyboard(object list, Point location, bool mulSel)
        {
            InitializeComponent();
            lKey = list as List<AddKey>;
            this.mulSel = mulSel;

            this.Location = location;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = keyData.Rows;
            rows.Add("1",false,false,Keys.NumPad1); rows.Add("2",false,false,Keys.NumPad2); rows.Add("3",false,false,Keys.NumPad3); rows.Add("4",false,false,Keys.NumPad4); rows.Add("5",false,false,Keys.NumPad5); rows.Add("6",false,false,Keys.NumPad6); rows.Add("7",false,false,Keys.NumPad7); rows.Add("8",false,false,Keys.NumPad8); rows.Add("9",false,false,Keys.NumPad9); rows.Add("0",false,false,Keys.NumPad0);
            rows.Add("F1",false,false,Keys.F1); rows.Add("F2",false,false,Keys.F2); rows.Add("F3",false,false,Keys.F3); rows.Add("F4",false,false,Keys.F4); rows.Add("F5",false,false,Keys.F5); rows.Add("F6",false,false,Keys.F6);
            rows.Add("F7",false,false,Keys.F7); rows.Add("F8",false,false,Keys.F8); rows.Add("F9",false,false,Keys.F9); rows.Add("F10",false,false,Keys.F10); rows.Add("F11",false,false,Keys.F11); rows.Add("F12",false,false,Keys.F12);

            rows.Add("A",false,false,Keys.A); rows.Add("B",false,false,Keys.B); rows.Add("C",false,false,Keys.C); rows.Add("D",false,false,Keys.D); rows.Add("E",false,false,Keys.E); rows.Add("F",false,false,Keys.F); rows.Add("G",false,false,Keys.G); rows.Add("H",false,false,Keys.H); rows.Add("I",false,false,Keys.I); rows.Add("J",false,false,Keys.J);
            rows.Add("K",false,false,Keys.K); rows.Add("L",false,false,Keys.L); rows.Add("M", false, false, Keys.M); rows.Add("N", false, false, Keys.N); rows.Add("O", false, false, Keys.O); rows.Add("P", false, false, Keys.P); rows.Add("Q", false, false, Keys.Q); rows.Add("R", false, false, Keys.R); rows.Add("T", false, false, Keys.T); rows.Add("U", false, false, Keys.U);
            rows.Add("V", false, false, Keys.V); rows.Add("W", false, false, Keys.W); rows.Add("X", false, false, Keys.X); rows.Add("Y", false, false, Keys.Y); rows.Add("Z", false, false, Keys.Z);

            
            rows.Add("[",false,false,Keys.OemOpenBrackets); rows.Add("]",false,false,Keys.OemCloseBrackets); rows.Add(";",false,false,Keys.OemSemicolon); rows.Add("'",false,false,Keys.OemQuotes); rows.Add(",",false,false,Keys.Oemcomma); rows.Add(".",false,false,Keys.OemPeriod); rows.Add("/",false,false,Keys.Divide); rows.Add("Tab",false,false,Keys.Tab); rows.Add("Caps",false,false,Keys.CapsLock);
            rows.Add("Ins"); rows.Add("Home"); rows.Add("Del"); rows.Add("End"); rows.Add("Pause"); rows.Add("PgUp"); rows.Add("PgDn"); rows.Add("\\",false,false,Keys.OemBackslash);
            rows.Add("-",false,false,Keys.OemMinus); rows.Add("=",false,false,Keys.Oemplus);

            rows.Add("↑",false,false,Keys.Up); rows.Add("↓",false,false,Keys.Down); rows.Add("←",false,false,Keys.Left); rows.Add("→",false,false,Keys.Right);

        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnClick(object sender, EventArgs e)
        {

            if (keyData.SelectedRows == null) return;

            foreach(DataGridViewRow selKey in keyData.SelectedRows)
            {
                AddKey key = new AddKey();
                key.key = (Keys)selKey.Cells[3].Value;
                key.isShift = Convert.ToBoolean(selKey.Cells[1].Value) == true ? 1 : 0;
                key.isCtrl = Convert.ToBoolean(selKey.Cells[2].Value) == true ? 1 : 0;

                lKey.Add(key);
            }

            this.Close();
        }
    }
}
