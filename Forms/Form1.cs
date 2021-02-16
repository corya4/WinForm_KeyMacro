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

    /*
     * PreUpadte LoadVIew
     * - GridView 컴포넌트 수정(버튼 토글 기능 추가)
     * - 예약 메크로(토글On) 시 RegistryHotKey 등록
     * - 프로그램 종료 시 Input된 메크로 파일로 저장.
     */

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

        private void MacroViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            var cell = (sender as DataGridView).Rows[row].Cells[col];

            if(cell is DataGridViewButtonCell)
            {

                if (aceptMacro[row])
                {

                    aceptMacro[row] = false;
                }
                else
                {
                    aceptMacro[row] = true;
                    
                }


            }
        
        }

        private void OnLoad(object sender, EventArgs e)
        {
            k_model = new KeyModel();

            //WinLib.RegisterHotKey((int)this.Handle, 0, 0x0, (int)Keys.F5);

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
            CMacro cm = new CMacro("");
            MaCrt cf = new MaCrt(cm, this);

            if (cf.ShowDialog() != DialogResult.OK) return;

            k_model.macros.Add(cm);
            AMD.AddMacro(cm);
            
        }

        private void MacroViewer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            var cell = (sender as DataGridView).Rows[row].Cells[col];

            if (cell is DataGridViewButtonCell)
            {
                DataGridViewButtonCell btnCell = cell as DataGridViewButtonCell;

                
                
                if (aceptMacro[row])
                {

                    aceptMacro[row] = false;
                }
                else
                {
                    aceptMacro[row] = true;

                }

            }
        }
    }
}
