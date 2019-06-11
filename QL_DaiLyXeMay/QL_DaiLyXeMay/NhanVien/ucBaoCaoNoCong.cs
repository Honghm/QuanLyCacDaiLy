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
    public partial class ucBaoCaoNoCong : UserControl
    {
        public ucBaoCaoNoCong()
        {
            InitializeComponent();
        }


        private void ucBaoCaoNoCong_Load(object sender, EventArgs e)
        {

        }

        private void BtnTaoBaoCao_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConnectionString.connectionString;//Properties.Settings.Default.;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BAOCAOCONGNO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Thang", int.Parse(cbbThang.Text)));

            //khai bao dataset de chua du lieu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);

            //Thiet lap thong so lien quan den bao cao
            rpvBaoCaoCongNo.ProcessingMode = ProcessingMode.Local;
            rpvBaoCaoCongNo.LocalReport.ReportPath = "rpBaoCaoConNo.rdlc";

            //gan du lieu
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsBaoCaoCongNo";
            rds.Value = ds.Tables[0];
            rpvBaoCaoCongNo.LocalReport.DataSources.Clear();
            rpvBaoCaoCongNo.LocalReport.DataSources.Add(rds);
            rpvBaoCaoCongNo.RefreshReport();
        }
    }
}
