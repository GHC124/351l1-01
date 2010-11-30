using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a=0;
        float kq=0;// ket qua phep tinh
        char pt=' ';
        int kt=0;
        private void tinh()
        {
            if (pt == '+')
            {
                kq += a;
                pt = ' ';
            }
            if (pt == '-')
            {
                kq -= a;
                pt = ' ';
            }
            if (pt == '*')
            {
                kq *= a;
                pt = ' ';
            }
            if (pt == '/')
            {
                kq /= a;
                pt = ' ';
            }
        }
       
        
        /* nhap cac so*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
           textBox1.Text = textBox1.Text + '1';

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (kt == 1 ||textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '2';
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '3';
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '4';
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '5';
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '6';
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '7';
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '8';
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '9';
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "0" || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '0';
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (kt == 1 || textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")// xoa so 0 o dau hoac ket qua
            {
                textBox1.Text = "0";
                kt = 0;
            }
            textBox1.Text = textBox1.Text + '.';
        }


        private void button11_Click(object sender, EventArgs e)//dau +
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                pt = '+';
                textBox1.Text = "+";
            }
            else
            {
                a = Convert.ToSingle(textBox1.Text);
                if (kq == 0)
                {
                    kq = a;
                    a = 0;
                }
                else
                    tinh();
                pt = '+';
                textBox1.Text = "+";
            }
        }

        private void button12_Click(object sender, EventArgs e)//dau -
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                pt = '-';
                textBox1.Text = "-";
            }
            else
            {
                a = Convert.ToSingle(textBox1.Text);
                if (kq == 0)
                {
                    kq = a;
                    a = 0;
                }
                else
                    tinh();
                pt = '-';
                textBox1.Text = "-";
            }
        }

        private void button13_Click(object sender, EventArgs e)//dau *
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                pt = '*';
                textBox1.Text = "*";
            }
            else
            {
                a = Convert.ToSingle(textBox1.Text);
                if (kq == 0)
                {
                    kq = a;
                    a = 0;
                }
                else
                    tinh();
                pt = '*';
                textBox1.Text = "*";
            }
        }

        private void button14_Click(object sender, EventArgs e)//dau /
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/")
            {
                pt = '/';
                textBox1.Text = "/";
            }
            else
            {
                a = Convert.ToSingle(textBox1.Text);
                if (kq == 0)
                {
                    kq = a;
                    a = 0;
                }
                else
                    tinh();
                pt = '/';
                textBox1.Text = "/";
            }
        }

        private void button15_Click(object sender, EventArgs e)//dau bang
        {
            a = Convert.ToSingle(textBox1.Text);
            tinh();
            textBox1.Text = Convert.ToString(kq);
            kt = 1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chương trình calculator beta 2\nTrần Công Vương\nMSSV: 080926", "About", MessageBoxButtons.OK);
        }

        
    }
}
