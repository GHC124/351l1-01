namespace Simple_Calculator
{
    partial class frmTinh
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
            this.txtsohang1 = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.txtsohang2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbCong = new System.Windows.Forms.RadioButton();
            this.rdbChia = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.rdbTru = new System.Windows.Forms.RadioButton();
            this.gbpheptinh = new System.Windows.Forms.GroupBox();
            this.frmtinhkq = new System.Windows.Forms.Button();
            this.frmthoat = new System.Windows.Forms.Button();
            this.gbpheptinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsohang1
            // 
            this.txtsohang1.Location = new System.Drawing.Point(94, 14);
            this.txtsohang1.Name = "txtsohang1";
            this.txtsohang1.Size = new System.Drawing.Size(100, 20);
            this.txtsohang1.TabIndex = 0;
            // 
            // txtketqua
            // 
            this.txtketqua.Enabled = false;
            this.txtketqua.ForeColor = System.Drawing.Color.Red;
            this.txtketqua.Location = new System.Drawing.Point(94, 117);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 2;
            // 
            // txtsohang2
            // 
            this.txtsohang2.Location = new System.Drawing.Point(94, 64);
            this.txtsohang2.Name = "txtsohang2";
            this.txtsohang2.Size = new System.Drawing.Size(100, 20);
            this.txtsohang2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "So thu nhat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "So thu hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // rdbCong
            // 
            this.rdbCong.AutoSize = true;
            this.rdbCong.Checked = true;
            this.rdbCong.Location = new System.Drawing.Point(6, 20);
            this.rdbCong.Name = "rdbCong";
            this.rdbCong.Size = new System.Drawing.Size(50, 18);
            this.rdbCong.TabIndex = 6;
            this.rdbCong.TabStop = true;
            this.rdbCong.Text = "Cong";
            this.rdbCong.UseVisualStyleBackColor = true;
            // 
            // rdbChia
            // 
            this.rdbChia.AutoSize = true;
            this.rdbChia.Location = new System.Drawing.Point(6, 95);
            this.rdbChia.Name = "rdbChia";
            this.rdbChia.Size = new System.Drawing.Size(46, 18);
            this.rdbChia.TabIndex = 7;
            this.rdbChia.Text = "Chia";
            this.rdbChia.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Location = new System.Drawing.Point(6, 70);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(50, 18);
            this.rdbNhan.TabIndex = 8;
            this.rdbNhan.Text = "Nhan";
            this.rdbNhan.UseVisualStyleBackColor = true;
            // 
            // rdbTru
            // 
            this.rdbTru.AutoSize = true;
            this.rdbTru.Location = new System.Drawing.Point(6, 45);
            this.rdbTru.Name = "rdbTru";
            this.rdbTru.Size = new System.Drawing.Size(41, 18);
            this.rdbTru.TabIndex = 9;
            this.rdbTru.Text = "Tru";
            this.rdbTru.UseVisualStyleBackColor = true;
            // 
            // gbpheptinh
            // 
            this.gbpheptinh.Controls.Add(this.rdbCong);
            this.gbpheptinh.Controls.Add(this.rdbTru);
            this.gbpheptinh.Controls.Add(this.rdbChia);
            this.gbpheptinh.Controls.Add(this.rdbNhan);
            this.gbpheptinh.Location = new System.Drawing.Point(217, 17);
            this.gbpheptinh.Name = "gbpheptinh";
            this.gbpheptinh.Size = new System.Drawing.Size(97, 124);
            this.gbpheptinh.TabIndex = 10;
            this.gbpheptinh.TabStop = false;
            this.gbpheptinh.Text = "Phep Tinh";
            // 
            // frmtinhkq
            // 
            this.frmtinhkq.Location = new System.Drawing.Point(63, 173);
            this.frmtinhkq.Name = "frmtinhkq";
            this.frmtinhkq.Size = new System.Drawing.Size(75, 25);
            this.frmtinhkq.TabIndex = 11;
            this.frmtinhkq.Text = "Tinh";
            this.frmtinhkq.UseVisualStyleBackColor = true;
            this.frmtinhkq.Click += new System.EventHandler(this.frmtinhkq_Click);
            // 
            // frmthoat
            // 
            this.frmthoat.Location = new System.Drawing.Point(186, 173);
            this.frmthoat.Name = "frmthoat";
            this.frmthoat.Size = new System.Drawing.Size(75, 25);
            this.frmthoat.TabIndex = 12;
            this.frmthoat.Text = "Thoat";
            this.frmthoat.UseVisualStyleBackColor = true;
            this.frmthoat.Click += new System.EventHandler(this.frmthoat_Click);
            // 
            // frmTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 210);
            this.Controls.Add(this.frmthoat);
            this.Controls.Add(this.frmtinhkq);
            this.Controls.Add(this.gbpheptinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsohang2);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsohang1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTinh";
            this.Text = "Chuong Trinh May Tinh";
            this.gbpheptinh.ResumeLayout(false);
            this.gbpheptinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsohang1;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.TextBox txtsohang2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbCong;
        private System.Windows.Forms.RadioButton rdbChia;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.RadioButton rdbTru;
        private System.Windows.Forms.GroupBox gbpheptinh;
        private System.Windows.Forms.Button frmtinhkq;
        private System.Windows.Forms.Button frmthoat;
    }
}

