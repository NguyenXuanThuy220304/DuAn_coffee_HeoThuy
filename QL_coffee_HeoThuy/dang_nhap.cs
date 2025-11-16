using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class dang_nhap : Form
    {
        // Giả sử bạn có class KetNoi.cs
        KetNoi kn = new KetNoi();

        public dang_nhap()
        {
            // Chỉ gọi hàm InitializeComponent (không định nghĩa)
            InitializeComponent();
        }

        private void dang_nhap_Load(object sender, EventArgs e)
        {
            txttk.Focus();
        }

        // Đây là sự kiện click của nút "Đăng nhập"
        private void button1_Click(object sender, EventArgs e)
        {
            txttk.Focus();
            string taikhoan = txttk.Text;
            string matkhau = txtmk.Text;
            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
                return;
            }
            try
            {
                kn.moKetNoi();

                // Lấy TaiKhoanID, LoaiTaiKhoan, và MaCa
                string query = "SELECT TaiKhoanID, LoaiTaiKhoan, MaCa FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass AND TrangThai = 1";

                SqlCommand cmd = new SqlCommand(query, kn.getConnection());
                cmd.Parameters.AddWithValue("@user", taikhoan);
                cmd.Parameters.AddWithValue("@pass", matkhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // === LƯU VÀO PHIÊN ĐĂNG NHẬP (SESSION) ===
                    PhienDangNhap.TaiKhoanID = Convert.ToInt32(reader["TaiKhoanID"]);
                    PhienDangNhap.ChucVu = reader["LoaiTaiKhoan"].ToString();
                    PhienDangNhap.TenDangNhap = taikhoan;

                    if (reader["MaCa"] != DBNull.Value)
                    {
                        PhienDangNhap.MaCa = Convert.ToInt32(reader["MaCa"]);
                    }
                    else
                    {
                        PhienDangNhap.MaCa = 0; // 0 = Quản lý
                    }

                    MessageBox.Show("Đăng nhập thành công! Vai trò: " + PhienDangNhap.ChucVu, "Chào mừng");

                    Kaavan f_main = new Kaavan();
                    f_main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi");
            }
            finally
            {
                kn.dongKetNoi();
            }
        }
    }
}