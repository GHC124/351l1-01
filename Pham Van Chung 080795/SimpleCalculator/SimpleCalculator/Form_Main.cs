using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BieuThuc_BUS;

namespace SimpleCalculartor
{
    public partial class Form_Main : Form
    {
        private BieuThuc bieuthuc;

        public Form_Main()
        {
            InitializeComponent();

            //cơ bản
            this.button0.Click+=new EventHandler(button_Click);
            this.button1.Click += new EventHandler(button_Click);
            this.button2.Click += new EventHandler(button_Click);
            this.button3.Click += new EventHandler(button_Click);
            this.button4.Click += new EventHandler(button_Click);
            this.button5.Click += new EventHandler(button_Click);
            this.button6.Click += new EventHandler(button_Click);
            this.button7.Click += new EventHandler(button_Click);
            this.button8.Click += new EventHandler(button_Click);
            this.button9.Click += new EventHandler(button_Click);
            this.button_Phay.Click += new EventHandler(button_Click);
            this.button_Cong.Click += new EventHandler(button_Click);
            this.button_Tru.Click += new EventHandler(button_Click);
            this.button_Nhan.Click += new EventHandler(button_Click);
            this.button_Chia.Click += new EventHandler(button_Click);
            this.button_NgoacPhai.Click += new EventHandler(button_Click);
            this.button_NgoacTrai.Click += new EventHandler(button_Click);
            this.buttonC.Click+=new EventHandler(button_Click);
            this.button_Clear.Click+=new EventHandler(button_Click);
            this.button_KetQua.Click += new EventHandler(button_Click);

            //nâng cao
            this.button_Abs.Click+=new EventHandler(button_Click);
            this.button_Sin.Click += new EventHandler(button_Click);
            this.button_Cos.Click += new EventHandler(button_Click);
            this.button_Tan.Click += new EventHandler(button_Click);
            this.button_Pi.Click += new EventHandler(button_Click);
            this.button_E.Click += new EventHandler(button_Click);
            this.button_Lg.Click += new EventHandler(button_Click);
            this.button_GiaiThua.Click += new EventHandler(button_Click);
            this.button_Mu.Click += new EventHandler(button_Click);
            this.button_Mod.Click += new EventHandler(button_Click);
            this.button_BangBang.Click += new EventHandler(button_Click);
            this.button_NhoHon.Click += new EventHandler(button_Click);
            this.button_NhoHonHoacBang.Click += new EventHandler(button_Click);
            this.button_LonHon.Click += new EventHandler(button_Click);
            this.button_LonHonHoacBang.Click += new EventHandler(button_Click);
            
            bieuthuc = new BieuThuc();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            switch (bt.Name)
            {
                case "button0": 
                case "button1": 
                case "button2": 
                case "button3": 
                case "button4": 
                case "button5": 
                case "button6": 
                case "button7": 
                case "button8": 
                case "button9": 
                case "button_NgoacPhai":
                case "button_NgoacTrai":
                case "button_Abs":
                case "button_Sin":
                case "button_Cos":
                case "button_Tan":
                case "button_Lg":
                case "button_Pi":
                case "button_E":
                    if (this.textBox_BieuThuc.Text == "0") this.textBox_BieuThuc.Text = bt.Text;
                    else this.textBox_BieuThuc.Text += bt.Text;
                    break;
                case "button_Cong":
                case "button_Tru":
                case "button_Nhan":
                case "button_Chia":
                case "button_Mu":
                case "button_Mod":
                case "button_GiaiThua":
                case "button_NhoHon":
                case "button_NhoHonHoacBang":
                case "button_LonHon":
                case "button_LonHonHoacBang":
                case "button_Phay":
                    if (this.textBox_BieuThuc.Text == "0") this.textBox_BieuThuc.Text = "0" + bt.Text;
                    else this.textBox_BieuThuc.Text += bt.Text;
                    break;
                case "button_BangBang":
                    if (this.textBox_BieuThuc.Text == "0") this.textBox_BieuThuc.Text = "=";
                    else this.textBox_BieuThuc.Text += "=";
                    break;
                case "buttonC": this.textBox_BieuThuc.Text = "0";
                    break;
                case "button_Clear":
                    if (this.textBox_BieuThuc.Text.Length > 1)
                        this.textBox_BieuThuc.Text = this.textBox_BieuThuc.Text.Remove(this.textBox_BieuThuc.Text.Length - 1);
                    else this.textBox_BieuThuc.Text = "0";
                    break;
                case "button_KetQua":
                    bieuthuc.BT = this.textBox_BieuThuc.Text;
                    this.textBox_KetQua.Text = bieuthuc.GiaTri();
                    break;
            }
        }

     
    }
}