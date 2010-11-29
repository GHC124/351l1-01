using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class frmTinh : Form
    {
        public frmTinh()
        {
            InitializeComponent();
        }

        private void frmtinhkq_Click(object sender, EventArgs e)
        {
            if (cbbpheptinh.Text == "+")
            {
                try
                {
                    double ketqua = double.Parse(txtsohang1.Text) + double.Parse(txtsohang2.Text);
                    txtketqua.Text = ketqua.ToString();
                }
                catch (Exception bt){
                    MessageBox.Show("Error! " + bt.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbbpheptinh.Text=="-")
            {
                try
                {
                    double ketqua = double.Parse(txtsohang1.Text) - double.Parse(txtsohang2.Text);
                    txtketqua.Text = ketqua.ToString();
                }
                catch (Exception bt)
                {
                    MessageBox.Show("Error! " + bt.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbbpheptinh.Text=="*")
            {
                try
                {
                    double ketqua = double.Parse(txtsohang1.Text) * double.Parse(txtsohang2.Text);
                    txtketqua.Text = ketqua.ToString();
                }
                catch (Exception bt)
                {
                    MessageBox.Show("Error! " + bt.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbbpheptinh.Text == "/")
            {
                try
                {
                    double ketqua = double.Parse(txtsohang1.Text) / double.Parse(txtsohang2.Text);
                    txtketqua.Text = ketqua.ToString();
                }
                catch (Exception bt)
                {
                    MessageBox.Show("Error! " + bt.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void frmthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
