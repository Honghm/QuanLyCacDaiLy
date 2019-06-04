using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DaiLyXeMay
{
    public partial class frmTrangChu : Form
    {
        //ucDangNhap DangNhap;
        public frmTrangChu()
        {
            InitializeComponent();
            
        }
        //public frmTrangChu(ucDangNhap dangnhap)
        //{
        //    DangNhap = new ucDangNhap(this);
        //    DangNhap = dangnhap;
        //}
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            ucDangNhap dangnhap = new ucDangNhap(this);
            pnTrangChu.Controls.Clear();
            pnTrangChu.Controls.Add(dangnhap);
        }

        private void tsmiDangNhapLai_Click(object sender, EventArgs e)
        {
            ucDangNhap dangnhap = new ucDangNhap(this);
            pnTrangChu.Controls.Clear();
            pnTrangChu.Controls.Add(dangnhap);
        }
    }
}
