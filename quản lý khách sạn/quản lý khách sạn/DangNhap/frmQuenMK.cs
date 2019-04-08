using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_khách_sạn.DangNhap
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }
        public class GetNewPassword
        {
            public static string NewPassword = "admin";
        }



        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtMKCu.Text))
            {
                MessageBox.Show("Bạn cần điền vào mật khẩu cũ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKCu.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMKMoi.Text))
            {
                MessageBox.Show("Bạn cần điền vào mật khẩu mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoi.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMKMoiRepeat.Text))
            {
                MessageBox.Show("Bạn cần nhập lại mật khẩu mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKMoiRepeat.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmQuenMK_Load(object sender, EventArgs e)
        {
            txtMKCu.Focus();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (txtMKCu.Text == frmLogin.GetUserAndPassword.Password)
                {
                    if (txtMKMoi.Text == txtMKMoiRepeat.Text)
                    {
                        if (txtMKMoi.Text.Length < 8)
                        {
                            MessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự, vui lòng nhập lại.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            GetNewPassword.NewPassword = txtMKMoi.Text;
                            MessageBox.Show("Đã đổi mật khẩu thành công, mật khẩu mới là " + txtMKMoi.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ là: " + frmLogin.GetUserAndPassword.Password + ", vui lòng nhập lại.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnThoatDMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void MKmoi_label_Click(object sender, EventArgs e)
        {

        }
    }
}
