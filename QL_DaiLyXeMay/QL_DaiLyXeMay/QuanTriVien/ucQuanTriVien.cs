using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_DaiLyXeMay.QuanTriVien
{
    public partial class ucQuanTriVien : UserControl
    {
        frmTrangChu TrangChu = new frmTrangChu();
        public ucQuanTriVien()
        {
            InitializeComponent();
        }
        //SqlConnection connection;
        //string query;
        //SqlDataAdapter adapter;
        //SqlCommand command;
        public ucQuanTriVien(frmTrangChu trangchu)
        {
            InitializeComponent();
            TrangChu = trangchu;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.TAIKHOAN ( MaNhanVien , TenNhanVien , MatKhau , LoaiTaiKhoan ) " +
                    "VALUES ('" + txbMaNhanVien.Text + "', N'" + txbTenNhanVien.Text + "', '" + txbMatKhau.Text + " ', N'" + txbChucVu.Text + "')";
            GetData.update_Data(query);
            
            txbChucVu.Text = "";
            txbMaNhanVien.Text = "";
            txbMatKhau.Text = "";
            txbTenNhanVien.Text = "";
            txbChucVu.ReadOnly = true;
            txbMaNhanVien.ReadOnly = true;
            txbMatKhau.ReadOnly = true;
            txbTenNhanVien.ReadOnly = true;
        }

        private void btnCapMatKhau_Click(object sender, EventArgs e)
        {
            txbMatKhau.Text = GetPassword();
        }
        private string RandomString(int size, bool lowerCase) //Tạo chuỗi ký tự ngẫu nhiên
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        private int RandomNumber(int min, int max) //Tạo chuỗi số ngẫu nhiên
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(3, true));
            builder.Append(RandomNumber(100, 999));
            return builder.ToString();
        }

        private void ucQuanTriVien_Load(object sender, EventArgs e)
        {
            dtgvDanhSachCapQuyen.DataSource = GetData.GetDanhSach("SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN").Tables[0];
        }

        private void dtgvDanhSachCapQuyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NameHeader = dtgvDanhSachCapQuyen.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
            string dataCell = dtgvDanhSachCapQuyen.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click
            string query = "select * from dbo.TAIKHOAN where " + NameHeader + " = N'" + dataCell + "'";
            dtgvTempData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTempData.DataSource = GetData.GetDanhSach(query).Tables[0];

            txbMaNhanVien.Text = dtgvTempData.CurrentRow.Cells[0].Value.ToString();
            txbTenNhanVien.Text = dtgvTempData.CurrentRow.Cells[1].Value.ToString();
            txbMatKhau.Text = dtgvTempData.CurrentRow.Cells[2].Value.ToString();
            txbChucVu.Text = dtgvTempData.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            txbChucVu.Text = "";
            txbMaNhanVien.Text = "";
            txbMatKhau.Text = "";
            txbTenNhanVien.Text = "";
            txbChucVu.ReadOnly = false;
            txbMaNhanVien.ReadOnly = false;
            txbMatKhau.ReadOnly = false;
            txbTenNhanVien.ReadOnly = false;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbChucVu.ReadOnly = true;
            txbMaNhanVien.ReadOnly = true;
            txbMatKhau.ReadOnly = true;
            txbTenNhanVien.ReadOnly = true;
            btnChinhSua.Enabled = false;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa tài khoản này!","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                GetData.update_Data("DELETE FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + txbMaNhanVien.Text + "'");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ucDangNhap DangNhap = new ucDangNhap(TrangChu);
            TrangChu.pnTrangChu.Controls.Clear();
            TrangChu.pnTrangChu.Controls.Add(DangNhap);
           
        }

        private void tsmiDangNhapLai_Click(object sender, EventArgs e)
        {

        }
    }
}
