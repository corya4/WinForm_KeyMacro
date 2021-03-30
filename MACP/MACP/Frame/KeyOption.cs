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

    public partial class KeyOption : Form
    {
        CMacro cm;
        MacpMain main;
        EventController Ectr;

        public KeyOption(object cm, MacpMain form)
        {
            InitializeComponent();
            this.Location = new Point(form.Location.X + form.Width - 15, form.Location.Y);
            Ectr = EventController.GetInstance();

            this.cm = cm as CMacro;
            this.main = form;

            init();
        }

        private void init()
        {
            main.ToggleVisible();
            WinLib.SetDockPanel(pnl_option);
        }

        private void OnClick(object sender, EventArgs e)
        {
            new Keyboard(cm, false, this);
        }

        private void OnClick2(object sender, EventArgs e)
        {
            new Keyboard(cm, true, this);
        }

        private void OnOK(object sender, EventArgs e)
        {
            if ((cm.regist == null || cm.keyList == null))
            {
                MessageBox.Show("Select MacroKey");/* afer modified MessageBoxEX */
                return;
            }

            cm.title = ID_title.Text;
            Ectr.AddMacro(cm);

            this.Dispose();
            main.ToggleVisible();

        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.Dispose();
            main.ToggleVisible();
        }

        public void ToggleVisible()
        {
            if (this.pnl_option.Visible)
            {
                this.pnl_option.Visible = false;
            }
            else
            {
                this.pnl_option.Visible = true;
            }
        }
        
        public void SeyKeyRegist()
        {
            
        }

        public void SetkeyList()
        {
            bool isAlt;
            bool isCtrl;
            bool isShift;
            int md;

            int index = InputKey.Rows.Count + 1;
            int index2 = 0;

            foreach (RegistKey key in cm.keyList)
            {
                md = key.modify;
                isAlt = (md & 1) == 1 ? true : false;
                isCtrl = (md & 2) == 1 ? true : false;
                isShift = (md & 4) == 1 ? true : false;

                InputKey.Rows.Add(index++, key.key.ToString(), isShift, isCtrl, isAlt);
                cm.keyList[index2].key = key.key;
                cm.keyList[index2].modify = key.modify;
            }
        }

    }
}
