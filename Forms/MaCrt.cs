using MACP.Macro;
using MACP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Forms
{

    public partial class MaCrt : Form
    {
        CMacro cm;
        AddKey regKey;
        List<AddKey> lList;

        public MaCrt(object cm, Form1 form)
        {
            InitializeComponent();
            this.Location = new Point(form.Location.X + form.Width - 15, form.Location.Y);
            this.cm = cm as CMacro;
        }

        private void OnClick(object sender, EventArgs e)
        {
            int modify;
            lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList, this.Location, false);

            if ( (kb.ShowDialog() != DialogResult.OK) || (lList.Count == 0))
            {
                return;
            }

            regKey = lList[0];
            
            ID_registBox.Text = regKey.key.ToString() + ((regKey.isShift == 1) ? " + Shift" : "") + ((regKey.isCtrl == 1) ? " + Ctrl" : "") + ((regKey.isAlt == 1) ? " + Alt" : "");
            
        }

        private void OnClick2(object sender, EventArgs e)
        {
            lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList, this.Location, true);

            bool isAlt;
            bool isCtrl;
            bool isShift;
            int md;

            if (kb.ShowDialog() != DialogResult.OK)
            {
                lList = null;
                return;
            }
            int index = InputKey.Rows.Count + 1;

            foreach(AddKey key in lList)
            {
                isAlt = key.isAlt == 1 ? true : false;
                isCtrl = key.isCtrl == 1 ? true : false;
                isShift = key.isShift == 1 ? true : false;

                InputKey.Rows.Add(index++, key.key.ToString(), isShift, isCtrl, isAlt);

                md = 0;

                if (isAlt) md += 1;
                if (isCtrl) md += 2;
                if (isShift) md += 4;

                key.modify = md;
            }
        

        }

        private void OnCancel(object sender, EventArgs e)
        {
            cm = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OnOK(object sender, EventArgs e)
        {
            if ((lList == null || regKey == null))
            {
                MessageBox.Show("Select MacroKey");/* afer modified MessageBoxEX */
                return;           
            }

            cm.m_title = ID_title.Text;
            cm.regist = regKey;

            foreach (AddKey key in lList)
            {
                cm.keys.Add(key.key);
                cm.shifts.Add(key.isShift);
                cm.ctrls.Add(key.isCtrl);
                cm.alts.Add(key.isAlt);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
