﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DaiLyXeMay
{
    class GetData
    {
        static SqlConnection connection;
        static string query;
        static SqlDataAdapter adapter;
        static SqlCommand command;
        public static DataSet GetDanhSach(string CauLenh)
        {
            DataSet data = new DataSet();

            // SqlConnection
            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(CauLenh, connection);
                command = new SqlCommand(CauLenh, connection);
                adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
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
            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                command = new SqlCommand(CauLenh, connection);
                adapter = new SqlDataAdapter(command);
                object get_Data = command.ExecuteScalar();
                connection.Close();
                return get_Data;
            }

        }
        public static void update_Data(string CauLenh)
        {
            using (connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                command = new SqlCommand(CauLenh, connection);
                adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
