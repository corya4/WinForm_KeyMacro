using MACP.Forms;
using MACP.Macro;
using MACP.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MACP
{
    public partial class MacpMain : Form
    {
        KeyModel k_model;

        List<bool> aceptMacro;
        List<int> HotKeys;
        const int HOTKEY = 0x0312; // keyboard Event

        //윈폼 이벤트 컨트롤러
        EventController Ectr;

        #region C# EVENT Method
        
        public MacpMain()
        {
            InitializeComponent();

            aceptMacro = new List<bool>();
            Ectr = EventController.GetInstance();
        }



        private void OnEntry(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            CMacro c = k_model.macros[index];

            if (((ToggleButtonCell)((DataGridViewRow)sender).Cells[0]).toggle) 
            {
                WinLib.RegisterHotKey((int)this.Handle, e.RowIndex, c.regist.modify, (int)c.regist.key);
                HotKeys.Add(e.RowIndex);
            }
            else 
            { 
                WinLib.UnregisterHotKey((int)this.Handle, e.RowIndex);
                HotKeys.Remove(e.RowIndex);
            }
        }

        public void RegistReregister()
        {
            foreach(int index in HotKeys)
            {
                CMacro c = k_model.macros[index];
                WinLib.RegisterHotKey((int)this.Handle, index, c.regist.modify, (int)c.regist.key);
            }
        }

        public void RegistAllUnregister()
        {
            foreach(int index in HotKeys)
            {
                WinLib.UnregisterHotKey((int)this.Handle, index);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            k_model = new KeyModel();
            HotKeys = new List<int>();


            Ectr.EntryMacro();
            SetViewer();
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            // WinLib.UnregisterHotKey((int)this.Handle, 0); // 키 등록 해제
        }

        #endregion

        protected void SetViewer()
        {
            foreach (CMacro cm in k_model.macros) AMD.AddMacro(cm);
        }

        protected override void WndProc(ref Message m) //윈도우프로시저 콜백함수
        {
            if (m.Msg == HOTKEY)
            {
                 KeyValuePair<Keys, int> keys = WinLib.InputKey(m);
                 int index;
                 if ((index = GetMacroKey(keys)) != -1)
                 {
                     k_model.OnMacro(index);
                     return;
                 }
            }

            base.WndProc(ref m);
        }

        private int GetMacroKey(KeyValuePair<Keys, int> key)
        {
            foreach (DataGridViewRow row in MacroViewer.Rows)
            {
                MacroViewer.
                MacroViewer.Rows[0].Cells[0]
                if (!cell.O ) continue;

                int index = row.Index;
                CMacro c = k_model.macros[index];

                if (key.Key == c.regist.key && key.Value == c.regist.modify)
                    return index;
            }

            return -1;
        }

        private void AddMacro(object sender, EventArgs e)
        {
            CMacro cm = new CMacro("");
            MaCrt cf = new MaCrt(cm, this);

            if (cf.ShowDialog() != DialogResult.OK) return;

            k_model.macros.Add(cm);
            AMD.AddMacro(cm);
            
        }

    }
}
