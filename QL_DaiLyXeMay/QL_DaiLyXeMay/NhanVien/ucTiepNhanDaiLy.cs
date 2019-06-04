using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.NhanVien;

namespace QL_DaiLyXeMay.NhanVien
{
    public partial class ucTiepNhanDaiLy : UserControl
    {
        ucDangNhap DangNhap = new ucDangNhap();
        public ucTiepNhanDaiLy()
        {
            InitializeComponent();
        }
        public ucTiepNhanDaiLy(ucDangNhap dangnhap)
        {
            InitializeComponent();
            DangNhap = dangnhap;
        }
        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.DAILY( MaDaiLy , TenDaiLy , MaLoaiDaiLy , DienThoai , Email , DiaChi , MaQuan , NgayTiepNhan , SoNo , GhiChu , MaNhanVien )" +
                " VALUES('" + txbMaHoSo.Text + "', "
                + "N'" + txbTenDaiLy.Text + "', "
                + "'" + cbbLoaiHoSo.Text + "', "
                + "'" + txbSoDienThoai.Text + "', "
                + "'" + txbEmail.Text + "', "
                + "N'" + txbDaiLy.Text + "', "
                + "'" + cbbQuan.Text + "', "
                + "'" + txbNgayTiepNhan.Text + "', "
                + "'0', "
                + "N'" + txbGhiChu.Text + "', "
                + "'" + txbMaNhanVien.Text + "')";
            GetData.update_Data(query);
            MessageBox.Show("Tạo hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ucTiepNhanDaiLy_Load(object sender, EventArgs e)
        {
            txbMaNhanVien.Text = DangNhap.txbTaiKhoan.Text;
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }

        private void txbNgayTiepNhan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpTiepNhanHoSo_ValueChanged(object sender, EventArgs e)
        {
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }
    }
}
