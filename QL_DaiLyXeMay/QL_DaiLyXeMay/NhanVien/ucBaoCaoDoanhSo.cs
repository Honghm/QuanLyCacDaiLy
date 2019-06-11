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
using Microsoft.Reporting.WinForms;

namespace QL_DaiLyXeMay.NhanVien
{
    public partial class ucBaoCaoDoanhSo : UserControl
    {
        private String sMaBaoCao;
        private String sMaNhanVien;
        private DataTable table;
        public ucBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        private void BtnTaoBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString.connectionString;//Properties.Settings.Default.;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BAOCAODOANHSOTHANG";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Thang", int.Parse(cbbThang.Text)));
          
            //khai bao dataset de chua du lieu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            
            //Thiet lap thong so lien quan den bao cao
            rpvBCDSThang.ProcessingMode = ProcessingMode.Local;
            rpvBCDSThang.LocalReport.ReportPath = "BaoCaoDoanhSoThang.rdlc";

            //gan du lieu
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsBaoCaoThang";
            rds.Value = ds.Tables[0];
            rpvBCDSThang.LocalReport.DataSources.Clear();
            rpvBCDSThang.LocalReport.DataSources.Add(rds);
            rpvBCDSThang.RefreshReport();
        }

        //private void UcBaoCaoDoanhSo_Load(object sender, EventArgs e)
        //{
        //    dtgvBaoCaoDaNop.DataSource = Data.GetData_for_DataTable("select MaBaoCao[Mã báo cáo], NgayTao[Ngày tạo] from dbo.BAOCAODATAO").Tables[0];
        //    int temp = dtgvBaoCaoDaNop.Rows.Count;
        //    String sTemp = temp.ToString();
        //    while (sTemp.Length < 6)
        //        sTemp = "0" + sTemp;
        //    sMaBaoCao = sTemp;
        //    grbXemLaiBaoCaoDaTao.Visible = false;
        //    btnLuu.Visible = false;
        //    btnXoaBaoCaoVuaTao.Visible = false;
        //}

        
    }
}
