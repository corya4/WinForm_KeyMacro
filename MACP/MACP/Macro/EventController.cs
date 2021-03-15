using MACP.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Macro
{
    class EventController
    {
        private static EventController EventCnt;
        private DataGridView viewer;
        private List<CMacro> mList;


        public static EventController GetInstance()
        {
            if(EventCnt == null)
            {
                EventCnt = new EventController();
            }

            return EventCnt;
        }

        public void SetViewer(DataGridView viewer)
        {
            EventCnt.viewer = viewer;
        }

        public void EntryMacro()
        {
            String[] tmpArr;
            String tmpTitle;
            int total_m;
            int key_m;

            try
            {
                tmpArr = Resources.Tag.Split(',');
                total_m = WinLib.GetPrivateProfileInteger(Resources.Section, Resources.Count, Application.StartupPath + Resources.File);
           
                for(int i = 0; i < total_m; i++)
                {
                    int index = i + 1;
                    CMacro macro = null;
                    tmpTitle = WinLib.GetPrivateProfileString(Resources.Section, Resources.Mcr + index + tmpArr[0], Resources.File);
                    key_m = WinLib.GetPrivateProfileInteger(Resources.Section, Resources.Mcr + index + tmpArr[1], Resources.File);

                }

            }
            catch
            {
                return;
            }
        }

        public void AddMacro(object data, int index)
        {
            CMacro macro = data as CMacro;
        }
    }
}
