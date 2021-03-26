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
        private static KeyParseUtil keyUtil;
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
                keyUtil = new KeyParseUtil();
            }

            return EventCnt;
        }

        /// <summary>
        /// 읽어온 메크로를 인스턴스화.
        /// </summary>
        public void LoadMacro()
        {
            mList = new List<CMacro>();

            int total;
            int count1;
            int count2;
            string head;
            string tail;
            string file;
            CMacro cm;

            string[] section = Resources.Section.Split(',');    // COUNT,REGISTKEY,TITLE,INPUTKEY
            string[] key = Resources.Key.Split(',');            // TOTALCOUNT,KEY,COUNT,REGIST,TITLE,INPUT
            file = Application.StartupPath + Resources.File;

            total = WinLib.GetPrivateProfileInteger(section[0], key[0], file);

            for (int index1 = 1; index1 <= total; index1++)
            {
                cm = new CMacro( WinLib.GetPrivateProfileString(section[2], key[4] + index1, file) );
                cm.regist = SetMacroKey(WinLib.GetPrivateProfileString(section[1], key[3] + index1, file)); 

                count1 = WinLib.GetPrivateProfileInteger(section[0], key[1] + index1 + key[2], file);

                for (int index2 = 1; index2 <= count1; index2++)
                {
                    cm.keyList.Add(SetMacroKey(WinLib.GetPrivateProfileString(section[3], key[1] + index1 + key[5] + index2, file)));
                }

                mList.Add(cm);
            }
        }

        public void WriteMacro()
        {
            string file;
            string[] section = Resources.Section.Split(',');    // COUNT,REGISTKEY,TITLE,INPUTKEY
            string[] key = Resources.Key.Split(',');            // TOTALCOUNT,KEY,COUNT,REGIST,TITLE,INPUT

            file = Application.StartupPath + Resources.File;
            

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
        /// 키와 보조키를 RegistKey 클래스에 대입 후 리턴시킴.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public RegistKey SetMacroKey(String str)
        {
            return keyUtil.ParseKey(str);
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

        public string GetTitle(CMacro cm)
        {
            return keyUtil.GetTitle(cm);
        }

        public int GetModified(object shift, object Ctrl, object Alt)
        {
            return keyUtil.GetModified(shift, Ctrl, Alt);
        }

    }
}
