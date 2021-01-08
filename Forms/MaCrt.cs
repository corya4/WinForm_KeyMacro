﻿using MACP.Model;
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
            AddKey ak = new AddKey();
            Keyboard kb = new Keyboard(ak);
            kb.ShowDialog();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
