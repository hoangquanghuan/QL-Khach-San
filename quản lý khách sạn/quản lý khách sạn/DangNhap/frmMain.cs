using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace quản_lý_khách_sạn.DangNhap
{
    public partial class frmMain : Form
    {
        BUS_Phong bus_phong = new BUS_Phong();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dvgPhong.DataSource = bus_phong.getPhong();
        }

        private void palPhong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             if(txtMa_phong.Text!=" "&&txtTen_phong.Text!=" "&&cmbLoai_phong.Text!=" "&&cmbTinh_trang.Text!=" ")
            {
                DTO_Phong phong = new DTO_Phong(txtMa_phong.Text, txtTen_phong.Text,cmbLoai_phong.Text,cmbTinh_trang.Text);
                // thêm
                if(bus_phong.themPhong(phong))
                {
                    MessageBox.Show("thêm thành công");
                    dvgPhong.DataSource = bus_phong.getPhong();
                }
                else
                {
                    MessageBox.Show("thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("xin vui lòng nhập đủ thông tin");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_Phong phong = new DTO_Phong(txtMa_phong.Text, txtTen_phong.Text, cmbLoai_phong.Text, cmbTinh_trang.Text);
            // thêm
            if (bus_phong.suaPhong(phong))
            {
                MessageBox.Show("sửa thành công");
                dvgPhong.DataSource = bus_phong.getPhong();
            }
            else
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTO_Phong phong = new DTO_Phong(txtMa_phong.Text, txtTen_phong.Text, cmbLoai_phong.Text, cmbTinh_trang.Text);
            // thêm
            if (bus_phong.xoaPhong(phong))
            {
                MessageBox.Show("xóa thành công");
                dvgPhong.DataSource = bus_phong.getPhong();
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
