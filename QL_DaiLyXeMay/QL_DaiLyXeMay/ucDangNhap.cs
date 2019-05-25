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
    public partial class ucDangNhap : UserControl
    {
        frmTrangChu TrangChu = new frmTrangChu();
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
            TrangChuNhanVien TrangNhanVien = new TrangChuNhanVien();
            TrangChu.pnTrangChu.Controls.Clear();
            TrangChu.pnTrangChu.Controls.Add(TrangNhanVien);
        }
    }
}
