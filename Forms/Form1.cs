using MACP.Forms;
using MACP.Macro;
using MACP.Util;
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

        bool activited = true;
        const int HOTKEY = 0x0312;

        #region C# EVENT Method

        public Form1()
        {
            InitializeComponent();
        }

        private void MacroViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             var Btn = (sender as DataGridView).Rows[e.RowIndex];
             DataGridViewCell d = Btn.Cells[0];
          
        }

        private void OnLoad(object sender, EventArgs e)
        {
            k_model = new KeyModel();
            WinLib.RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.F5);
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
            foreach(CMacro cm in k_model.macros) MacroViewer.Rows.Add(cm.m_title);
        }

        protected void EntryMacro()
        {
            String ini = Application.StartupPath + "\\EntryMacro.txt";
            String[] readLine = File.ReadAllLines(ini);

            CMacro macro = null;

            for(int i = 0; i < readLine.Length; i++)
            {
                if (readLine[i].Equals(""))
                {
                    continue;
                }
                switch(i % 5)
                {
                    
                    case 0:
                        macro = new CMacro(readLine[i]);
                        break;
                    case 1:
                        macro.type = Convert.ToInt32(readLine[i]);
                        break;
                    case 2:
                        macro.regist = (Keys)Convert.ToInt32(readLine[i]);
                        break;
                    case 3:
                        String[] strKey = readLine[i].Split(',');
                        foreach (String key in strKey) macro.keys.Add((Keys)Convert.ToInt32(key));
                        k_model.Input(macro);
                        break;
                }
            }
        }

        protected override void WndProc(ref Message m) //윈도우프로시저 콜백함수
        {
            
            if (m.Msg == HOTKEY)
            {
                var key = WinLib.InputKey(m);
                if (!ToggleMacro(key.Key)) return;

                k_model.OnMacro(key.Key, key.Value);

            }

            base.WndProc(ref m);
        }

        private bool ToggleMacro(Keys key)
        {

            if(key == Keys.F5)
            {
                if (activited) activited = false;
                else activited = true;
                return false;
            }

            if (!activited) return false;

            return true;
        }

        private void AddMacro(object sender, EventArgs e)
        {
            KeyModel km = new KeyModel();
            MaCrt cf = new MaCrt(km);
            cf.ShowDialog();

            
            
        }
    }
}
