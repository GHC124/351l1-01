using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

      

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            if (cbbtoan.Text == "+")
                txtKQ.Text = (Convert.ToInt32(txtnumber1.Text) + Convert.ToInt32(txtnumber2.Text)).ToString();
            else if (cbbtoan.Text == "-")
                txtKQ.Text = (Convert.ToInt32(txtnumber1.Text) - Convert.ToInt32(txtnumber2.Text)).ToString();
            else if (cbbtoan.Text == "*")
                txtKQ.Text = (Convert.ToDouble(txtnumber1.Text) * Convert.ToDouble(txtnumber2.Text)).ToString();
            else if (cbbtoan.Text == "/")
                txtKQ.Text=(Convert.ToDouble(txtnumber1.Text) / Convert.ToDouble(txtnumber2.Text)).ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
            txtnumber1.Text = "";
            txtnumber2.Text = "";
            cbbtoan.Text = "";

        }

        
    }
}
