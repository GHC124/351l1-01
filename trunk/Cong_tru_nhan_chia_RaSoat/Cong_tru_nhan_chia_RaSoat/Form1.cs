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
        private double so1, so2;
        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length != 0 && !char.IsDigit(txtSo1.Text[txtSo1.Text.Length - 1]))
            {
                MessageBox.Show("Phải nhập số");
                txtSo1.Text = "";
            }
            return;
            
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            if (txtSo2.Text.Length != 0 && !char.IsDigit(txtSo2.Text[txtSo2.Text.Length - 1]))
            {
                MessageBox.Show("Phải nhập số");
                txtSo2.Text = "";
            }
            return;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
            else
            {
                so1 = Convert.ToDouble(txtSo1.Text);
                so2 = Convert.ToDouble(txtSo2.Text);
                if (cboxDau1.Checked == true)
                    so1 = so1 * -1;
                if (cboxDau2.Checked == true)
                    so2 = so2 * -1;
                txtKetQua.Text = Convert.ToString(so1 + so2);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
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

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
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

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
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
    }
}
