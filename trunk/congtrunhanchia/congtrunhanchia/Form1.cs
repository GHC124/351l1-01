using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace congtrunhanchia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.txb_so1.Text, out n) && int.TryParse(this.txb_so2.Text, out n))
            {
                txb_ketqua.Text = Convert.ToString(Convert.ToDouble(txb_so1.Text) + Convert.ToDouble(txb_so2.Text));
            }
            else MessageBox.Show("moi nhap lai so");
            txb_so1.Clear();
            txb_so2.Clear();
        }

        private void bt_tru_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.txb_so1.Text, out n) && int.TryParse(this.txb_so2.Text, out n))
            {
                txb_ketqua.Text = Convert.ToString(Convert.ToDouble(txb_so1.Text) - Convert.ToDouble(txb_so2.Text));
            }
            else MessageBox.Show("moi nhap lai so");
            txb_so1.Clear();
            txb_so2.Clear();
        }

        private void bt_nhan_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.txb_so1.Text, out n) && int.TryParse(this.txb_so2.Text, out n))
            {
                txb_ketqua.Text = Convert.ToString(Convert.ToDouble(txb_so1.Text) * Convert.ToDouble(txb_so2.Text));
            }
            else MessageBox.Show("moi nhap lai so");
            txb_so1.Clear();
            txb_so2.Clear();
        }

        private void bt_chia_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.txb_so1.Text, out n) && int.TryParse(this.txb_so2.Text, out n))
            {
                txb_ketqua.Text = Convert.ToString(Convert.ToDouble(txb_so1.Text) / Convert.ToDouble(txb_so2.Text));
            }
            else MessageBox.Show("moi nhap lai so");
            txb_so1.Clear();
            txb_so2.Clear();
        }
    }
}
