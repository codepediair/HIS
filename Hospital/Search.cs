using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        private char numberFormat(char ch)
        {
            if ((ch < '0' || ch > '9') && ch != (char)8)
                return '\0';
            return ch;
        }
        private char ParsianNameFormate(char ch)
        {
            if ((ch < 'ا' || ch > 'ی') && ch != (char)8 && ch != (char)32 && ch != 'آ')
                return '\0';
            return ch;
        }

        private void txtSCod_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.LemonChiffon;
        }

        private void txtSCod_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txtSCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = numberFormat(e.KeyChar);
        }

        private void txtSLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = ParsianNameFormate(e.KeyChar);
        }
    }
}
