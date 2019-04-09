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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public class GetUserAndPassword
        {
            public static string Username;
            public static string Password;
        }

        private void lblQuenMatKhau_MouseMove(object sender, MouseEventArgs e)
        {
            QuenMK_label.ForeColor = Color.Red;
        }

        private void lblQuenMatKhau_MouseLeave(object sender, EventArgs e)
        {
            QuenMK_label.ForeColor = Color.Black;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Thoat_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_button_Click(object sender, EventArgs e)
        {
            if (NhapUser_textBox.Text == "" && NhapPass_textBox.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không thể để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhapUser_textBox.Focus();
            }
            else if (NhapUser_textBox.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhapUser_textBox.Focus();
            }
            else if (NhapPass_textBox.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhapPass_textBox.Focus();
            }
            else
            {
                if (NhapUser_textBox.Text == "admin" && NhapPass_textBox.Text == frmDoiMK.GetNewPassword.NewPassword)
                {
                    GetUserAndPassword.Username = NhapUser_textBox.Text;
                    GetUserAndPassword.Password = NhapPass_textBox.Text;
                    frmMain f = new frmMain();
                    	this.Hide();
                    f.ShowDialog();
                    //	Application.Exit();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn vừa nhập sai tên người dùng hoặc mật khẩu, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NhapUser_textBox.Focus();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
