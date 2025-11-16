using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class frmTaoGiamGia : Form
    {
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public frmTaoGiamGia()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenCT = txtTenCT.Text;
            string chiTiet = txtChiTiet.Text;
            DateTime ngayBatDau = dtpBatDau.Value;
            DateTime ngayKetThuc = dtpKetThuc.Value;

            if (string.IsNullOrEmpty(tenCT))
            {
                MessageBox.Show("Vui lòng nhập Tên giảm giá.");
                return;
            }

            // Lưu vào CSDL
            string query = @"
                INSERT INTO KhuyenMai (TenChuongTrinh, LoaiChuongTrinh, ChiTiet, NgayBatDau, NgayKetThuc, TrangThai)
                VALUES (@Ten, @Loai, @ChiTiet, @BatDau, @KetThuc, 1)";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Ten", tenCT);
                cmd.Parameters.AddWithValue("@Loai", "Giảm giá"); // Hardcode
                cmd.Parameters.AddWithValue("@ChiTiet", chiTiet);
                cmd.Parameters.AddWithValue("@BatDau", ngayBatDau);
                cmd.Parameters.AddWithValue("@KetThuc", ngayKetThuc);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo giảm giá thành công!");
                    this.Close(); // Đóng form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu giảm giá: " + ex.Message);
                }
            }
        }
    }
}