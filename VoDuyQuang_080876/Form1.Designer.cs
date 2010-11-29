namespace VoDuyQuang_080876
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
            this.butChia = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butNhan = new System.Windows.Forms.Button();
            this.butCong = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.butTru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butChia
            // 
            this.butChia.Location = new System.Drawing.Point(299, 192);
            this.butChia.Name = "butChia";
            this.butChia.Size = new System.Drawing.Size(63, 31);
            this.butChia.TabIndex = 22;
            this.butChia.Text = "/";
            this.butChia.UseVisualStyleBackColor = true;
            this.butChia.Click += new System.EventHandler(this.butChia_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(84, 203);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(185, 20);
            this.txtkq.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "kết quả";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(84, 102);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(185, 20);
            this.txt2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "số thứ 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "số thứ 1";
            // 
            // butNhan
            // 
            this.butNhan.Location = new System.Drawing.Point(299, 145);
            this.butNhan.Name = "butNhan";
            this.butNhan.Size = new System.Drawing.Size(63, 31);
            this.butNhan.TabIndex = 16;
            this.butNhan.Text = "*";
            this.butNhan.UseVisualStyleBackColor = true;
            this.butNhan.Click += new System.EventHandler(this.butNhan_Click);
            // 
            // butCong
            // 
            this.butCong.Location = new System.Drawing.Point(299, 38);
            this.butCong.Name = "butCong";
            this.butCong.Size = new System.Drawing.Size(63, 31);
            this.butCong.TabIndex = 15;
            this.butCong.Text = "+";
            this.butCong.UseVisualStyleBackColor = true;
            this.butCong.Click += new System.EventHandler(this.butCong_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(84, 44);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(185, 20);
            this.txt1.TabIndex = 14;
            // 
            // butTru
            // 
            this.butTru.Location = new System.Drawing.Point(299, 91);
            this.butTru.Name = "butTru";
            this.butTru.Size = new System.Drawing.Size(63, 31);
            this.butTru.TabIndex = 13;
            this.butTru.Text = "-";
            this.butTru.UseVisualStyleBackColor = true;
            this.butTru.Click += new System.EventHandler(this.butTru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 271);
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

        private System.Windows.Forms.Button butChia;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butNhan;
        private System.Windows.Forms.Button butCong;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button butTru;
    }
}

