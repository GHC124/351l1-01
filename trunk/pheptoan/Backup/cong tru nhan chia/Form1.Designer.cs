namespace cong_tru_nhan_chia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_so1 = new System.Windows.Forms.TextBox();
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.r_cong = new System.Windows.Forms.RadioButton();
            this.r_tru = new System.Windows.Forms.RadioButton();
            this.r_nhan = new System.Windows.Forms.RadioButton();
            this.r_chia = new System.Windows.Forms.RadioButton();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "so 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ket qua";
            // 
            // txt_so1
            // 
            this.txt_so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so1.Location = new System.Drawing.Point(111, 32);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(179, 30);
            this.txt_so1.TabIndex = 1;
            this.txt_so1.TextChanged += new System.EventHandler(this.txt_so1_TextChanged);
            // 
            // txt_so2
            // 
            this.txt_so2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so2.Location = new System.Drawing.Point(111, 86);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(179, 30);
            this.txt_so2.TabIndex = 1;
            this.txt_so2.TextChanged += new System.EventHandler(this.txt_so2_TextChanged);
            // 
            // r_cong
            // 
            this.r_cong.AutoSize = true;
            this.r_cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_cong.Location = new System.Drawing.Point(16, 19);
            this.r_cong.Name = "r_cong";
            this.r_cong.Size = new System.Drawing.Size(73, 29);
            this.r_cong.TabIndex = 2;
            this.r_cong.Text = "cong";
            this.r_cong.UseVisualStyleBackColor = true;
            this.r_cong.CheckedChanged += new System.EventHandler(this.r_cong_CheckedChanged);
            // 
            // r_tru
            // 
            this.r_tru.AutoSize = true;
            this.r_tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_tru.Location = new System.Drawing.Point(153, 19);
            this.r_tru.Name = "r_tru";
            this.r_tru.Size = new System.Drawing.Size(52, 29);
            this.r_tru.TabIndex = 2;
            this.r_tru.Text = "tru";
            this.r_tru.UseVisualStyleBackColor = true;
            this.r_tru.CheckedChanged += new System.EventHandler(this.r_tru_CheckedChanged);
            // 
            // r_nhan
            // 
            this.r_nhan.AutoSize = true;
            this.r_nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_nhan.Location = new System.Drawing.Point(296, 19);
            this.r_nhan.Name = "r_nhan";
            this.r_nhan.Size = new System.Drawing.Size(74, 29);
            this.r_nhan.TabIndex = 2;
            this.r_nhan.Text = "nhan";
            this.r_nhan.UseVisualStyleBackColor = true;
            this.r_nhan.CheckedChanged += new System.EventHandler(this.r_nhan_CheckedChanged);
            // 
            // r_chia
            // 
            this.r_chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_chia.Location = new System.Drawing.Point(442, 19);
            this.r_chia.Name = "r_chia";
            this.r_chia.Size = new System.Drawing.Size(66, 29);
            this.r_chia.TabIndex = 2;
            this.r_chia.Text = "chia";
            this.r_chia.UseVisualStyleBackColor = true;
            this.r_chia.CheckedChanged += new System.EventHandler(this.r_chia_CheckedChanged);
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ketqua.Location = new System.Drawing.Point(111, 205);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(179, 30);
            this.txt_ketqua.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "so 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_chia);
            this.groupBox1.Controls.Add(this.r_nhan);
            this.groupBox1.Controls.Add(this.r_tru);
            this.groupBox1.Controls.Add(this.r_cong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 63);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phép tính";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.RadioButton r_cong;
        private System.Windows.Forms.RadioButton r_tru;
        private System.Windows.Forms.RadioButton r_nhan;
        private System.Windows.Forms.RadioButton r_chia;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

