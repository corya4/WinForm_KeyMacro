using MACP.Model;
using System;
using System.Windows.Forms;

namespace MACP.Macro
{
    class KeyParseUtil
    {

        public RegistKey ParseKey(string str)
        {
            String[] strArr;
            RegistKey rk = new RegistKey();

            strArr = str.Split(',');
            rk.key = (Keys)Convert.ToChar(strArr[0]);
            rk.modify = Convert.ToInt32(strArr[1]);

            return rk;

        } 

        public int GetModified(object Shift, object Ctrl, object Alt)
        {
            int val = 0;
            if ((bool)Shift) val += val << 1;
            if ((bool)Ctrl) val += val << 2;
            if ((bool)Alt) val += val << 3;
            return val;
        }

        public string GetTitle(CMacro cm)
        {
            return cm.regist.key.ToString() + ((cm.regist.modify & 1) == 1 ? " + Shift" : "") + ((cm.regist.modify & 2) == 1 ? " + Cntl" : "") + ((cm.regist.modify & 4) == 1 ? " + Alt" : ""); 
        }

    }
}
