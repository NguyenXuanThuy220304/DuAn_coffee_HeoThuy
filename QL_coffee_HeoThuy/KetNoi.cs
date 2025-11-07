// Xóa bớt các thư viện 'using' không cần thiết
using System;
using Microsoft.Data.SqlClient; // Giữ thư viện này vì bạn đang dùng
using System.Data; // Thêm thư viện này để dùng ConnectionState

namespace QL_coffee_HeoThuy
{
    internal class KetNoi
    {
        // Giữ nguyên chuỗi kết nối của bạn
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True");

        // Thêm hàm để các form khác có thể lấy kết nối
        public SqlConnection getConnection()
        {
            return conn;
        }

        // Hàm để mở kết nối
        public void moKetNoi()
        {
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi mở kết nối: " + ex.Message);
                }
            }
        }

        // Hàm để đóng kết nối
        public void dongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}