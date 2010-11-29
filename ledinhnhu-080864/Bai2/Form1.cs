using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("UCLN");
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "+")
            {
                int no1 = int.Parse(textBox1.Text);
                int no2 = int.Parse(textBox2.Text);
                int result;
                result = no1 + no2;
                textBox3.Text = result.ToString();
            } 
            if (comboBox1.Text == "-")
            {
                int no1 = int.Parse(textBox1.Text);
                int no2 = int.Parse(textBox2.Text);
                int result;
                result = no1 - no2;
                textBox3.Text = result.ToString();
            }
            if (comboBox1.Text == "*")
            {
                int no1 = int.Parse(textBox1.Text);
                int no2 = int.Parse(textBox2.Text);
                int result;
                result = no1 * no2;
                textBox3.Text = result.ToString();
            }
            if (comboBox1.Text == "/")
            {
                int no1 = int.Parse(textBox1.Text);
                int no2 = int.Parse(textBox2.Text);
                int result;
                result = no1 / no2;
                textBox3.Text = result.ToString();
            }
            /*if (comboBox1.Text == "UCLN")
            {
                int no1 = int.Parse(textBox1.Text);
                int no2 = int.Parse(textBox2.Text);
                int r;
                while (no2 != 0)
                {
                    r = no1 % no2;
                    no1 = no2;
                    no2 = r;
                }
                return no1;
                textBox3.Text = no1.ToString();
            }*/
        }
    }
}
