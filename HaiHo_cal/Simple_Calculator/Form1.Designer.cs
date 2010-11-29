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
            this.frmtinhkq = new System.Windows.Forms.Button();
            this.frmthoat = new System.Windows.Forms.Button();
            this.cbbpheptinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.txtketqua.Location = new System.Drawing.Point(94, 69);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(100, 20);
            this.txtketqua.TabIndex = 2;
            // 
            // txtsohang2
            // 
            this.txtsohang2.Location = new System.Drawing.Point(94, 43);
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
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "So thu hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ket qua";
            // 
            // frmtinhkq
            // 
            this.frmtinhkq.Location = new System.Drawing.Point(13, 133);
            this.frmtinhkq.Name = "frmtinhkq";
            this.frmtinhkq.Size = new System.Drawing.Size(75, 25);
            this.frmtinhkq.TabIndex = 11;
            this.frmtinhkq.Text = "Tinh";
            this.frmtinhkq.UseVisualStyleBackColor = true;
            this.frmtinhkq.Click += new System.EventHandler(this.frmtinhkq_Click);
            // 
            // frmthoat
            // 
            this.frmthoat.Location = new System.Drawing.Point(136, 133);
            this.frmthoat.Name = "frmthoat";
            this.frmthoat.Size = new System.Drawing.Size(75, 25);
            this.frmthoat.TabIndex = 12;
            this.frmthoat.Text = "Thoat";
            this.frmthoat.UseVisualStyleBackColor = true;
            this.frmthoat.Click += new System.EventHandler(this.frmthoat_Click);
            // 
            // cbbpheptinh
            // 
            this.cbbpheptinh.FormattingEnabled = true;
            this.cbbpheptinh.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbbpheptinh.Location = new System.Drawing.Point(94, 95);
            this.cbbpheptinh.Name = "cbbpheptinh";
            this.cbbpheptinh.Size = new System.Drawing.Size(121, 22);
            this.cbbpheptinh.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phép tính";
            // 
            // frmTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 210);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbpheptinh);
            this.Controls.Add(this.frmthoat);
            this.Controls.Add(this.frmtinhkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsohang2);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsohang1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTinh";
            this.Text = "Chuong Trinh May Tinh";
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
        private System.Windows.Forms.Button frmtinhkq;
        private System.Windows.Forms.Button frmthoat;
        private System.Windows.Forms.ComboBox cbbpheptinh;
        private System.Windows.Forms.Label label4;
    }
}

