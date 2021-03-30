using MACP.Macro;
using MACP.Model;
using System;
using System.Windows.Forms;

namespace MACP.Forms
{
    public partial class Keyboard : Form
    {
        EventController Ectr;
        CMacro lKey;
        KeyOption kopt;
        bool mulSel;

        public Keyboard(object obj, bool mulSel, KeyOption kopt)
        {
            InitializeComponent();

            lKey = obj as CMacro;
            Ectr = EventController.GetInstance();

            this.kopt = kopt;
            this.mulSel = mulSel;
        
            init();
            OnLoad();
        }

        private void init()
        {
            kopt.ToggleVisible();
            WinLib.SetDockPanel(pnl_board);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void OnLoad()
        {
            DataGridViewRowCollection rows = keyData.Rows;

            rows.Add("1", false, false, false, Keys.NumPad1);
            rows.Add("2", false, false, false, Keys.NumPad2);
            rows.Add("3", false, false, false, Keys.NumPad3);
            rows.Add("4", false, false, false, Keys.NumPad4);
            rows.Add("5", false, false, false, Keys.NumPad5);
            rows.Add("6", false, false, false, Keys.NumPad6);
            rows.Add("7", false, false, false, Keys.NumPad7);
            rows.Add("8", false, false, false, Keys.NumPad8);
            rows.Add("9", false, false, false, Keys.NumPad9);
            rows.Add("0", false, false, false, Keys.NumPad0);
            rows.Add("F1", false, false, false, Keys.F1);
            rows.Add("F2", false, false, false, Keys.F2);
            rows.Add("F3", false, false, false, Keys.F3);
            rows.Add("F4", false, false, false, Keys.F4);
            rows.Add("F5", false, false, false, Keys.F5);
            rows.Add("F6", false, false, false, Keys.F6);
            rows.Add("F7", false, false, false, Keys.F7);
            rows.Add("F8", false, false, false, Keys.F8);
            rows.Add("F9", false, false, false, Keys.F9);
            rows.Add("F10", false, false, false, Keys.F10);
            rows.Add("F11", false, false, false, Keys.F11);
            rows.Add("F12", false, false, false, Keys.F12);
            rows.Add("A", false, false, false, Keys.A);
            rows.Add("B", false, false, false, Keys.B);
            rows.Add("C", false, false, false, Keys.C);
            rows.Add("D", false, false, false, Keys.D);
            rows.Add("E", false, false, false, Keys.E);
            rows.Add("F", false, false, false, Keys.F);
            rows.Add("G", false, false, false, Keys.G);
            rows.Add("H", false, false, false, Keys.H);
            rows.Add("I", false, false, false, Keys.I);
            rows.Add("J", false, false, false, Keys.J);
            rows.Add("K", false, false, false, Keys.K);
            rows.Add("L", false, false, false, Keys.L);
            rows.Add("M", false, false, false, Keys.M);
            rows.Add("N", false, false, false, Keys.N);
            rows.Add("O", false, false, false, Keys.O);
            rows.Add("P", false, false, false, Keys.P);
            rows.Add("Q", false, false, false, Keys.Q);
            rows.Add("R", false, false, false, Keys.R);
            rows.Add("S", false, false, false, Keys.S);
            rows.Add("T", false, false, false, Keys.T);
            rows.Add("U", false, false, false, Keys.U);
            rows.Add("V", false, false, false, Keys.V);
            rows.Add("W", false, false, false, Keys.W);
            rows.Add("X", false, false, false, Keys.X);
            rows.Add("Y", false, false, false, Keys.Y);
            rows.Add("Z", false, false, false, Keys.Z);
            rows.Add("[", false, false, false, Keys.OemOpenBrackets);
            rows.Add("]", false, false, false, Keys.OemCloseBrackets);
            rows.Add(";", false, false, false, Keys.OemSemicolon);
            rows.Add("'", false, false, false, Keys.OemQuotes);
            rows.Add(",", false, false, false, Keys.Oemcomma);
            rows.Add(".", false, false, false, Keys.OemPeriod);
            rows.Add("/", false, false, false, Keys.Divide);
            rows.Add("Tab", false, false, false, Keys.Tab);
            rows.Add("Caps", false, false, false, Keys.CapsLock);
            rows.Add("Ins", false, false, false, Keys.Insert);
            rows.Add("Home", false, false, false, Keys.Home);
            rows.Add("Del", false, false, false, Keys.Delete);
            rows.Add("End", false, false, false, Keys.End);
            rows.Add("Pause", false, false, false, Keys.Pause);
            rows.Add("PgUp", false, false, false, Keys.PageUp);
            rows.Add("PgDn", false, false, false, Keys.PageDown);
            rows.Add("\\", false, false, false, Keys.OemBackslash);
            rows.Add("-", false, false, false, Keys.OemMinus);
            rows.Add("=", false, false, false, Keys.Oemplus);
            rows.Add("↑", false, false, false, Keys.Up);
            rows.Add("↓", false, false, false, Keys.Down);
            rows.Add("←", false, false, false, Keys.Left);
            rows.Add("→", false, false, false, Keys.Right);
        }

        private void OnCancel(object sender, EventArgs e)
        {
            kopt.ToggleVisible();
            this.Dispose();
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (keyData.SelectedRows == null || keyData.SelectedRows.Count == 0) return;

            if (!mulSel)
            {
                DataGridViewRow selKey = keyData.SelectedRows[0];
                lKey.regist.key = (Keys)selKey.Cells[4].Value;
                lKey.regist.modify = Ectr.GetModified(selKey.Cells[1].Value, selKey.Cells[2].Value, selKey.Cells[3].Value);
                Ectr.GetRegistTitle((lKey.regist));
            }
            else
            {
                foreach(DataGridViewRow selKey in keyData.SelectedRows)
                {
                    RegistKey key = new RegistKey();
                    key.key = (Keys)selKey.Cells[4].Value;
                    key.modify = Ectr.GetModified(selKey.Cells[1].Value, selKey.Cells[2].Value, selKey.Cells[3].Value);
                    lKey.keyList.Add(key);
                }

            }

            kopt.ToggleVisible();
            this.Dispose();

        }

    }
}
