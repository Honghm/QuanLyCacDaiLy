using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay
{
    class KiemTra
    {
        public static bool KiemTraTaiKhoan(string TaiKhoan, string MatKhau)
        {
            SqlConnection connection = new SqlConnection(ConnectionString.connectionString);
            connection.Open();
            string query = "SELECT COUNT(MaNhanVien)" +
                " FROM dbo.TAIKHOAN WHERE MaNhanVien = '" + TaiKhoan + "' AND MatKhau = '" + MatKhau + "'";
            SqlCommand command = new SqlCommand(query, connection);
            DbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else return false;
        }
    }
}
