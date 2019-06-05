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
        public ucDanhSachDaiLy()
        {
            InitializeComponent();
        }

        private void lbNhanVienTiepNhan_Click(object sender, EventArgs e)
        {

        }

        private void ucDanhSachDaiLy_Load(object sender, EventArgs e)
        {
            dtgvDanhSachDaiLy.DataSource = GetData.GetDanhSach("select MaDaiLy, TenDaiLy from dbo.DAILY").Tables[0];
            dtgvDanhSachDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dtgvDanhSachDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvDanhSachDaiLy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NameHeader = dtgvDanhSachDaiLy.Columns[e.ColumnIndex].HeaderText.ToString();//Lấy tên header của ô được trỏ tới
            string dataCell = dtgvDanhSachDaiLy.CurrentCell.Value.ToString(); //Lấy dữ liệu tại ô được click
            string query = "select * from dbo.DAILY where " + NameHeader + " = N'" + dataCell + "'";
            dtgvTemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvTemp.DataSource = GetData.GetDanhSach(query).Tables[0];

            txbMaHoSo.Text = dtgvTemp.CurrentRow.Cells[0].Value.ToString();
            txbTenDaiLy.Text = dtgvTemp.CurrentRow.Cells[1].Value.ToString();
            cbbLoaiDaiLy.Text = dtgvTemp.CurrentRow.Cells[2].Value.ToString();
            txbSoDienThoai.Text = dtgvTemp.CurrentRow.Cells[3].Value.ToString();
            txbEMail.Text = dtgvTemp.CurrentRow.Cells[4].Value.ToString();
            txbDiaChi.Text = dtgvTemp.CurrentRow.Cells[5].Value.ToString();
            cbbQuan.Text = dtgvTemp.CurrentRow.Cells[6].Value.ToString();
            txbNgayTiepNhan.Text = dtgvTemp.CurrentRow.Cells[7].Value.ToString();
            txbTienNo.Text = dtgvTemp.CurrentRow.Cells[8].Value.ToString();
            txbGhiChu.Text = dtgvTemp.CurrentRow.Cells[9].Value.ToString();
            txbMaNhanVien.Text = dtgvTemp.CurrentRow.Cells[10].Value.ToString();

        }
    }
}
