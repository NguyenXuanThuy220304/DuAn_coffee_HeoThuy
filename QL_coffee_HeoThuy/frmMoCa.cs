using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    // Đây là code trong frmMoCa.cs

    public partial class frmMoCa : Form
    {
        // Lấy chuỗi kết nối (bạn có thể tạo 1 class static khác để lưu chuỗi này)
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public frmMoCa()
        {
            InitializeComponent();
        }

        // Sự kiện click nút SÁNG
        private void btnMoCaSang_Click(object sender, EventArgs e)
        {
            MoCa(1);
        }

        // Sự kiện click nút CHIỀU
        private void btnMoCaChieu_Click(object sender, EventArgs e)
        {
            MoCa(2);
        }

        // Sự kiện click nút TỐI
        private void btnMoCaToi_Click(object sender, EventArgs e)
        {
            MoCa(3);
        }

        // Hàm chung để mở ca
        private void MoCa(int maCa)
        {
            // (Bạn nên kiểm tra xem ca trước đã đóng chưa, nhưng tạm thời bỏ qua)

            string query = @"
            INSERT INTO CaLamViec (MaCa, ThoiGianBatDau, TaiKhoanID) 
            VALUES (@MaCa, @ThoiGian, @TaiKhoanID)";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now);
                cmd.Parameters.AddWithValue("@TaiKhoanID", PhienDangNhap.TaiKhoanID); // Lấy ID từ session

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show($"Mở Ca {maCa} thành công!");
                    this.Close(); // Tự động đóng Form
                }
            }
        }
    }
}
