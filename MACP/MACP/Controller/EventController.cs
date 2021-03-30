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
        private DataGridVIewTB.DataGridVIewTB viewer;                // 참조할 컨트롤러
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
            string head;
            string tail;
            string file;
            CMacro cm;

            string[] section = Resources.Section.Split(',');    // COUNT,REGISTKEY,TITLE,INPUTKEY
            string[] key = Resources.Key.Split(',');            // TOTALCOUNT,KEY,COUNT,REGIST,TITLE,INPUT
            file = Application.StartupPath + Resources.File;

            Console.WriteLine(file);

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

                AddMacro(cm);
            }
        }
        
        /// <summary>
        /// 메크로 추가하는 메소드.
        /// </summary>
        /// <param name="cm"></param>
        public void AddMacro(CMacro cm)
        {
            AddViewer(cm.title);
            AddMacroList(cm);
        }

        private  void AddViewer(string str)
        {
            viewer.Rows.Add();
            viewer.SetToggleButton(str, mList.Count, 0);
        }

        private void AddMacroList(CMacro cm)
        {
            mList.Add(cm);
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
            EventCnt.viewer = viewer as DataGridVIewTB.DataGridVIewTB;
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
        public void RegistAllregister()
        {
            RegistKey regst;
            foreach (int index in activeList)
            {
                regst = GetRegist(index);
                WinLib.RegisterHotKey((int)(WinLib.form.Handle), index, regst.modify, (int)regst.key);
            }
        }

        /// <summary>
        /// Win Message객체 파싱 메소드.
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public RegistKey ParseRegist(Message m)
        {
            return keyUtil.ParseRegist(m);
        }

        public string GetRegistTitle(RegistKey regist)
        {
            return keyUtil.GetRegistTitle(regist);
        }

        public string GetTitle(CMacro cm)
        {
            return keyUtil.GetTitle(cm);
        }

        public int GetModified(object shift, object Ctrl, object Alt)
        {
            return keyUtil.GetModified(shift, Ctrl, Alt);
        }

        public void ExeMacro(RegistKey regst)
        {
            Console.WriteLine("얻어온 레지스트키 : " + regst.key + "  " + regst.modify);
            foreach (CMacro cm in mList)
            {
                if ((cm.regist.key == regst.key) && (cm.regist.modify == regst.modify))
                {

                    Console.WriteLine("같은 레지스트키 찾음.");
                    StartMacro(cm);
                    return;
                }
            }
        }

        public void StartMacro(CMacro cm)
        {
            RegistAllUnregister();

            int[] mArr = new int[] { 16, 17, 18 };
            foreach(RegistKey key in cm.keyList)
            {
                //키 다운
                for(int i = 1; i <= 3; i++)
                {
                    if((key.modify & 1 << i) == 1)
                    {
                        WinLib.keybd_event((byte)mArr[i-1], 0, 0, 0);
                    }
                }
                WinLib.keybd_event((byte)key.key, 0, 0x00, 0);

                //키 업
                WinLib.keybd_event((byte)key.key, 0, 0x02, 0);
                for (int i = 1; i <= 3; i++)
                {
                    if ((key.modify & 1 << i) == 1)
                    {
                        WinLib.keybd_event((byte)mArr[i - 1], 0, 1, 0);
                    }
                }
                
            }

            RegistAllregister();
        }
    }
}
