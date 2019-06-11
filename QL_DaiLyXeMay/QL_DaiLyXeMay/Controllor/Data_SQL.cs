using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay
{
    class Data_SQL
    {
        private static SqlConnection connection;
        //public static string query;
        private static SqlDataAdapter adapter;
        private static SqlCommand command;
        private static SqlDataReader reader;
        public static SqlCommand Command { get => command; set => command = value; }
        public static SqlDataReader Reader { get => reader; set => reader = value; }
        public static SqlConnection Connection { get => connection; set => connection = value; }
        public static SqlDataAdapter Adapter { get => adapter; set => adapter = value; }

        public static DataSet GetData_for_DataTable(string CauLenh)
        {
            DataSet data = new DataSet();

            // SqlConnection
            using (Connection = new SqlConnection(ConnectionString.connectionString))
            {
                if(Connection.State == ConnectionState.Closed || Connection.State == ConnectionState.Broken)
                    Connection.Open();
                Adapter = new SqlDataAdapter(CauLenh, Connection);
                Command = new SqlCommand(CauLenh, Connection);
                Adapter = new SqlDataAdapter(Command);
                Adapter.Fill(data);
                Reader = Command.ExecuteReader();
                
                Connection.Close();
            }
            return data;
        }

        //public static DataSet GetAllData_of_Cell(string CauLenh) //Lấy thông tin của đại lý từ ô được trỏ tới
        //{
        //    DataSet data = new DataSet();
        //    //string query = "select MaHoSo from dbo.HoSoDL where @NameColumn = '@data' ";
            
        //    using (connection = new SqlConnection(ConnectionString.connectionString))
        //    {
        //        connection.Open();
        //        command = new SqlCommand(CauLenh, connection);
        //        adapter = new SqlDataAdapter(command);
        //        //command.Parameters.AddWithValue("@NameColumn", a);
        //        //command.Parameters.AddWithValue("@data", b);
        //        adapter.Fill(data);
        //        connection.Close();
        //    }
        //    //SqlCommand

        //    //SqlDataAdapter

        //    return data;
        //}

        public static Object get_Data_of_SomeThing(string CauLenh) //Lấy thông tin từ mã số
        {
            //object get_Data;
            using (Connection = new SqlConnection(ConnectionString.connectionString))
            {
                Connection.Open();
                Command = new SqlCommand(CauLenh, Connection);
                //adapter = new SqlDataAdapter(command);
                object get_Data = Command.ExecuteScalar();
                Connection.Close();
                return get_Data;
            }

        }
        public static bool update_Data(string CauLenh)
        {
            using (Connection = new SqlConnection(ConnectionString.connectionString))
            {
                Connection.Open();
                Command = new SqlCommand(CauLenh, Connection);
                Adapter = new SqlDataAdapter(Command);
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            return true;
        }
    }
}
