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
        EventController Ectr;

        public MaCrt(object cm, MacpMain form)
        {
            InitializeComponent();
            this.Location = new Point(form.Location.X + form.Width - 15, form.Location.Y);
            this.cm = cm as CMacro;
            Ectr = EventController.GetInstance();
        }

        private void OnClick(object sender, EventArgs e)
        {
            CMacro tcm = new CMacro("");
            Keyboard kb = new Keyboard(tcm, this.Location, false);

            if ( (kb.ShowDialog() != DialogResult.OK) || (cm.regist == null)) return;
         
            cm.regist.key = tcm.keyList[0].key;
            cm.regist.modify = tcm.keyList[0].modify;

            ID_registBox.Text = Ectr.GetTitle(cm);
        }

        private void OnClick2(object sender, EventArgs e)
        {
            CMacro tcm = new CMacro("");
            Keyboard kb = new Keyboard(tcm, this.Location, true);

            bool isAlt;
            bool isCtrl;
            bool isShift;
            int md;

            if (kb.ShowDialog() != DialogResult.OK) return;
            
            int index = InputKey.Rows.Count + 1;
            int index2 = 0;

            foreach(RegistKey key in tcm.keyList)
            {
                md = key.modify;
                isAlt = (md & 1) == 1 ? true : false;
                isCtrl = (md & 2) == 1? true : false;
                isShift = (md & 4) == 1 ? true : false;

                InputKey.Rows.Add(index++, key.key.ToString(), isShift, isCtrl, isAlt);
                cm.keyList[index2].key = key.key;
                cm.keyList[index2].modify = key.modify;
            }
        

        }

        private void OnOK(object sender, EventArgs e)
        {
            if ((cm.regist == null || cm.keyList == null))
            {
                MessageBox.Show("Select MacroKey");/* afer modified MessageBoxEX */
                return;
            }

            cm.title = ID_title.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            cm = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
