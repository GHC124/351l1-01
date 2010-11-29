using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCong_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txt1.Text);
            double so2 = double.Parse(txt2.Text);

            txtkq.Text = (so1 + so2).ToString();
        }

        private void butTru_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txt1.Text);
            double so2 = double.Parse(txt2.Text);

            txtkq.Text = (so1 - so2).ToString();
        }

        private void butNhan_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txt1.Text);
            double so2 = double.Parse(txt2.Text);

            txtkq.Text = (so1 * so2).ToString();
        }

        private void butChia_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txt1.Text);
            double so2 = double.Parse(txt2.Text);

            txtkq.Text = (so1 / so2).ToString();
        }
    }
}
