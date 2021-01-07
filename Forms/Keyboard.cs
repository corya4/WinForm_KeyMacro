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
    public partial class Keyboard : Form
    {
        public Keyboard()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = keyData.Rows;
            rows.Add("1"); rows.Add("2"); rows.Add("3"); rows.Add("4"); rows.Add("5"); rows.Add("6"); rows.Add("7"); rows.Add("8"); rows.Add("9"); rows.Add("0");
            rows.Add("F1"); rows.Add("F2"); rows.Add("F3"); rows.Add("F4"); rows.Add("F5"); rows.Add("F6");
            rows.Add("F7"); rows.Add("F8"); rows.Add("F9"); rows.Add("F10"); rows.Add("F11"); rows.Add("F12");

            rows.Add("A"); rows.Add("B"); rows.Add("C"); rows.Add("D"); rows.Add("E"); rows.Add("F"); rows.Add("G"); rows.Add("H"); rows.Add("I"); rows.Add("J");
            rows.Add("K"); rows.Add("L"); rows.Add("M"); rows.Add("N"); rows.Add("O"); rows.Add("P"); rows.Add("Q"); rows.Add("R"); rows.Add("T"); rows.Add("U");
            rows.Add("V"); rows.Add("W"); rows.Add("X"); rows.Add("Y"); rows.Add("Z");

            
            rows.Add("["); rows.Add("]"); rows.Add(";"); rows.Add("'"); rows.Add(","); rows.Add("."); rows.Add("/"); rows.Add("Tab"); rows.Add("Caps");
            rows.Add("Ins"); rows.Add("Home"); rows.Add("Del"); rows.Add("End"); rows.Add("Pause"); rows.Add("PgUp"); rows.Add("PgDn"); rows.Add("\\");
            rows.Add("-"); rows.Add("=");

            rows.Add("↑"); rows.Add("↓"); rows.Add("←"); rows.Add("→");

            
        }
    }
}
