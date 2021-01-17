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
        public MaCrt()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            List<AddKey> lList = new List<AddKey>();
            Keyboard kb = new Keyboard(lList);
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
            this.Close();
        }
    }
}
