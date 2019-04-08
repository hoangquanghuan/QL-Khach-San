namespace quản_lý_khách_sạn.DangNhap
{
    partial class frmDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMK));
            this.MKcu_label = new System.Windows.Forms.Label();
            this.MKmoi_label = new System.Windows.Forms.Label();
            this.NhapMKmoi_label = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.btnThoatDMK = new System.Windows.Forms.Button();
            this.txtMKMoiRepeat = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MKcu_label
            // 
            this.MKcu_label.AutoSize = true;
            this.MKcu_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKcu_label.Location = new System.Drawing.Point(23, 74);
            this.MKcu_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MKcu_label.Name = "MKcu_label";
            this.MKcu_label.Size = new System.Drawing.Size(129, 24);
            this.MKcu_label.TabIndex = 1;
            this.MKcu_label.Text = "Mật khẩu cũ:";
            this.MKcu_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MKcu_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // MKmoi_label
            // 
            this.MKmoi_label.AutoSize = true;
            this.MKmoi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MKmoi_label.Location = new System.Drawing.Point(23, 142);
            this.MKmoi_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MKmoi_label.Name = "MKmoi_label";
            this.MKmoi_label.Size = new System.Drawing.Size(140, 24);
            this.MKmoi_label.TabIndex = 2;
            this.MKmoi_label.Text = "Mật khẩu mới:";
            this.MKmoi_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MKmoi_label.Click += new System.EventHandler(this.MKmoi_label_Click);
            // 
            // NhapMKmoi_label
            // 
            this.NhapMKmoi_label.AutoSize = true;
            this.NhapMKmoi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMKmoi_label.Location = new System.Drawing.Point(23, 207);
            this.NhapMKmoi_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NhapMKmoi_label.Name = "NhapMKmoi_label";
            this.NhapMKmoi_label.Size = new System.Drawing.Size(223, 24);
            this.NhapMKmoi_label.TabIndex = 3;
            this.NhapMKmoi_label.Text = "Nhập lại mật khẩu mới:";
            this.NhapMKmoi_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.Location = new System.Drawing.Point(146, 288);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(100, 28);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // btnThoatDMK
            // 
            this.btnThoatDMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatDMK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatDMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatDMK.Location = new System.Drawing.Point(339, 288);
            this.btnThoatDMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatDMK.Name = "btnThoatDMK";
            this.btnThoatDMK.Size = new System.Drawing.Size(100, 28);
            this.btnThoatDMK.TabIndex = 5;
            this.btnThoatDMK.Text = "Thoát";
            this.btnThoatDMK.UseVisualStyleBackColor = true;
            this.btnThoatDMK.Click += new System.EventHandler(this.btnThoatDMK_Click);
            // 
            // txtMKMoiRepeat
            // 
            this.txtMKMoiRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoiRepeat.Location = new System.Drawing.Point(260, 207);
            this.txtMKMoiRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoiRepeat.Multiline = true;
            this.txtMKMoiRepeat.Name = "txtMKMoiRepeat";
            this.txtMKMoiRepeat.Size = new System.Drawing.Size(304, 30);
            this.txtMKMoiRepeat.TabIndex = 8;
            this.txtMKMoiRepeat.UseSystemPasswordChar = true;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(260, 134);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoi.Multiline = true;
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(304, 32);
            this.txtMKMoi.TabIndex = 9;
            this.txtMKMoi.UseSystemPasswordChar = true;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.txtMKMoi_TextChanged);
            // 
            // txtMKCu
            // 
            this.txtMKCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(260, 70);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCu.Multiline = true;
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(304, 28);
            this.txtMKCu.TabIndex = 10;
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 371);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKMoiRepeat);
            this.Controls.Add(this.btnThoatDMK);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.NhapMKmoi_label);
            this.Controls.Add(this.MKmoi_label);
            this.Controls.Add(this.MKcu_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoiMK";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmQuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MKcu_label;
        private System.Windows.Forms.Label MKmoi_label;
        private System.Windows.Forms.Label NhapMKmoi_label;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnThoatDMK;
        private System.Windows.Forms.TextBox txtMKMoiRepeat;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
    }
}