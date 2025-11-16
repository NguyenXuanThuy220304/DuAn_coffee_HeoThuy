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
    public partial class dang_nhap : Form
    {
        public dang_nhap()
        {
            InitializeComponent();

        }
        KetNoi kn= new KetNoi();
        private void dang_nhap_Load(object sender, EventArgs e)
        {
            txttk.Focus();
        }

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
                kn.moKetNoi(); // Mở kết nối

                // Sửa 1: Lấy cả TaiKhoanID và LoaiTaiKhoan
                string query = "SELECT TaiKhoanID, LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass AND TrangThai = 1"; // Giả sử TrangThai = 1 là "True"

                SqlCommand cmd = new SqlCommand(query, kn.getConnection());
                cmd.Parameters.AddWithValue("@user", taikhoan);
                cmd.Parameters.AddWithValue("@pass", matkhau);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // Nếu có 1 dòng kết quả (đăng nhập đúng)
                {
                    // Sửa 2: LƯU VÀO PHIÊN ĐĂNG NHẬP (SESSION)
                    PhienDangNhap.TaiKhoanID = Convert.ToInt32(reader["TaiKhoanID"]);
                    PhienDangNhap.ChucVu = reader["LoaiTaiKhoan"].ToString();
                    PhienDangNhap.TenDangNhap = taikhoan;

                    // Lấy từ session để hiển thị
                    string loaiTaiKhoan = PhienDangNhap.ChucVu;
                    MessageBox.Show("Đăng nhập thành công! Vai trò: " + loaiTaiKhoan, "Chào mừng");

                    // Mở form Trang_Chu và ẩn form này đi
                    Kaavan f_main = new Kaavan();
                    f_main.Show();
                    this.Hide();
                }
                else // Nếu không có dòng nào (sai user hoặc pass)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi");
                }

                reader.Close(); // Đóng reader
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi");
            }
            finally
            {
                kn.dongKetNoi(); // Luôn đóng kết nối
            }
        }
    }
}
