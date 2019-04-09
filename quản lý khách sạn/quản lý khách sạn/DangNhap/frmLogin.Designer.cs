namespace quản_lý_khách_sạn.DangNhap
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Thoat_button = new System.Windows.Forms.Button();
            this.DangNhap_button = new System.Windows.Forms.Button();
            this.NhapPass_textBox = new System.Windows.Forms.TextBox();
            this.QuenMK_label = new System.Windows.Forms.Label();
            this.NhapMK_label = new System.Windows.Forms.Label();
            this.NhapUser_textBox = new System.Windows.Forms.TextBox();
            this.NhapUser_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Thoat_button);
            this.panel1.Controls.Add(this.DangNhap_button);
            this.panel1.Controls.Add(this.NhapPass_textBox);
            this.panel1.Controls.Add(this.QuenMK_label);
            this.panel1.Controls.Add(this.NhapMK_label);
            this.panel1.Controls.Add(this.NhapUser_textBox);
            this.panel1.Controls.Add(this.NhapUser_label);
            this.panel1.Location = new System.Drawing.Point(20, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 202);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Thoat_button
            // 
            this.Thoat_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thoat_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Thoat_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Thoat_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat_button.Location = new System.Drawing.Point(333, 161);
            this.Thoat_button.Name = "Thoat_button";
            this.Thoat_button.Size = new System.Drawing.Size(83, 23);
            this.Thoat_button.TabIndex = 11;
            this.Thoat_button.Text = "Thoát";
            this.Thoat_button.UseVisualStyleBackColor = true;
            this.Thoat_button.Click += new System.EventHandler(this.Thoat_button_Click);
            // 
            // DangNhap_button
            // 
            this.DangNhap_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangNhap_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DangNhap_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap_button.Location = new System.Drawing.Point(243, 161);
            this.DangNhap_button.Name = "DangNhap_button";
            this.DangNhap_button.Size = new System.Drawing.Size(82, 23);
            this.DangNhap_button.TabIndex = 10;
            this.DangNhap_button.Text = "Đăng nhập";
            this.DangNhap_button.UseVisualStyleBackColor = true;
            this.DangNhap_button.Click += new System.EventHandler(this.DangNhap_button_Click);
            // 
            // NhapPass_textBox
            // 
            this.NhapPass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapPass_textBox.Location = new System.Drawing.Point(129, 70);
            this.NhapPass_textBox.Multiline = true;
            this.NhapPass_textBox.Name = "NhapPass_textBox";
            this.NhapPass_textBox.Size = new System.Drawing.Size(288, 28);
            this.NhapPass_textBox.TabIndex = 9;
            // 
            // QuenMK_label
            // 
            this.QuenMK_label.AutoSize = true;
            this.QuenMK_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuenMK_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuenMK_label.Location = new System.Drawing.Point(12, 135);
            this.QuenMK_label.Name = "QuenMK_label";
            this.QuenMK_label.Size = new System.Drawing.Size(132, 17);
            this.QuenMK_label.TabIndex = 8;
            this.QuenMK_label.Text = "Quên mật khẩu ?";
            // 
            // NhapMK_label
            // 
            this.NhapMK_label.BackColor = System.Drawing.Color.White;
            this.NhapMK_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMK_label.Location = new System.Drawing.Point(11, 70);
            this.NhapMK_label.Name = "NhapMK_label";
            this.NhapMK_label.Size = new System.Drawing.Size(118, 27);
            this.NhapMK_label.TabIndex = 7;
            this.NhapMK_label.Text = "Mật khẩu:";
            this.NhapMK_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NhapUser_textBox
            // 
            this.NhapUser_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapUser_textBox.Location = new System.Drawing.Point(129, 30);
            this.NhapUser_textBox.Multiline = true;
            this.NhapUser_textBox.Name = "NhapUser_textBox";
            this.NhapUser_textBox.Size = new System.Drawing.Size(288, 28);
            this.NhapUser_textBox.TabIndex = 1;
            // 
            // NhapUser_label
            // 
            this.NhapUser_label.BackColor = System.Drawing.Color.White;
            this.NhapUser_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapUser_label.Location = new System.Drawing.Point(11, 30);
            this.NhapUser_label.Name = "NhapUser_label";
            this.NhapUser_label.Size = new System.Drawing.Size(118, 27);
            this.NhapUser_label.TabIndex = 0;
            this.NhapUser_label.Text = "Tên đăng nhập:";
            this.NhapUser_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 230);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NhapPass_textBox;
        private System.Windows.Forms.Label QuenMK_label;
        private System.Windows.Forms.Label NhapMK_label;
        private System.Windows.Forms.TextBox NhapUser_textBox;
        private System.Windows.Forms.Label NhapUser_label;
        private System.Windows.Forms.Button Thoat_button;
        private System.Windows.Forms.Button DangNhap_button;
    }
}