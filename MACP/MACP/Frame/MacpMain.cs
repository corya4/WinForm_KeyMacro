using MACP.Macro;
using MACP.Model;
using MACP.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MACP
{
    public partial class MacpMain : Form
    {
        const int HOTKEY = 0x0312;  // keyboard Event
        EventController Ectr;       //윈폼 이벤트 컨트롤러

        /// <summary>
        /// 생성과 동시에 Controller생성
        /// </summary>
        public MacpMain()
        {
            InitializeComponent();
            Ectr = EventController.GetInstance();
            Ectr.SetViewer(MacroViewer);
        }

        /// <summary>
        /// 어플리케이션 실행시 메크로파일 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, System.EventArgs e)
        {
            Ectr.LoadMacro();

        }

        /// <summary>
        /// 데이터그리드뷰 셀 클릭 이벤트메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEntry(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            RegistKey regst = Ectr.GetRegist(row);

            if (MacroViewer.Clicked(row, col) == 0)
            {
                WinLib.RegisterHotKey((int)this.Handle, row, regst.modify, (int)regst.key);
                Ectr.OnActive(row);
            }
            else
            {
                WinLib.UnregisterHotKey((int)this.Handle, row);
                Ectr.UnActive(row);
            }
        }

        /// <summary>
        /// 어플리케이션 종료시 발생 이벤트메소드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            Ectr.RegistAllUnregister();
            Ectr.WriteMacro();
        }

        /// <summary>
        /// 윈도우프로시저 콜백함수 [키보드이벤트만 허용]
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == HOTKEY)
            {
                RegistKey key = Ectr.ParseRegist(m);
                Ectr.ExeMacro(key);
            }

            base.WndProc(ref m);
        }
    }
}
