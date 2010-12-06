using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace maytinhdongian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toantu1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "cộng")
                ketqua.Text = (int.Parse(toantu1.Text) + int.Parse(toantu2.Text)).ToString();
            else if (comboBox1.SelectedItem == "trừ")
                ketqua.Text = (int.Parse(toantu1.Text) - int.Parse(toantu2.Text)).ToString();
            else if (comboBox1.SelectedItem == "nhân")
                ketqua.Text = (int.Parse(toantu1.Text) * int.Parse(toantu2.Text)).ToString();
            else if (comboBox1.SelectedItem == "chia")
            {
                ketqua.Text = (float.Parse(toantu1.Text) / float.Parse(toantu2.Text)).ToString();
                if (ketqua.Text == "Infinity")
                    ketqua.Text = "data invalid";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
