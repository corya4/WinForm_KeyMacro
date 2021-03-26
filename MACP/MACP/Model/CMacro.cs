using MACP.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MACP.Macro
{
    /// <summary>
    /// 매크로의 전체적인 데이터를 담는 클래스
    /// 레지스트리 키와 입력시 실행된 키 리스트 관리
    /// 실질적으로 매크로 발생 함수 포함.
    /// </summary>
    class CMacro
    {
        const int DOWN = 0x00;
        const int UP = 0x02;
        const int ALT = 18;
        const int CTRL = 17;
        const int SHIFT = 16;

        public String title;                    

        public RegistKey regist;
        public List<RegistKey> keyList;
        private int index;                          

        public CMacro(String title)
        {
            this.title = title;
            keyList = new List<RegistKey>();
        }

        public void SetMemRegist()
        {
            regist = new RegistKey();
        }

        public void SetMemList()
        {
            keyList = new List<RegistKey>();
        }

        /// <summary>
        /// 입력된 매크로 발생 함수
        /// </summary>
        public void OnKey()
        {
            for (int i = 0; i < keyList.Count; i++)
            {
                index = i;
                Console.WriteLine(index);
                KeyDown();
                KeyUp();
            }
        }

        /// <summary>
        /// 키 입력 메소드
        /// </summary>
        private void KeyDown()
        {
            //WinLib.keybd_event(Convert.ToByte(keyList[index]), 0, DOWN, 0);
        }

        /// <summary>
        /// 입력 키 해제 메소드
        /// </summary>
        private void KeyUp()
        {
            //WinLib.keybd_event(Convert.ToByte(keys[index]), 0, UP, 0);
        }
        
    }
}
