using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                dapso.Text = (decimal.Parse(n1.Text) + decimal.Parse(n2.Text)).ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dapso.Text = (decimal.Parse(n1.Text) - decimal.Parse(n2.Text)).ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dapso.Text = (decimal.Parse(n1.Text) * decimal.Parse(n2.Text)).ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dapso.Text = (decimal.Parse(n1.Text) / decimal.Parse(n2.Text)).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            dapso.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
