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
                txtKetQua.Text = Convert.ToString(Convert.ToDouble(txtSo1.Text) + Convert.ToDouble(txtSo2.Text));
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
            else
                txtKetQua.Text = Convert.ToString(Convert.ToDouble(txtSo1.Text) - Convert.ToDouble(txtSo2.Text));
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
            else
                txtKetQua.Text = Convert.ToString(Convert.ToDouble(txtSo1.Text) * Convert.ToDouble(txtSo2.Text));
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtSo1.Text.Length == 0 || txtSo2.Text.Length == 0)
                MessageBox.Show("Chưa nhập số");
            else
                txtKetQua.Text = Convert.ToString(Convert.ToDouble(txtSo1.Text) / Convert.ToDouble(txtSo2.Text));
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtSo1.Text = "";
            txtSo2.Text = "";
            txtKetQua.Text = "";
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
