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
    public partial class Code_ : Form
    {
        double a, b;
        
        public Code_()
        {
            InitializeComponent();
        }
        private void invi()
        {
            bt1.Visible = false;
            bt2.Visible = false;
            bt2.Visible = false;
            bt3.Visible = false;
            bt4.Visible = false;
            bt5.Visible = false;
            bt6.Visible = false;
            bt7.Visible = false;
            bt8.Visible = false;
            bt9.Visible = false;
            btc.Visible = false;
            bt0.Visible = false;

        }
        private void not_invi()
        {
            bt1.Visible = true;
            bt2.Visible = true;
            bt2.Visible = true;
            bt3.Visible = true;
            bt4.Visible = true;
            bt5.Visible = true;
            bt6.Visible = true;
            bt7.Visible = true;
            bt8.Visible = true;
            bt9.Visible = true;
            bt0.Visible = true;
            btc.Visible = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private double cong(double a,double b)
        { 
            return(a+b);
        }
        private double tru(double a, double b)
        {
            return (a - b);
        }
        private double nhan(double a, double b)
        {
            return (a * b);
        }
        private double chia(double a, double b)
        {
            return (a / b);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(cong(a,b));
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(tru(a, b));
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(nhan(a, b));
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(chia(a, b));
            label8.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            label6.Text = button3.Text;
        }

        private void Code__Load(object sender, EventArgs e)
        {
            invi();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

 
        }

        private void button5_Click(object sender, EventArgs e)
        {
    
        }

    }
}
