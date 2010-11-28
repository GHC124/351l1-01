using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        double SoHang = 0;
        double KetQua = 0;
        string ToanTu = "";
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            SOHANG("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SOHANG("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SOHANG("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SOHANG("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            SOHANG("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            SOHANG("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            SOHANG("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            SOHANG("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            SOHANG("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            SOHANG("9");
        }

        private void btnPhay_Click(object sender, EventArgs e)
        {
            if (rtbSoHang.Text != "" && KTThapPhan() == false)
            {
                rtbSoHang.Text = rtbSoHang.Text + ".";
            }
            else
                rtbSoHang.Focus();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TOANTU("+");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            TOANTU("-");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            TOANTU("*");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            TOANTU("/");
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            SoHang = double.Parse(rtbSoHang.Text);
            TINHTOAN(rtbToanTu.Text);
            rtbKetQua.Text = KetQua.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbSoHang.Clear();
            rtbSoHang.Focus();
            rtbToanTu.Clear();
            rtbKetQua.Clear();
            SoHang = 0;
            KetQua = 0;
            ToanTu = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rtbSoHang.Text != "")
            {
                int n = rtbSoHang.Text.Length;
                rtbSoHang.Text = rtbSoHang.Text.Remove(n - 1, 1);
            }
            else
                rtbSoHang.Focus();
        }

        private void SOHANG(string s)
        {
            if (ToanTu != "")
                rtbSoHang.Clear();
            ToanTu = "";
            rtbSoHang.Text = rtbSoHang.Text + s;
        }

        private void TOANTU(string s)
        {
            SoHang = 0;
            KetQua = 0;
            if (rtbSoHang.Text != "")
            {
                SoHang = double.Parse(rtbSoHang.Text);
                TINHTOAN(s);
                rtbToanTu.Text = s;
                ToanTu = rtbToanTu.Text;
            }
            else
                rtbSoHang.Focus();
        }

        private void TINHTOAN(string s)
        {
            if (KetQua == 0)
                KetQua = SoHang;
            else
            {
                switch (s)
                {
                    case "+": KetQua = KetQua + SoHang;
                        break;
                    case "-": KetQua = KetQua - SoHang;
                        break;
                    case "*": KetQua = KetQua * SoHang;
                        break;
                    case "/": KetQua = KetQua / SoHang;
                        break;
                }
            }
        }

        private bool KTThapPhan()
        {
            char[] c = rtbSoHang.Text.ToCharArray();
            int i;
            int n = c.Length;
            for (i = 0; i < n; i++)
                if (c[i] == '.')
                    return true;
            return false;
        }

    }
}
