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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         public bool check(string a)
        {
            for (int i = 0; i < a.Length; i++)
                if (!char.IsDigit(a[i])&&a[i]!='.')
                    return false;
            return true;
        
        }
        private void r_cong_CheckedChanged(object sender, EventArgs e)
        {
            
            if (r_cong.Checked == true)
            {
                if (check(txt_so1.Text) == false || check(txt_so2.Text) == false)
                    MessageBox.Show("ban vui long nhap so ");
                else
                {
                    if (txt_so1.Text == "" || txt_so2.Text == "")
                        MessageBox.Show("ban chua nhap so");
                    else
                        txt_ketqua.Text = Convert.ToString(Convert.ToDouble(txt_so1.Text) + Convert.ToDouble(txt_so2.Text));
                }
            }
        }

        private void r_chia_CheckedChanged(object sender, EventArgs e)
        {
            if (r_chia.Checked == true)
            {
                if (check(txt_so1.Text) == false || check(txt_so2.Text) == false)
                    MessageBox.Show("ban vui long nhap so ");
                else
                {
                    if (txt_so1.Text == "" || txt_so2.Text == "")
                        MessageBox.Show("ban chua nhap so");
                    else
                        if (Convert.ToDouble(txt_so2.Text) == 0)
                        {
                            if (r_chia.Checked == true)
                                MessageBox.Show("ko the tinh dc");
                        }
                        else
                            txt_ketqua.Text = Convert.ToString(Convert.ToDouble(txt_so1.Text) / Convert.ToDouble(txt_so2.Text));


                }
            }
        }

        private void r_tru_CheckedChanged(object sender, EventArgs e)
        {
            
            if (r_tru.Checked == true)
            {
                if (check(txt_so1.Text) == false || check(txt_so2.Text) == false)
                    MessageBox.Show("ban vui long nhap so ");
                else
                {
                    if (txt_so1.Text == "" || txt_so2.Text == "")
                        MessageBox.Show("ban chua nhap so");
                    else
                        txt_ketqua.Text = Convert.ToString(Convert.ToDouble(txt_so1.Text) - Convert.ToDouble(txt_so2.Text));
                }
            }
        }

        private void r_nhan_CheckedChanged(object sender, EventArgs e)
        {
            if (r_nhan.Checked == true)
            {
                if (check(txt_so1.Text) == false || check(txt_so2.Text) == false)
                    MessageBox.Show("ban vui long nhap so ");
                else
                {
                    if (txt_so1.Text == "" || txt_so2.Text == "")
                        MessageBox.Show("ban chua nhap so");
                    else
                        txt_ketqua.Text = Convert.ToString(Convert.ToDouble(txt_so1.Text) * Convert.ToDouble(txt_so2.Text));
                }
            }
        }

        private void txt_so1_TextChanged(object sender, EventArgs e)
        {
            if (check(txt_so1.Text) == false )
                errorProvider1.SetError(txt_so1,"ban vui long nhap so ");
            else
            {
                if (txt_so1.Text == "" )
                    errorProvider1.SetError(txt_so1,"ban chua nhap so");
                else
                    errorProvider1.Clear();
            }
        }

        private void txt_so2_TextChanged(object sender, EventArgs e)
        {
             if (check(txt_so2.Text) == false )
                errorProvider1.SetError(txt_so2, "ban vui long nhap so ");
            else
            {
                if (txt_so2.Text == "")
                    errorProvider1.SetError(txt_so2, "ban chua nhap so");
                else
                    errorProvider1.Clear();
            }
        }

        private void so1(object sender, EventArgs e)
        {

        }
    }
}
 

        


        

       


       

        
       