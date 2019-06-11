using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.Controllor;
using System.Data.SqlClient;

namespace QL_DaiLyXeMay
{
    public partial class ucPhieuXuatHang : UserControl
    {
        ucDangNhap DangNhap = new ucDangNhap();
        ucTrangChucNang TrangChucNang = new ucTrangChucNang();
        public ucPhieuXuatHang()
        {
            InitializeComponent();
        }
        public ucPhieuXuatHang(ucDangNhap dangnhap, ucTrangChucNang trangchucnang)
        {
            InitializeComponent();
            DangNhap = dangnhap;
            TrangChucNang = trangchucnang;
        }

        private void ucPhieuXuatHang_Load(object sender, EventArgs e)
        {
            //DataTable XuatHang = Data_SQL.GetData_for_DataTable("SELECT MaPhieuXuatHang FROM dbo.PHIEUXUATHANG").Tables[0];
            dtgvDanhSachPhieuXuat.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaPhieuXuatHang FROM dbo.PHIEUXUATHANG").Tables[0];
            txbNguoiLapPhieu.Text = DangNhap.txbTaiKhoan.Text;
            txbNgayLapPhieu.Text = dtpNgayLapPhieu.Value.ToString();
            dtgvTemp.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaMatHang FROM dbo.MATHANG");
            MaMatHang.Items.Clear();
            foreach(DataGridViewRow row in dtgvTemp.Rows)
            {
                MaMatHang.Items.Add(row.Cells[0].Value.ToString());
            }
            //using (Data_SQL.Connection = new SqlConnection(ConnectionString.connectionString))
            //{
            //    if (Data_SQL.Connection.State == ConnectionState.Closed || Data_SQL.Connection.State == ConnectionState.Broken)
            //        Data_SQL.Connection.Open();
            //    //Data_SQL.Adapter = new SqlDataAdapter(CauLenh, Data_SQL.Connection);
            //    Data_SQL.Command = new SqlCommand("SELECT MaMatHang FROM dbo.MATHANG", Data_SQL.Connection);
            //    //adapter = new SqlDataAdapter(Command);
            //    //adapter.Fill(data);
            //    Data_SQL.Reader = Data_SQL.Command.ExecuteReader();
            //    //MaMatHang.DataSource = ("SELECT MaMatHang FROM dbo.MATHANG");
            //    if (Data_SQL.Reader.HasRows)
            //    {
            //        while (Data_SQL.Reader.Read())
            //        {
            //            MaMatHang.ValueMember = Data_SQL.Reader[0].ToString();
            //            MaMatHang.DisplayMember = Data_SQL.Reader[0].ToString();
            //        }
            //    }
            //    Data_SQL.Connection.Close();
            //}
            

        }

        private void dtgvDanhSachPhieuXuat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NameHeader = dtgvDanhSachPhieuXuat.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
            string dataCell = dtgvDanhSachPhieuXuat.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click
            dtgvTemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTemp.DataSource = Data_SQL.GetData_for_DataTable("select * from dbo.PHIEUXUATHANG where " + NameHeader + " = N'" + dataCell + "'").Tables[0];
            txbMaPhieu.Text = dtgvTemp.CurrentRow.Cells[0].Value.ToString();
            txbTenDaiLy.Text = dtgvTemp.CurrentRow.Cells[1].Value.ToString();
            txbTongTien.Text = dtgvTemp.CurrentRow.Cells[2].Value.ToString();
            txbTraTruoc.Text = dtgvTemp.CurrentRow.Cells[3].Value.ToString();
            txbNgayLapPhieu.Text = dtgvTemp.CurrentRow.Cells[4].Value.ToString();
            txbNguoiLapPhieu.Text = dtgvTemp.CurrentRow.Cells[5].Value.ToString();
            dtgvTemp.Controls.Clear();
            //dtgvChiTietDonHang.DataSource = Data_SQL.GetData_for_DataTable("SELECT * FROM dbo.CHITIETXUAT WHERE MaPhieuXuatHang = '" + txbTenDaiLy.Text + "'");
           
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        { 
            Data_SQL.update_Data("INSERT INTO dbo.PHIEUXUATHANG( MaPhieuXuatHang , MaDaiLy , TongGiaTri , TraTruoc , NgayLap , MaNhanVien )" +
                " VALUES('" + txbMaPhieu.Text + "', '" + txbTenDaiLy.Text + "', " + txbTongTien.Text + ", " + txbTraTruoc.Text + ", '" + txbNgayLapPhieu.Text + "', '" + txbNguoiLapPhieu.Text + "')");
            dtgvDanhSachPhieuXuat.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaPhieuXuatHang, NgayLap FROM dbo.PHIEUXUATHANG").Tables[0];
            foreach (DataGridViewColumn column in dtgvChiTietDonHang.Columns)
            {
                Data_SQL.update_Data("INSERT INTO CHITIETXUAT (MaPhieuXuatHang, MaMatHang, SoLuong, ThanhTien)" +
                    " VALUES ('" + txbMaPhieu.Text + "', '" + dtgvChiTietDonHang.CurrentRow.Cells[1].Value.ToString() + "', '"
                    + dtgvChiTietDonHang.CurrentRow.Cells[4].Value.ToString() + "', "
                    + dtgvChiTietDonHang.CurrentRow.Cells[6].Value.ToString() + "')");
            }
        }

        private void txbNgayLapPhieu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {
            txbNgayLapPhieu.Text = dtpNgayLapPhieu.Value.ToString();
        }

        private void dtgvChiTietDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dtgvTemp.Controls.Clear();
            //dtgvTemp.DataSource = Data_SQL.GetData_for_DataTable("SELECT * FROM dbo.MATHANG WHERE MaMatHang = '" + dtgvChiTietDonHang.CurrentRow.Cells[1].Value.ToString() + "'");
            //dtgvChiTietDonHang.CurrentRow.Cells[2].Value = dtgvTemp.CurrentRow.Cells[1].Value.ToString();
            //dtgvChiTietDonHang.CurrentRow.Cells[3].Value = dtgvTemp.CurrentRow.Cells[5].Value.ToString();
            //dtgvChiTietDonHang.CurrentRow.Cells[5].Value = dtgvTemp.CurrentRow.Cells[4].Value.ToString();
            //if(dtgvChiTietDonHang.CurrentRow.Cells[4].Value != null)
            //{
            //    dtgvChiTietDonHang.CurrentRow.Cells[6].Value = double.Parse(dtgvChiTietDonHang.CurrentRow.Cells[4].Value.ToString()) * double.Parse(dtgvChiTietDonHang.CurrentRow.Cells[5].Value.ToString());
            //}
           
        }
    }
}
