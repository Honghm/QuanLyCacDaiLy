using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_DaiLyXeMay.QuanTriVien;
using System.Data.SqlClient;
using System.Data.Common;

namespace QL_DaiLyXeMay
{
    public partial class ucDangNhap : UserControl
    {
        frmTrangChu TrangChu = new frmTrangChu();
        
        public ucDangNhap()
        {
            InitializeComponent();
            
        }
        public ucDangNhap(frmTrangChu trangchu)
        {
            InitializeComponent();
            TrangChu = trangchu;
        }
       
        private void txbTaiKhoan_Click(object sender, EventArgs e)
        {
            txbTaiKhoan.ReadOnly = false;
            txbTaiKhoan.Text = "";
        }

        private void txbMatKhau_Click(object sender, EventArgs e)
        {
            txbMatKhau.ReadOnly = false;
            txbMatKhau.Text = "";
            txbMatKhau.PasswordChar = '*';
        }
        private void lbDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            lbDangNhap.ForeColor = Color.Red;
        }

        private void lbDangNhap_MouseLeave(object sender, EventArgs e)
        {
            lbDangNhap.ForeColor = Color.Black;
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTra.KiemTraTaiKhoan(txbTaiKhoan.Text, txbMatKhau.Text) == true)
            {
                KiemTraLoaiTaiKhoan(txbTaiKhoan.Text);
            }
            else
                MessageBox.Show("Tài khoản không tồn tại yêu cầu nhập lại!", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            
        }
        string query;
        
        void KiemTraLoaiTaiKhoan(string TaiKhoan)
        {
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
            connection.Open();
            query = "SELECT LoaiTaiKhoan"+
                " FROM dbo.TAIKHOAN WHERE MaNhanVien = '"+TaiKhoan+"'";
            SqlCommand command = new SqlCommand(query, connection);
            object get_Data = command.ExecuteScalar();
            connection.Close();
            switch (get_Data.ToString())
            { 
                case "Nhân viên":
                case "nhân viên":
                case "Nhân Viên":
                    {
                        ucTrangChucNang TrangChucNang = new ucTrangChucNang(this);
                        TrangChu.pnTrangChu.Controls.Clear();
                        //TrangChucNang.TopLevel = false;
                        TrangChu.pnTrangChu.Controls.Add(TrangChucNang);
                        break;
                    }
                case "Quản lý":
                case "Quản Lý":
                case "quản lý":
                    {
                        break;
                    }
                
                case "Quản trị viên":
                    {
                        ucQuanTriVien QuanTri = new ucQuanTriVien(TrangChu);
                        TrangChu.pnTrangChu.Controls.Clear();
                        TrangChu.pnTrangChu.Controls.Add(QuanTri);
                        break;
                    }
            }
        }

        private void llbDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoiMatKhau DoiMatKhau = new frmDoiMatKhau(TrangChu);
            DoiMatKhau.Show();
            TrangChu.Hide();
            this.Hide();

        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
