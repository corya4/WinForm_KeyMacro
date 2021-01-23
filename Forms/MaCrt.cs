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
        KeyModel km;
        public MaCrt(object km)
        {
            InitializeComponent();
            this.km = km as KeyModel;
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
            List<AddKey> lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList, this.Location, true);
            kb.ShowDialog();

            int index = InputKey.Rows.Count + 1;
            foreach(AddKey key in lList)
            {
                InputKey.Rows.Add(index++, key.key.ToString(),
                           key.isShift == 1 ? true : false, key.isCtrl == 1 ? true : false);
            }
        
        }

        private void OnCancel(object sender, EventArgs e)
        {
            km = null;
            this.Close();
        }

        private void OnOK(object sender, EventArgs e)
        {
            
        }
    }
}
