using MACP.Model;
using MACP.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MACP.Macro
{
    class EventController
    {
        private static EventController EventCnt;    // 싱글톤 객체
        private DataGridView viewer;                // 참조할 컨트롤러
        private List<CMacro> mList;                 // 매크로 리스트
        private List<int> activeList;               // 활성화된 매크로 리스트

        /// <summary>
        /// 싱글톤으로 사용함.
        /// </summary>
        /// <returns></returns>
        public static EventController GetInstance()
        {
            if(EventCnt == null)
            {
                EventCnt = new EventController();
            }

            return EventCnt;
        }

        /// <summary>
        /// 참조할 DataGridView객체 초기화.
        /// </summary>
        /// <param name="viewer"></param>
        public void SetViewer(DataGridView viewer)
        {
            EventCnt.viewer = viewer;
            mList = new List<CMacro>();
            activeList = new List<int>();
        }

        /// <summary>
        /// 파일에서 저장된 매크로를 로드함.
        /// </summary>
        public void EntryMacro()
        {
            CMacro macro = null;       // 메크로 데이터
            String tmpTitle;
            String tmpRegist;
            String tmpInKey;
            int total_m;
            int key_m;

            try
            {
                total_m = WinLib.GetPrivateProfileInteger("COUNT", "TOTALCOUNT", Application.StartupPath + Resources.File);
           
                for(int i = 1; i <= total_m; i++)
                {
                    key_m = WinLib.GetPrivateProfileInteger("COUNT", "KEY" + i + "COUNT", Resources.File);
                    tmpTitle = WinLib.GetPrivateProfileString("TITLE", "TITLE" + i, Resources.File);
                    tmpRegist = WinLib.GetPrivateProfileString("REGISTKEY", "REGIST" + i, Resources.File);

                    macro = new CMacro(tmpTitle);
                    macro.regist = SetMacroKey(tmpRegist);

                    for(int j = 1; j <= key_m; j++)
                    {
                        tmpInKey = WinLib.GetPrivateProfileString("INPUTKEY", "KEY" + i + "INPUT" + j, Resources.File);
                        macro.keyList.Add(SetMacroKey(tmpInKey));
                    }

                    mList.Add(macro);
                }
            }
            catch
            {
                return;
            }

        }

        /// <summary>
        /// 키와 보조키를 RegistKey 클래스에 대입 후 리턴시킴.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public RegistKey SetMacroKey(String str)
        {
            String[] strArr;
            RegistKey rk = new RegistKey();

            strArr = str.Split(',');
            rk.key = (Keys)Convert.ToChar(strArr[0]);
            rk.modify = Convert.ToInt32(strArr[1]);

            return rk;
        }

        /// <summary>
        /// 매크로리스트 index행의 레지스트리 키를 리턴시킴.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public RegistKey GetRegist(int index)
        {
            return mList[index].regist;
        }

        /// <summary>
        /// 활성화된 매크로의 행을 리스트에 추가.
        /// </summary>
        /// <param name="index"></param>
        public void OnActive(int index)
        {
            activeList.Add(index);
        }

        /// <summary>
        /// 비활성화된 매크로의 행을 리스트에서 제거.
        /// </summary>
        /// <param name="index"></param>
        public void UnActive(int index)
        {
            activeList.Remove(index);
        }

        /// <summary>
        /// 리스트의 담겨있는 모든 매크로를 비활성화 시킴.
        /// </summary>
        public void RegistAllUnregister()
        {
            foreach (int index in activeList)
            {
                WinLib.UnregisterHotKey((int)(WinLib.form.Handle), index);
            }
        }

        /// <summary>
        /// 리스트의 담겨있는 모든 매크로를 활성화 시킴.
        /// </summary>
        public void RegistReregister()
        {
            RegistKey regst;
            foreach (int index in activeList)
            {
                regst = GetRegist(index);
                WinLib.RegisterHotKey((int)(WinLib.form.Handle), index, regst.modify, (int)regst.key);
            }
        }
    }
}
