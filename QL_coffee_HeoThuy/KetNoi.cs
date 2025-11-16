using Microsoft.Data.SqlClient;
using System;

namespace QL_coffee_HeoThuy
{
    public class KetNoi
    {
        private SqlConnection conn;
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public KetNoi()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void moKetNoi()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void dongKetNoi()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}