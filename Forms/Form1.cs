using MACP.Forms;
using MACP.Macro;
using MACP.Util;
using MACP.Controll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP
{

    public partial class Form1 : Form
    {

        KeyModel k_model;

        List<bool> aceptMacro;
        bool activited = true;
        const int HOTKEY = 0x0312; // keyboard Event

        #region C# EVENT Method

        public Form1()
        {
            InitializeComponent();
            AMD.viewer = MacroViewer;

            aceptMacro = new List<bool>();
        }

        private void OnEntry(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            CMacro c = k_model.macros[index];

            WinLib.RegisterHotKey((int)this.Handle, e.RowIndex, c.regist.modify, (int)c.regist.key);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            k_model = new KeyModel();
            EntryMacro();
            SetViewer();
        }



        private void OnClose(object sender, FormClosedEventArgs e)
        {
            WinLib.UnregisterHotKey((int)this.Handle, 0); // 키 등록 해제
        }

        #endregion

        protected void SetViewer()
        {
            foreach (CMacro cm in k_model.macros) AMD.AddMacro(cm);//MacroViewer.Rows.Add(cm.m_title);
        }

        protected void EntryMacro()
        {
            String ini = Application.StartupPath + "\\EntryMacro.txt";
            String[] readLine = File.ReadAllLines(ini);

            CMacro macro = null;

            for (int i = 0; i < readLine.Length; i++)
            {
                if (readLine[i].Equals(""))
                {
                    continue;
                }
                switch (i % 5)
                {
                    case 0:
                        macro = new CMacro(readLine[i]);
                        break;
                    case 1:
                        macro.modified = Convert.ToInt32(readLine[i]);
                        break;
                    case 2:
                        macro.regist.key = (Keys)Convert.ToInt32(readLine[i]);
                        break;
                    case 3:
                        String[] strKey = readLine[i].Split(',');
                        foreach (String key in strKey) macro.keys.Add((Keys)Convert.ToInt32(key));
                        k_model.Input(macro);
                        break;
                }
                aceptMacro.Add(false);
            }
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
                var cell = row.Cells[0] as ToggleButtonCell;
                if (!cell.toggle) continue;

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
