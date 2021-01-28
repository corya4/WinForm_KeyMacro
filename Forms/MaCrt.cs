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
        List<AddKey> lList;

        public MaCrt(object cm)
        {
            InitializeComponent();
            this.cm = cm as CMacro;
        }

        private void OnClick1(object sender, EventArgs e)
        {
            List<AddKey> lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList, this.Location, false);
            kb.ShowDialog();

            if (lList.Count == 0) return;

            AddKey key = lList[0];
            textBox2.Text = String.Format(key.key.ToString());

        }

        private void OnClick2(object sender, EventArgs e)
        {
            lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList, this.Location, true);

            if (kb.ShowDialog() != DialogResult.OK) return;

            int index = InputKey.Rows.Count + 1;
            foreach(AddKey key in lList)
            {
                InputKey.Rows.Add(index++, key.key.ToString(),
                           key.isShift == 1 ? true : false, key.isCtrl == 1 ? true : false);
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
            if (lList == null)
            {
                MessageBox.Show("Select MacroKey");/* afer modified MessageBoxEX */
                return;            }

            cm.m_title = ID_title.Text;

            foreach (AddKey key in lList)
            {
                cm.keys.Add(key.key);
                cm.shifts.Add(key.isShift);
                cm.ctrls.Add(key.isCtrl);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
