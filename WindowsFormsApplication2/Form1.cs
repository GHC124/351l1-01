using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btketqua_Click(object sender, EventArgs e)
        {
            if (rbcong.Checked == true)
            {
                float tong;
                tong = float.Parse(txbsoa.Text) + float.Parse(txbsob.Text);
                txbketqua.Text = tong.ToString();
            }
            else if (rbtru.Checked == true)
            {
                float tru;
                tru = float.Parse(txbsoa.Text) - float.Parse(txbsob.Text);
                txbketqua.Text = tru.ToString();
            }
            else if (rbnhan.Checked == true)
            {
                float nhan;
                nhan = float.Parse(txbsoa.Text) * float.Parse(txbsob.Text);
                txbketqua.Text = nhan.ToString();
            }
            else 
            {
                float chia;
                chia = float.Parse(txbsoa.Text) / float.Parse(txbsob.Text);
                txbketqua.Text = chia.ToString();
            }
       
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("are you want?", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("chao mung","chao ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button3);
        }
    }
}
