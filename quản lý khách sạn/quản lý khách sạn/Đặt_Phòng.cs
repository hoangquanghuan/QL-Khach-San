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

namespace quản_lý_khách_sạn
{
    public partial class Đặt_Phòng : Form
    {
        BUS_DatPhong bus_datphong = new BUS_DatPhong();
        public Đặt_Phòng()
        {
            InitializeComponent();
        }

        private void Đặt_Phòng_Load(object sender, EventArgs e)
        {
            dvgDat_phong.DataSource = bus_datphong.getDatPhong();
        }

        private void btnThoat_DP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_DP_Click(object sender, EventArgs e)
        {
            if (txtMa_Phieu_Đ.Text != " " && txtMa_P_Đ.Text != " " && txtMa_KH_Đ.Text != " " && txtSo_Nguoi_Đ.Text != " ")
            {
                DTO_DatPhong DatPhong = new DTO_DatPhong(txtMa_Phieu_Đ.Text, txtMa_P_Đ.Text, txtMa_KH_Đ.Text, dtpNgay_Đ.Text
                    , txtSo_Nguoi_Đ.Text);
                // thêm
                if (bus_datphong.themDatPhong(DatPhong))
                {
                    MessageBox.Show("thêm thành công");
                    dvgDat_phong.DataSource = bus_datphong.getDatPhong();
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

        private void btnXoa_DP_Click(object sender, EventArgs e)
        {
            DTO_DatPhong DatPhong = new DTO_DatPhong(txtMa_Phieu_Đ.Text, txtMa_P_Đ.Text, txtMa_KH_Đ.Text, dtpNgay_Đ.Text, txtSo_Nguoi_Đ.Text);
            // thêm
            if (bus_datphong.xoaDatPhong(DatPhong))
            {
                MessageBox.Show("xóa thành công");
                dvgDat_phong.DataSource = bus_datphong.getDatPhong();
            }
            else
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void btnSua_DP_Click(object sender, EventArgs e)
        {
            DTO_DatPhong DatPhong = new DTO_DatPhong(txtMa_Phieu_Đ.Text, txtMa_P_Đ.Text, txtMa_KH_Đ.Text, dtpNgay_Đ.Text, txtSo_Nguoi_Đ.Text);
            // thêm
            if (bus_datphong.suaDatPhong(DatPhong))
            {
                MessageBox.Show("sửa thành công");
                dvgDat_phong.DataSource = bus_datphong.getDatPhong();
            }
            else
            {
                MessageBox.Show("sửa không thành công");
            }
        }
    }
}
