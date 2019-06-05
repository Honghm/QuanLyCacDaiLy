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
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucTiepNhanDaiLy()
        {
            InitializeComponent();
        }
        public ucTiepNhanDaiLy(ucDangNhap dangnhap, ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            DangNhap = dangnhap;
            TrangChucNang = trangchucnang;
        }
        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
            if (txbMaHoSo.Text.Length == 0 || txbNgayTiepNhan.Text.Length == 0 || txbTenDaiLy.Text.Length == 0 || cbbLoaiHoSo.Text.Length == 0 || cbbQuan.Text.Length == 0 || txbTenDaiLy.Text.Length == 0 || txbSoDienThoai.Text.Length == 0 || txbMaNhanVien.Text.Length == 0)
            {
               
                MessageBox.Show("Tạo hồ sơ thất bại!\n\n Bạn đã bỏ trống trường có dấu (*)", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Lấy mã loại đại lý từ tên loại đại lý
                string MaLoaiDaiLy = Data.get_Data_of_SomeThing("SELECT MaLoaiDaiLy " +
                    "FROM dbo.LOAIDAILY WHERE  TenLoaiDaiLy = N'" + cbbLoaiHoSo.Text + "'").ToString();
                //Lấy mã quận từ tên quận
                string MaQuan = Data.get_Data_of_SomeThing("SELECT MaQuan " +
                    "FROM dbo.QUAN WHERE  TenQuan = N'" + cbbQuan.Text + "'").ToString();
                string query = "INSERT INTO dbo.DAILY( MaDaiLy , TenDaiLy , MaLoaiDaiLy , DienThoai , Email , DiaChi , MaQuan , NgayTiepNhan , SoNo , GhiChu , MaNhanVien )" +
                    " VALUES('" + txbMaHoSo.Text + "', "
                    + "N'" + txbTenDaiLy.Text + "', "
                    + "'" + MaLoaiDaiLy + "', "
                    + "'" + txbSoDienThoai.Text + "', "
                    + "'" + txbEmail.Text + "', "
                    + "N'" + txbDiaChi.Text + "', "
                    + "'" + MaQuan + "', "
                    + "'" + txbNgayTiepNhan.Text + "', "
                    + "'0', "
                    + "N'" + txbGhiChu.Text + "', "
                    + "'" + txbMaNhanVien.Text + "')";
                Data.update_Data(query);
                if (MessageBox.Show("Tạo hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txbMaHoSo.Text = null;
                    txbTenDaiLy.Text = null;
                    txbDiaChi.Text = null;
                    txbEmail.Text = null;
                    txbGhiChu.Text = null;
                    txbNgayTiepNhan.Text = null;
                    txbSoDienThoai.Text = null;
                    cbbLoaiHoSo.Text = null;
                    cbbQuan.Text = null;
                }
            }
               
            

        }

        private void ucTiepNhanDaiLy_Load(object sender, EventArgs e)
        {
            txbMaNhanVien.Text = DangNhap.txbTaiKhoan.Text;
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }
        
        private void dtpTiepNhanHoSo_ValueChanged(object sender, EventArgs e)
        {
            txbNgayTiepNhan.Text = dtpTiepNhanHoSo.Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }
    }
}
