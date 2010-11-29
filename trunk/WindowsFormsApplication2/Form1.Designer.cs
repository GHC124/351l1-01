namespace WindowsFormsApplication2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbsoa = new System.Windows.Forms.TextBox();
            this.rbcong = new System.Windows.Forms.RadioButton();
            this.rbtru = new System.Windows.Forms.RadioButton();
            this.rbnhan = new System.Windows.Forms.RadioButton();
            this.rbchia = new System.Windows.Forms.RadioButton();
            this.txbsob = new System.Windows.Forms.TextBox();
            this.btketqua = new System.Windows.Forms.Button();
            this.txbketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "so a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "so b";
            // 
            // txbsoa
            // 
            this.txbsoa.Location = new System.Drawing.Point(130, 16);
            this.txbsoa.Name = "txbsoa";
            this.txbsoa.Size = new System.Drawing.Size(100, 20);
            this.txbsoa.TabIndex = 2;
            // 
            // rbcong
            // 
            this.rbcong.AutoSize = true;
            this.rbcong.Checked = true;
            this.rbcong.Location = new System.Drawing.Point(417, 19);
            this.rbcong.Name = "rbcong";
            this.rbcong.Size = new System.Drawing.Size(49, 17);
            this.rbcong.TabIndex = 3;
            this.rbcong.TabStop = true;
            this.rbcong.Text = "cong";
            this.rbcong.UseVisualStyleBackColor = true;
            // 
            // rbtru
            // 
            this.rbtru.AutoSize = true;
            this.rbtru.Location = new System.Drawing.Point(417, 71);
            this.rbtru.Name = "rbtru";
            this.rbtru.Size = new System.Drawing.Size(37, 17);
            this.rbtru.TabIndex = 4;
            this.rbtru.Text = "tru";
            this.rbtru.UseVisualStyleBackColor = true;
            // 
            // rbnhan
            // 
            this.rbnhan.AutoSize = true;
            this.rbnhan.Location = new System.Drawing.Point(417, 106);
            this.rbnhan.Name = "rbnhan";
            this.rbnhan.Size = new System.Drawing.Size(49, 17);
            this.rbnhan.TabIndex = 5;
            this.rbnhan.Text = "nhan";
            this.rbnhan.UseVisualStyleBackColor = true;
            // 
            // rbchia
            // 
            this.rbchia.AutoSize = true;
            this.rbchia.Location = new System.Drawing.Point(417, 158);
            this.rbchia.Name = "rbchia";
            this.rbchia.Size = new System.Drawing.Size(45, 17);
            this.rbchia.TabIndex = 6;
            this.rbchia.Text = "chia";
            this.rbchia.UseVisualStyleBackColor = true;
            // 
            // txbsob
            // 
            this.txbsob.Location = new System.Drawing.Point(130, 75);
            this.txbsob.Name = "txbsob";
            this.txbsob.Size = new System.Drawing.Size(100, 20);
            this.txbsob.TabIndex = 7;
            // 
            // btketqua
            // 
            this.btketqua.Location = new System.Drawing.Point(26, 190);
            this.btketqua.Name = "btketqua";
            this.btketqua.Size = new System.Drawing.Size(75, 23);
            this.btketqua.TabIndex = 8;
            this.btketqua.Text = "ket qua";
            this.btketqua.UseVisualStyleBackColor = true;
            this.btketqua.Click += new System.EventHandler(this.btketqua_Click);
            // 
            // txbketqua
            // 
            this.txbketqua.Location = new System.Drawing.Point(130, 123);
            this.txbketqua.Name = "txbketqua";
            this.txbketqua.Size = new System.Drawing.Size(100, 20);
            this.txbketqua.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "dap so";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(167, 189);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 11;
            this.btthoat.Text = "thoat";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbketqua);
            this.Controls.Add(this.btketqua);
            this.Controls.Add(this.txbsob);
            this.Controls.Add(this.rbchia);
            this.Controls.Add(this.rbnhan);
            this.Controls.Add(this.rbtru);
            this.Controls.Add(this.rbcong);
            this.Controls.Add(this.txbsoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbsoa;
        private System.Windows.Forms.RadioButton rbcong;
        private System.Windows.Forms.RadioButton rbtru;
        private System.Windows.Forms.RadioButton rbnhan;
        private System.Windows.Forms.RadioButton rbchia;
        private System.Windows.Forms.TextBox txbsob;
        private System.Windows.Forms.Button btketqua;
        private System.Windows.Forms.TextBox txbketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btthoat;
    }
}

