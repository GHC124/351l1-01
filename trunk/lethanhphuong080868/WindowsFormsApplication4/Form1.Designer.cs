namespace WindowsFormsApplication4
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
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.cbbtoan = new System.Windows.Forms.ComboBox();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtresuft = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(12, 35);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(48, 13);
            this.number1.TabIndex = 0;
            this.number1.Text = "number1";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Location = new System.Drawing.Point(12, 91);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(48, 13);
            this.number2.TabIndex = 1;
            this.number2.Text = "number2";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(68, 32);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 20);
            this.txtnumber1.TabIndex = 2;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(68, 88);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 20);
            this.txtnumber2.TabIndex = 3;
            // 
            // cbbtoan
            // 
            this.cbbtoan.FormattingEnabled = true;
            this.cbbtoan.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbbtoan.Location = new System.Drawing.Point(227, 40);
            this.cbbtoan.Name = "cbbtoan";
            this.cbbtoan.Size = new System.Drawing.Size(121, 21);
            this.cbbtoan.TabIndex = 4;
            // 
            // btnthuchien
            // 
            this.btnthuchien.Location = new System.Drawing.Point(27, 178);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(75, 23);
            this.btnthuchien.TabIndex = 5;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(273, 178);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtresuft
            // 
            this.txtresuft.AutoSize = true;
            this.txtresuft.Location = new System.Drawing.Point(12, 138);
            this.txtresuft.Name = "txtresuft";
            this.txtresuft.Size = new System.Drawing.Size(44, 13);
            this.txtresuft.TabIndex = 7;
            this.txtresuft.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(79, 135);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 8;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(163, 178);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Xóa";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtresuft);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.cbbtoan);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.ComboBox cbbtoan;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label txtresuft;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnclear;
    }
}

