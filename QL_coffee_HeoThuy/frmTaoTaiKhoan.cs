using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class frmTaoTaiKhoan : Form
    {
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // Set giá trị mặc định
            cmbLoaiTaiKhoan.SelectedIndex = 1; // Nhân viên
            cmbCaLamViec.SelectedIndex = 1;    // Ca Sáng
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            string loaiTaiKhoan = cmbLoaiTaiKhoan.Text;
            int selectedCaIndex = cmbCaLamViec.SelectedIndex;

            // 2. Kiểm tra
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên, Tên đăng nhập và Mật khẩu.");
                return;
            }

            // 3. Chuẩn bị CSDL
            string query = @"
                INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhau, LoaiTaiKhoan, TrangThai, MaCa)
                VALUES (@HoTen, @TenDN, @MatKhau, @Loai, 1, @MaCa)"; // TrangThai = 1 (True)

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@TenDN", tenDangNhap);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau); // (Nên mã hóa mật khẩu)
                cmd.Parameters.AddWithValue("@Loai", loaiTaiKhoan);

                // Xử lý MaCa
                if (selectedCaIndex == 0) // (Không gán)
                {
                    cmd.Parameters.AddWithValue("@MaCa", DBNull.Value);
                }
                else // 1, 2, 3
                {
                    cmd.Parameters.AddWithValue("@MaCa", selectedCaIndex);
                }

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo tài khoản: " + ex.Message);
                }
            }
        }
    }
}