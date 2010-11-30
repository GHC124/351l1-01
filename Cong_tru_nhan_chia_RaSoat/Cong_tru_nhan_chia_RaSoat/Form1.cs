using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cong_tru_nhan_chia_RaSoat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCong_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }
            else
            {

                //kiemtra();
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                //if (cboxDau1.Checked == true)
                //    so1 = so1 * -1;
                //if (cboxDau2.Checked == true)
                //    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 + so2);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }
           
            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                //if (cboxDau1.Checked == true)
                //    so1 = so1 * -1;
                //if (cboxDau2.Checked == true)
                //    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 - so2);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }
           
            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                //if (cboxDau1.Checked == true)
                //    so1 = so1 * -1;
                //if (cboxDau2.Checked == true)
                //    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 * so2);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }
           
            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                //if (cboxDau1.Checked == true)
                //    so1 = so1 * -1;
                //if (cboxDau2.Checked == true)
                //    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 / so2);
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSo1.Text = "";
            txtSo2.Text = "";
            txtKetQua.Text = "";
            cboxDau1.Checked = false;
            cboxDau2.Checked = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            r = MessageBox.Show("Bạn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSo1_TextChanged_1(object sender, EventArgs e)
        {
           // int[] temp = new int[100];
            string temp;
            int n;
            char c;
            if (txtSo1.Text.Length > 0 && !char.IsDigit(txtSo1.Text[txtSo1.Text.Length - 1]))
            {
                temp = txtSo1.Text;
                n = txtSo1.Text.Length-1;
                //for (int i = 0; i < n; i++)
                //{
                    c = temp[n];
                    if ((n == 0 && (c == '-'||c=='+')) || (n > 0 && c == '.'))
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập số");
                        txtSo1.Text = "";
                       // break;

                    }
                }

            
            else return;
        }

        private void txtSo2_TextChanged_1(object sender, EventArgs e)
        {
            string temp;
            int n;
            char c;
            if (txtSo1.Text.Length > 0 && !char.IsDigit(txtSo1.Text[txtSo1.Text.Length - 1]))
            {
                temp = txtSo1.Text;
                n = txtSo1.Text.Length-1;
                //for (int i = 0; i < n; i++)
                //{
                    c = temp[n];
                    if ((n == 0 && (c == '-'||c=='+')) || (n > 0 && c == '.'))
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập số");
                        txtSo1.Text = "";
                       // break;

                    }
                }

            
            else return;
        }

        private void btnCong_Click_1(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }
            else
            {

                //kiemtra();
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                if (cboxDau1.Checked == true)
                    so1 = so1 * -1;
                if (cboxDau2.Checked == true)
                    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 + so2);
            }
        }

        private void btnTru_Click_1(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }

            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                if (cboxDau1.Checked == true)
                    so1 = so1 * -1;
                if (cboxDau2.Checked == true)
                    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 - so2);
            }
        }

        private void btnNhan_Click_1(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }

            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                if (cboxDau1.Checked == true)
                    so1 = so1 * -1;
                if (cboxDau2.Checked == true)
                    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 * so2);
            }
        }

        private void btnChia_Click_1(object sender, EventArgs e)
        {
            double so1 = 0, so2 = 0;
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
            {
                if (txtSo1.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 1");
                if (txtSo2.Text.Length == 0)
                    MessageBox.Show("Bạn chưa nhập số thứ 2");
            }

            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                if (cboxDau1.Checked == true)
                    so1 = so1 * -1;
                if (cboxDau2.Checked == true)
                    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 / so2);
            }
        }
    }
}
