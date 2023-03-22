using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class DataProvider
    {
        private string cnnstr;
        private SqlConnection cnn;
        private SqlCommand cmd;
        public DataProvider() 
        {
            cnnstr = @"Server = DELL;Database = Library; Integrated Security=True";
            cnn= new SqlConnection(cnnstr);
            cmd = cnn.CreateCommand();
        }

        public void Connect()
        {
            cnn.Open();
        }

        public void Disconnect()
        {
            cnn.Close();
        }

        //Lấy 1 giá trị
        public dynamic ExecuteScalar(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery();
        }

        // Lấy 1 bảng: SELECT
        public SqlDataReader ExecuteReader(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteReader();
        }
    }
}
