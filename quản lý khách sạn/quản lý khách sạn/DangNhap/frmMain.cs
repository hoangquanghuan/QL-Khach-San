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
        BUS_nhanvien bus_nhanvien = new BUS_nhanvien();
        BUS_khachhang bus_khachhang = new BUS_khachhang();
        BUS_dichvu bus_dichvu = new BUS_dichvu();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dvgPhong.DataSource = bus_phong.getPhong();
            dvgNhanvien.DataSource = bus_nhanvien.getNhanvien();
            dvgKhachhang.DataSource = bus_khachhang.getKhachhang();
            dvgDichvu.DataSource = bus_dichvu.getDichvu();
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



        private void dvgPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i;
            i = dvgĐc_Mừng.CurrentRow.Index;
            txtTen.Text = dvgĐc_Mừng.Rows[i].Cells[1].Value.ToString();
            txtĐịa_chỉ.Text = dvgĐc_Mừng.Rows[i].Cells[2].Value.ToString();
            txtSo_tien.Text = dvgĐc_Mừng.Rows[i].Cells[3].Value.ToString();
            txtNam.Text = dvgĐc_Mừng.Rows[i].Cells[4].Value.ToString();
            txtGhi_chu.Text = dvgĐc_Mừng.Rows[i].Cells[5].Value.ToString();
            */

            int i;
            i = dvgPhong.CurrentRow.Index;
            txtMa_phong.Text = dvgPhong.Rows[i].Cells[0].Value.ToString();
            txtTen_phong.Text = dvgPhong.Rows[i].Cells[1].Value.ToString();
            cmbLoai_phong.Text = dvgPhong.Rows[i].Cells[2].Value.ToString();
            cmbTinh_trang.Text = dvgPhong.Rows[i].Cells[3].Value.ToString();
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtMa_nhanvien.Text != " " && txtTen_nhanvien.Text != " "
                && cmbGioi_tinh.Text != " " && txtNgaysinh.Text != " "&&txtDia_chi.Text!=""
                &&txtSDT.Text!="")
            {
                DTO_nhanvien nhanvien = new DTO_nhanvien(txtMa_nhanvien.Text,
                    txtTen_nhanvien.Text, cmbGioi_tinh.Text, txtNgaysinh.Text,
                    txtDia_chi.Text, txtSDT.Text);
                // thêm
                if (bus_nhanvien.themNhanvien(nhanvien))
                {
                    MessageBox.Show("thêm thành công");
                    dvgNhanvien.DataSource = bus_nhanvien.getNhanvien();
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

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DTO_nhanvien nhanvien = new DTO_nhanvien(txtMa_nhanvien.Text,
                   txtTen_nhanvien.Text, cmbGioi_tinh.Text, txtNgaysinh.Text,
                   txtDia_chi.Text, txtSDT.Text);
            if(bus_nhanvien.xoaNhanvien(nhanvien))
            {
                MessageBox.Show("xóa thành công");
                dvgNhanvien.DataSource = bus_nhanvien.getNhanvien();
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            DTO_nhanvien nhanvien = new DTO_nhanvien(txtMa_nhanvien.Text,
                 txtTen_nhanvien.Text, cmbGioi_tinh.Text, txtNgaysinh.Text,
                 txtDia_chi.Text, txtSDT.Text);
            if (bus_nhanvien.suaNhanvien(nhanvien))
            {
                MessageBox.Show("sửa thành công");
                dvgNhanvien.DataSource = bus_nhanvien.getNhanvien();
            }
            else
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void dvgNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dvgNhanvien.CurrentRow.Index;
            txtMa_nhanvien.Text = dvgNhanvien.Rows[i].Cells[0].Value.ToString();
            txtTen_nhanvien.Text = dvgNhanvien.Rows[i].Cells[1].Value.ToString();
            cmbGioi_tinh.Text = dvgNhanvien.Rows[i].Cells[2].Value.ToString();
            txtNgaysinh.Text = dvgNhanvien.Rows[i].Cells[3].Value.ToString();
            txtDia_chi.Text = dvgNhanvien.Rows[i].Cells[4].Value.ToString();
            txtSDT.Text = dvgNhanvien.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (txtMa_KH.Text != " " && txtTen_KH.Text != " "
                && txtNgaySinhKH.Text != " " && cmbGioitinhKH.Text != " " && txtCMND_KH.Text != ""
                && txtSDT_KH.Text != "")
            {
                DTO_khachhang khachhang = new DTO_khachhang(txtMa_KH.Text,
                    txtTen_KH.Text, txtNgaySinhKH.Text, cmbGioitinhKH.Text,
                    txtCMND_KH.Text, txtSDT_KH.Text);
                // thêm
                if (bus_khachhang.themKhachhang(khachhang))
                {
                    MessageBox.Show("thêm thành công");
                    dvgKhachhang.DataSource = bus_khachhang.getKhachhang();
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

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DTO_khachhang khachhang = new DTO_khachhang(txtMa_KH.Text,
                  txtTen_KH.Text, txtNgaySinhKH.Text, cmbGioitinhKH.Text,
                  txtCMND_KH.Text, txtSDT_KH.Text);
            if (bus_khachhang.xoaKhachhang(khachhang))
            {
                MessageBox.Show("xóa thành công");
                dvgKhachhang.DataSource = bus_khachhang.getKhachhang();
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            DTO_khachhang khachhang = new DTO_khachhang(txtMa_KH.Text,
                  txtTen_KH.Text, txtNgaySinhKH.Text, cmbGioitinhKH.Text,
                  txtCMND_KH.Text, txtSDT_KH.Text);
            if (bus_khachhang.suaKhachhang(khachhang))
            {
                MessageBox.Show("sửa thành công");
                dvgKhachhang.DataSource = bus_khachhang.getKhachhang();
            }
            else
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void dvgKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dvgKhachhang.CurrentRow.Index;
            txtMa_KH.Text = dvgKhachhang.Rows[i].Cells[0].Value.ToString();
            txtTen_KH.Text = dvgKhachhang.Rows[i].Cells[1].Value.ToString();
            txtNgaySinhKH.Text = dvgKhachhang.Rows[i].Cells[2].Value.ToString();
            cmbGioitinhKH.Text = dvgKhachhang.Rows[i].Cells[3].Value.ToString();
            txtCMND_KH.Text = dvgKhachhang.Rows[i].Cells[4].Value.ToString();
            txtSDT_KH.Text = dvgKhachhang.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThoatHD_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void btnThoat_dv_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_dv_Click(object sender, EventArgs e)
        {
            if (txtMa_dv.Text!=""&&txtTendv.Text!=""&&txtGia.Text!="")
            {
                DTO_dichvu dichvu = new DTO_dichvu(txtMa_dv.Text,txtTendv.Text,txtGia.Text);
                // thêm
                if (bus_dichvu.themDichvu(dichvu))
                {
                    MessageBox.Show("thêm thành công");
                    dvgDichvu.DataSource = bus_dichvu.getDichvu();
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

        private void btnSua_dv_Click(object sender, EventArgs e)
        {

            DTO_dichvu dichvu = new DTO_dichvu(txtMa_dv.Text, txtTendv.Text, txtGia.Text);

            if (bus_dichvu.suaDichvu(dichvu))
            {
                MessageBox.Show("sửa thành công");
                dvgDichvu.DataSource = bus_dichvu.getDichvu();
            }
            else
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void btnXoa_dv_Click(object sender, EventArgs e)
        {
            DTO_dichvu dichvu = new DTO_dichvu(txtMa_dv.Text, txtTendv.Text, txtGia.Text);

            if (bus_dichvu.xoaDichvu(dichvu))
            {
                MessageBox.Show("xóa thành công");
                dvgDichvu.DataSource = bus_dichvu.getDichvu();
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }
    }
}
