namespace PhepToan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_cong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.r_tru = new System.Windows.Forms.RadioButton();
            this.r_nhan = new System.Windows.Forms.RadioButton();
            this.r_chia = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_so1
            // 
            this.txt_so1.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_so1.Location = new System.Drawing.Point(86, 29);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(136, 20);
            this.txt_so1.TabIndex = 0;
            this.txt_so1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(88, 75);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(134, 20);
            this.txt_so2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sothu2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sothu1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // r_cong
            // 
            this.r_cong.AutoSize = true;
            this.r_cong.Location = new System.Drawing.Point(134, 133);
            this.r_cong.Name = "r_cong";
            this.r_cong.Size = new System.Drawing.Size(50, 17);
            this.r_cong.TabIndex = 6;
            this.r_cong.TabStop = true;
            this.r_cong.Text = "Cong";
            this.r_cong.UseVisualStyleBackColor = true;
            this.r_cong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn Phép Tính";
            // 
            // r_tru
            // 
            this.r_tru.AutoSize = true;
            this.r_tru.Location = new System.Drawing.Point(185, 133);
            this.r_tru.Name = "r_tru";
            this.r_tru.Size = new System.Drawing.Size(41, 17);
            this.r_tru.TabIndex = 8;
            this.r_tru.TabStop = true;
            this.r_tru.Text = "Tru";
            this.r_tru.UseVisualStyleBackColor = true;
            // 
            // r_nhan
            // 
            this.r_nhan.AutoSize = true;
            this.r_nhan.Location = new System.Drawing.Point(232, 133);
            this.r_nhan.Name = "r_nhan";
            this.r_nhan.Size = new System.Drawing.Size(51, 17);
            this.r_nhan.TabIndex = 9;
            this.r_nhan.TabStop = true;
            this.r_nhan.Text = "Nhan";
            this.r_nhan.UseVisualStyleBackColor = true;
            // 
            // r_chia
            // 
            this.r_chia.AutoSize = true;
            this.r_chia.Location = new System.Drawing.Point(289, 133);
            this.r_chia.Name = "r_chia";
            this.r_chia.Size = new System.Drawing.Size(46, 17);
            this.r_chia.TabIndex = 10;
            this.r_chia.TabStop = true;
            this.r_chia.Text = "Chia";
            this.r_chia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dapso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(86, 169);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(135, 20);
            this.txt_ketqua.TabIndex = 12;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 266);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.r_chia);
            this.Controls.Add(this.r_nhan);
            this.Controls.Add(this.r_tru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.r_cong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_so1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton r_cong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton r_tru;
        private System.Windows.Forms.RadioButton r_nhan;
        private System.Windows.Forms.RadioButton r_chia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

