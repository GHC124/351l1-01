namespace Calculator
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
            this.butTru = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.butCong = new System.Windows.Forms.Button();
            this.butNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.butChia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butTru
            // 
            this.butTru.Location = new System.Drawing.Point(289, 82);
            this.butTru.Name = "butTru";
            this.butTru.Size = new System.Drawing.Size(63, 31);
            this.butTru.TabIndex = 0;
            this.butTru.Text = "-";
            this.butTru.UseVisualStyleBackColor = true;
            this.butTru.Click += new System.EventHandler(this.butTru_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(74, 35);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(185, 20);
            this.txt1.TabIndex = 1;
            // 
            // butCong
            // 
            this.butCong.Location = new System.Drawing.Point(289, 29);
            this.butCong.Name = "butCong";
            this.butCong.Size = new System.Drawing.Size(63, 31);
            this.butCong.TabIndex = 3;
            this.butCong.Text = "+";
            this.butCong.UseVisualStyleBackColor = true;
            this.butCong.Click += new System.EventHandler(this.butCong_Click);
            // 
            // butNhan
            // 
            this.butNhan.Location = new System.Drawing.Point(289, 136);
            this.butNhan.Name = "butNhan";
            this.butNhan.Size = new System.Drawing.Size(63, 31);
            this.butNhan.TabIndex = 4;
            this.butNhan.Text = "*";
            this.butNhan.UseVisualStyleBackColor = true;
            this.butNhan.Click += new System.EventHandler(this.butNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "số thứ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "số thứ 2";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(74, 93);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(185, 20);
            this.txt2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "kết quả";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(74, 194);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(185, 20);
            this.txtkq.TabIndex = 11;
            // 
            // butChia
            // 
            this.butChia.Location = new System.Drawing.Point(289, 183);
            this.butChia.Name = "butChia";
            this.butChia.Size = new System.Drawing.Size(63, 31);
            this.butChia.TabIndex = 12;
            this.butChia.Text = "/";
            this.butChia.UseVisualStyleBackColor = true;
            this.butChia.Click += new System.EventHandler(this.butChia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 246);
            this.Controls.Add(this.butChia);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butNhan);
            this.Controls.Add(this.butCong);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.butTru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butTru;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button butCong;
        private System.Windows.Forms.Button butNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button butChia;
    }
}

