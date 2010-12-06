namespace congtrunhanchia
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
            this.bt_cong = new System.Windows.Forms.Button();
            this.lbso1 = new System.Windows.Forms.Label();
            this.txb_so1 = new System.Windows.Forms.TextBox();
            this.txb_so2 = new System.Windows.Forms.TextBox();
            this.lbso2 = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.txb_ketqua = new System.Windows.Forms.TextBox();
            this.bt_tru = new System.Windows.Forms.Button();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_chia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cong
            // 
            this.bt_cong.Location = new System.Drawing.Point(12, 124);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(43, 23);
            this.bt_cong.TabIndex = 0;
            this.bt_cong.Text = "cong";
            this.bt_cong.UseVisualStyleBackColor = true;
            this.bt_cong.Click += new System.EventHandler(this.bt_cong_Click);
            // 
            // lbso1
            // 
            this.lbso1.AutoSize = true;
            this.lbso1.Location = new System.Drawing.Point(12, 40);
            this.lbso1.Name = "lbso1";
            this.lbso1.Size = new System.Drawing.Size(27, 13);
            this.lbso1.TabIndex = 1;
            this.lbso1.Text = "so 1";
            // 
            // txb_so1
            // 
            this.txb_so1.Location = new System.Drawing.Point(75, 33);
            this.txb_so1.Name = "txb_so1";
            this.txb_so1.Size = new System.Drawing.Size(100, 20);
            this.txb_so1.TabIndex = 2;
            // 
            // txb_so2
            // 
            this.txb_so2.Location = new System.Drawing.Point(75, 83);
            this.txb_so2.Name = "txb_so2";
            this.txb_so2.Size = new System.Drawing.Size(100, 20);
            this.txb_so2.TabIndex = 2;
            // 
            // lbso2
            // 
            this.lbso2.AutoSize = true;
            this.lbso2.Location = new System.Drawing.Point(12, 90);
            this.lbso2.Name = "lbso2";
            this.lbso2.Size = new System.Drawing.Size(27, 13);
            this.lbso2.TabIndex = 1;
            this.lbso2.Text = "so 2";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(12, 171);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(43, 13);
            this.lbketqua.TabIndex = 1;
            this.lbketqua.Text = "ket qua";
            // 
            // txb_ketqua
            // 
            this.txb_ketqua.Location = new System.Drawing.Point(75, 168);
            this.txb_ketqua.Name = "txb_ketqua";
            this.txb_ketqua.Size = new System.Drawing.Size(100, 20);
            this.txb_ketqua.TabIndex = 2;
            // 
            // bt_tru
            // 
            this.bt_tru.Location = new System.Drawing.Point(75, 124);
            this.bt_tru.Name = "bt_tru";
            this.bt_tru.Size = new System.Drawing.Size(42, 23);
            this.bt_tru.TabIndex = 0;
            this.bt_tru.Text = "tru";
            this.bt_tru.UseVisualStyleBackColor = true;
            this.bt_tru.Click += new System.EventHandler(this.bt_tru_Click);
            // 
            // bt_nhan
            // 
            this.bt_nhan.Location = new System.Drawing.Point(146, 124);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(42, 23);
            this.bt_nhan.TabIndex = 0;
            this.bt_nhan.Text = "nhan";
            this.bt_nhan.UseVisualStyleBackColor = true;
            this.bt_nhan.Click += new System.EventHandler(this.bt_nhan_Click);
            // 
            // bt_chia
            // 
            this.bt_chia.Location = new System.Drawing.Point(221, 124);
            this.bt_chia.Name = "bt_chia";
            this.bt_chia.Size = new System.Drawing.Size(40, 23);
            this.bt_chia.TabIndex = 0;
            this.bt_chia.Text = "chia";
            this.bt_chia.UseVisualStyleBackColor = true;
            this.bt_chia.Click += new System.EventHandler(this.bt_chia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txb_ketqua);
            this.Controls.Add(this.txb_so2);
            this.Controls.Add(this.txb_so1);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbso2);
            this.Controls.Add(this.lbso1);
            this.Controls.Add(this.bt_chia);
            this.Controls.Add(this.bt_nhan);
            this.Controls.Add(this.bt_tru);
            this.Controls.Add(this.bt_cong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cong;
        private System.Windows.Forms.Label lbso1;
        private System.Windows.Forms.TextBox txb_so1;
        private System.Windows.Forms.TextBox txb_so2;
        private System.Windows.Forms.Label lbso2;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox txb_ketqua;
        private System.Windows.Forms.Button bt_tru;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_chia;
    }
}

