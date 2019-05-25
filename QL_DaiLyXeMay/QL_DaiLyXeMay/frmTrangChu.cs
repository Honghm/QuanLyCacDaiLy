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
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            ucDangNhap dangnhap = new ucDangNhap(this);
            pnTrangChu.Controls.Clear();
            pnTrangChu.Controls.Add(dangnhap);
        }
    }
}
