namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.txt_so2 = new System.Windows.Forms.TextBox();
            this.txt_ketqua = new System.Windows.Forms.TextBox();
            this.r_cong = new System.Windows.Forms.RadioButton();
            this.r_tru = new System.Windows.Forms.RadioButton();
            this.r_nhan = new System.Windows.Forms.RadioButton();
            this.r_chia = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_so1
            // 
            this.txt_so1.Location = new System.Drawing.Point(127, 13);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.Size = new System.Drawing.Size(100, 20);
            this.txt_so1.TabIndex = 0;
            this.txt_so1.TextChanged += new System.EventHandler(this.txt_so1_TextChanged);
            // 
            // txt_so2
            // 
            this.txt_so2.Location = new System.Drawing.Point(127, 65);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.Size = new System.Drawing.Size(100, 20);
            this.txt_so2.TabIndex = 1;
            this.txt_so2.TextChanged += new System.EventHandler(this.txt_so2_TextChanged);
            // 
            // txt_ketqua
            // 
            this.txt_ketqua.Location = new System.Drawing.Point(127, 193);
            this.txt_ketqua.Name = "txt_ketqua";
            this.txt_ketqua.Size = new System.Drawing.Size(100, 20);
            this.txt_ketqua.TabIndex = 2;
            // 
            // r_cong
            // 
            this.r_cong.AutoSize = true;
            this.r_cong.Location = new System.Drawing.Point(92, 123);
            this.r_cong.Name = "r_cong";
            this.r_cong.Size = new System.Drawing.Size(50, 17);
            this.r_cong.TabIndex = 3;
            this.r_cong.TabStop = true;
            this.r_cong.Text = "Cong";
            this.r_cong.UseVisualStyleBackColor = true;
            this.r_cong.CheckedChanged += new System.EventHandler(this.r_cong_CheckedChanged);
            // 
            // r_tru
            // 
            this.r_tru.AutoSize = true;
            this.r_tru.Location = new System.Drawing.Point(148, 123);
            this.r_tru.Name = "r_tru";
            this.r_tru.Size = new System.Drawing.Size(41, 17);
            this.r_tru.TabIndex = 4;
            this.r_tru.TabStop = true;
            this.r_tru.Text = "Tru";
            this.r_tru.UseVisualStyleBackColor = true;
            this.r_tru.CheckedChanged += new System.EventHandler(this.r_tru_CheckedChanged);
            // 
            // r_nhan
            // 
            this.r_nhan.AutoSize = true;
            this.r_nhan.Location = new System.Drawing.Point(195, 123);
            this.r_nhan.Name = "r_nhan";
            this.r_nhan.Size = new System.Drawing.Size(51, 17);
            this.r_nhan.TabIndex = 5;
            this.r_nhan.TabStop = true;
            this.r_nhan.Text = "Nhan";
            this.r_nhan.UseVisualStyleBackColor = true;
            this.r_nhan.CheckedChanged += new System.EventHandler(this.r_nhan_CheckedChanged);
            // 
            // r_chia
            // 
            this.r_chia.AutoSize = true;
            this.r_chia.Location = new System.Drawing.Point(256, 123);
            this.r_chia.Name = "r_chia";
            this.r_chia.Size = new System.Drawing.Size(46, 17);
            this.r_chia.TabIndex = 6;
            this.r_chia.TabStop = true;
            this.r_chia.Text = "Chia";
            this.r_chia.UseVisualStyleBackColor = true;
            this.r_chia.CheckedChanged += new System.EventHandler(this.r_chia_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sothu1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sothu2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dapso";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r_chia);
            this.Controls.Add(this.r_nhan);
            this.Controls.Add(this.r_tru);
            this.Controls.Add(this.r_cong);
            this.Controls.Add(this.txt_ketqua);
            this.Controls.Add(this.txt_so2);
            this.Controls.Add(this.txt_so1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_so1;
        private System.Windows.Forms.TextBox txt_so2;
        private System.Windows.Forms.TextBox txt_ketqua;
        private System.Windows.Forms.RadioButton r_cong;
        private System.Windows.Forms.RadioButton r_tru;
        private System.Windows.Forms.RadioButton r_nhan;
        private System.Windows.Forms.RadioButton r_chia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}