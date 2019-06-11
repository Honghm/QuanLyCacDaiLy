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
using QL_DaiLyXeMay.Controllor;
namespace QL_DaiLyXeMay.QuanTriVien
{
    public partial class ucQuanTriVien : UserControl
    {
        frmTrangChu TrangChu = new frmTrangChu();
        public ucQuanTriVien()
        {
            InitializeComponent();
        }
        
        public ucQuanTriVien(frmTrangChu trangchu)
        {
            InitializeComponent();
            TrangChu = trangchu;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE dbo.TAIKHOAN SET " +
                    "TenNhanVien = N'" + txbTenNhanVien.Text + "', " +
                    "MatKhau = '" + txbMatKhau.Text + " ', " +
                    "LoaiTaiKhoan = N'" + txbChucVu.Text + "'" +
                    "WHERE MaNhanVien = '" + txbMaNhanVien.Text + "'";
            Data_SQL.update_Data(query);
            if (MessageBox.Show("chỉnh sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                txbChucVu.Text = "";
                txbMaNhanVien.Text = "";
                txbMatKhau.Text = "";
                txbTenNhanVien.Text = "";
                txbChucVu.ReadOnly = true;
                txbMaNhanVien.ReadOnly = true;
                txbMatKhau.ReadOnly = true;
                txbTenNhanVien.ReadOnly = true;
                btnChinhSua.Enabled = true;
            }
        }

        private void btnCapMatKhau_Click(object sender, EventArgs e)
        {
            txbMatKhau.Text = QTV.GetPassword();
        }
        

        private void ucQuanTriVien_Load(object sender, EventArgs e)
        {
            dtgvDanhSachCapQuyen.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN").Tables[0];
            btnLuu.Enabled = false;
        }

        private void dtgvDanhSachCapQuyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txbChucVu.ReadOnly = true;
            txbMaNhanVien.ReadOnly = true;
            txbMatKhau.ReadOnly = true;
            txbTenNhanVien.ReadOnly = true;
            btnChinhSua.Enabled = true;
            btnCapMatKhau.Enabled = false;
            string NameHeader = dtgvDanhSachCapQuyen.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
            string dataCell = dtgvDanhSachCapQuyen.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click
            string query = "select * from dbo.TAIKHOAN where " + NameHeader + " = N'" + dataCell + "'";
            dtgvTempData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTempData.DataSource = Data_SQL.GetData_for_DataTable(query).Tables[0];

            txbMaNhanVien.Text = dtgvTempData.CurrentRow.Cells[0].Value.ToString();
            txbTenNhanVien.Text = dtgvTempData.CurrentRow.Cells[1].Value.ToString();
            txbMatKhau.Text = dtgvTempData.CurrentRow.Cells[2].Value.ToString();
            txbChucVu.Text = dtgvTempData.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txbChucVu.Text.Length ==0||txbMaNhanVien.Text.Length==0||txbMatKhau.Text.Length==0||txbTenNhanVien.Text.Length==0)
            {
                if (MessageBox.Show("Tạo tài khoản thất bại \n\n Bạn phải nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
            }
            else if(txbChucVu.ReadOnly==true)
            {
                MessageBox.Show("Tạo tài khoản thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbChucVu.Text = "";
                txbMaNhanVien.Text = "";
                txbMatKhau.Text = "";
                txbTenNhanVien.Text = "";
                txbChucVu.ReadOnly = false;
                txbMaNhanVien.ReadOnly = false;
                txbMatKhau.ReadOnly = false;
                txbTenNhanVien.ReadOnly = false;
                btnCapMatKhau.Enabled = true;
            }
            else
            {
                string query = "INSERT INTO dbo.TAIKHOAN ( MaNhanVien , TenNhanVien , MatKhau , LoaiTaiKhoan ) " +
                   "VALUES ('" + txbMaNhanVien.Text + "', N'" + txbTenNhanVien.Text + "', '" + txbMatKhau.Text + " ', N'" + txbChucVu.Text + "')";
                if (Data_SQL.update_Data(query) == false)
                {
                    if (MessageBox.Show("Tạo tài khoản thất bại", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                }
                else
                {
                    if (MessageBox.Show("Tạo tài khoản thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        dtgvDanhSachCapQuyen.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN").Tables[0];
                        txbChucVu.Text = "";
                        txbMaNhanVien.Text = "";
                        txbMatKhau.Text = "";
                        txbTenNhanVien.Text = "";
                        txbChucVu.ReadOnly = true;
                        txbMaNhanVien.ReadOnly = true;
                        txbMatKhau.ReadOnly = true;
                        txbTenNhanVien.ReadOnly = true;
                        btnChinhSua.Enabled = true;
                    }
                }
            }
            
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            txbChucVu.ReadOnly = false;
            txbMaNhanVien.ReadOnly = false;
            txbMatKhau.ReadOnly = false;
            txbTenNhanVien.ReadOnly = false;
            btnLuu.Enabled = true;
            btnCapMatKhau.Enabled = true;
            btnTaoTaiKhoan.Enabled = false;
            //btnChinhSua.Enabled = false;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn xóa tài khoản này!","THÔNG BÁO",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Data_SQL.update_Data("DELETE FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + txbMaNhanVien.Text + "'");
                if (MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    dtgvDanhSachCapQuyen.DataSource = Data_SQL.GetData_for_DataTable("SELECT MaNhanVien, MatKhau FROM dbo.TAIKHOAN").Tables[0];
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ucDangNhap DangNhap = new ucDangNhap(TrangChu);
            TrangChu.pnTrangChu.Controls.Clear();
            TrangChu.pnTrangChu.Controls.Add(DangNhap);
           
        }

        
    }
}
