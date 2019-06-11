using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DaiLyXeMay
{
    public partial class ucDanhSachDaiLy : UserControl
    {
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucDanhSachDaiLy()
        {
            InitializeComponent();
        }
        public ucDanhSachDaiLy(ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            TrangChucNang = trangchucnang;
        }
       
        private void ucDanhSachDaiLy_Load(object sender, EventArgs e)
        {
            dtgvDanhSachDaiLy.DataSource = Data_SQL.GetData_for_DataTable("select MaDaiLy, TenDaiLy from dbo.DAILY").Tables[0];
            dtgvDanhSachDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txbDiaChi.ReadOnly = true;
            txbEMail.ReadOnly = true;
            txbGhiChu.ReadOnly = true;
            txbMaHoSo.ReadOnly = true;
            txbMaNhanVien.ReadOnly = true;
            txbNgayTiepNhan.ReadOnly = true;
            txbSoDienThoai.ReadOnly = true;
            txbTenDaiLy.ReadOnly = true;
            txbTienNo.ReadOnly = true;
            cbbLoaiDaiLy.Enabled = false;
            cbbQuan.Enabled = false;

        }
        
        private void dtgvDanhSachDaiLy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NameHeader = dtgvDanhSachDaiLy.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
            string dataCell = dtgvDanhSachDaiLy.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click
            string query = "select * from dbo.DAILY where " + NameHeader + " = N'" + dataCell + "'";
            dtgvTemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTemp.DataSource = Data_SQL.GetData_for_DataTable(query).Tables[0];

            txbMaHoSo.Text = dtgvTemp.CurrentRow.Cells[0].Value.ToString();
            txbTenDaiLy.Text = dtgvTemp.CurrentRow.Cells[1].Value.ToString();
            //cbbLoaiDaiLy.Text = dtgvTemp.CurrentRow.Cells[2].Value.ToString();
            txbSoDienThoai.Text = dtgvTemp.CurrentRow.Cells[3].Value.ToString();
            txbEMail.Text = dtgvTemp.CurrentRow.Cells[4].Value.ToString();
            txbDiaChi.Text = dtgvTemp.CurrentRow.Cells[5].Value.ToString();
            //cbbQuan.Text = dtgvTemp.CurrentRow.Cells[6].Value.ToString();
            txbNgayTiepNhan.Text = dtgvTemp.CurrentRow.Cells[7].Value.ToString();
            txbTienNo.Text = dtgvTemp.CurrentRow.Cells[8].Value.ToString();
            txbGhiChu.Text = dtgvTemp.CurrentRow.Cells[9].Value.ToString();
            txbMaNhanVien.Text = dtgvTemp.CurrentRow.Cells[10].Value.ToString();

            //Lấy tên loại đại lý từ mã đại lý
            cbbLoaiDaiLy.Text = Data_SQL.get_Data_of_SomeThing("SELECT dbo.LOAIDAILY.TenLoaiDaiLy " +
                "FROM dbo.DAILY, dbo.LOAIDAILY " +
                "WHERE dbo.LOAIDAILY.MaLoaiDaiLy = dbo.DAILY.MaLoaiDaiLy " +
                    "AND dbo.DAILY.MaDaiLy = '" + txbMaHoSo.Text + "'").ToString();
            //Lấy tên quận từ mã quận
            cbbQuan.Text = Data_SQL.get_Data_of_SomeThing("SELECT dbo.QUAN.TenQuan " +
                "FROM dbo.DAILY, dbo.QUAN " +
                "WHERE dbo.QUAN.MaQuan = dbo.DAILY.MaQuan " +
                "AND dbo.DAILY.MaDaiLy = '" + txbMaHoSo.Text + "'").ToString();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbDiaChi.ReadOnly = false;
            txbEMail.ReadOnly = false;
            txbGhiChu.ReadOnly = false;
            txbMaHoSo.ReadOnly = false;
            txbMaNhanVien.ReadOnly = false;
            txbNgayTiepNhan.ReadOnly = false;
            txbSoDienThoai.ReadOnly = false;
            txbTenDaiLy.ReadOnly = false;
            txbTienNo.ReadOnly = false;
            cbbLoaiDaiLy.Enabled = true;
            cbbQuan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Lấy mã loại đại lý từ tên loại đại lý
            string MaLoaiDaiLy = Data_SQL.get_Data_of_SomeThing("SELECT MaLoaiDaiLy " +
                "FROM dbo.LOAIDAILY WHERE  TenLoaiDaiLy = N'" + cbbLoaiDaiLy.Text + "'").ToString();
            //Lấy mã quận từ tên quận
            string MaQuan = Data_SQL.get_Data_of_SomeThing("SELECT MaQuan " +
                "FROM dbo.QUAN WHERE  TenQuan = N'" + cbbQuan.Text + "'").ToString();
            string query = "UPDATE dbo.DAILY SET" +
                " TenDaiLy = N'" + txbTenDaiLy.Text + "', "
                + "MaLoaiDaiLy = '" + MaLoaiDaiLy + "', "
                + "DienThoai = '" + txbSoDienThoai.Text + "', "
                + "Email = '" + txbEMail.Text + "', "
                + "DiaChi = N'" + txbDiaChi.Text + "', "
                + "MaQuan = '" + MaQuan + "', "
                + "NgayTiepNhan = '" + txbNgayTiepNhan.Text + "', "
                + "SoNo = '" + txbTienNo.Text + "', "
                + "GhiChu = N'" + txbGhiChu.Text + "', "
                + "MaNhanVien = '" + txbMaNhanVien.Text + "'"
                + "WHERE MaDaiLy = '" + txbMaHoSo.Text + "'";

            Data_SQL.update_Data(query);
            if(MessageBox.Show("chỉnh sửa thành công","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
            {
                txbDiaChi.ReadOnly = true;
                txbEMail.ReadOnly = true;
                txbGhiChu.ReadOnly = true;
                txbMaHoSo.ReadOnly = true;
                txbMaNhanVien.ReadOnly = true;
                txbNgayTiepNhan.ReadOnly = true;
                txbSoDienThoai.ReadOnly = true;
                txbTenDaiLy.ReadOnly = true;
                txbTienNo.ReadOnly = true;
                cbbLoaiDaiLy.Enabled = false;
                cbbQuan.Enabled = false;
                dtgvDanhSachDaiLy.DataSource = Data_SQL.GetData_for_DataTable("select MaDaiLy, TenDaiLy from dbo.DAILY").Tables[0];
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa đại lý này?","THÔNG BÁO", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Data_SQL.update_Data("DELETE FROM dbo.DAILY WHERE MaDaiLy = '" + txbMaHoSo.Text + "'");
                if(MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dtgvDanhSachDaiLy.DataSource = Data_SQL.GetData_for_DataTable("select MaDaiLy, TenDaiLy from dbo.DAILY").Tables[0];
                }
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChucNang.pnChiTietChucNang.Controls.Clear();
        }
    }
}
