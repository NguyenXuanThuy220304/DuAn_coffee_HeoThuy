using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class frmMoCa : Form
    {
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public frmMoCa()
        {
            InitializeComponent();
        }

        // THÊM HÀM FORM_LOAD NÀY
        private void frmMoCa_Load(object sender, EventArgs e)
        {
            PhanQuyenMoCa();
        }

        // HÀM MỚI: Kiểm tra quyền và ẩn/hiện nút
        private void PhanQuyenMoCa()
        {
            // Đọc quyền từ Session
            string chucVu = PhienDangNhap.ChucVu;
            int maCa = PhienDangNhap.MaCa;

            if (chucVu == "Quản lý")
            {
                // Quản lý: Hiện tất cả
                btnMoCaSang.Enabled = true;
                btnMoCaChieu.Enabled = true;
                btnMoCaToi.Enabled = true;
            }
            else // Nếu là Nhân viên
            {
                // Mặc định: Tắt tất cả
                btnMoCaSang.Enabled = false;
                btnMoCaChieu.Enabled = false;
                btnMoCaToi.Enabled = false;

                // Chỉ bật ca được gán
                if (maCa == 1)
                {
                    btnMoCaSang.Enabled = true;
                }
                else if (maCa == 2)
                {
                    btnMoCaChieu.Enabled = true;
                }
                else if (maCa == 3)
                {
                    btnMoCaToi.Enabled = true;
                }
                // (Nếu MaCa = 0 hoặc khác, nhân viên đó không được mở ca nào)
            }
        }

        // (3 hàm click 'btnMoCa...' giữ nguyên như cũ)

        private void btnMoCaSang_Click(object sender, EventArgs e)
        {
            MoCa(1);
        }

        private void btnMoCaChieu_Click(object sender, EventArgs e)
        {
            MoCa(2);
        }

        private void btnMoCaToi_Click(object sender, EventArgs e)
        {
            MoCa(3);
        }

        // Hàm chung để mở ca
        private void MoCa(int maCa)
        {
            // (Bạn nên kiểm tra xem ca trước đã đóng chưa)

            string query = @"
                INSERT INTO CaLamViec (MaCa, ThoiGianBatDau, TaiKhoanID) 
                VALUES (@MaCa, @ThoiGian, @TaiKhoanID)";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaCa", maCa);
                cmd.Parameters.AddWithValue("@ThoiGian", DateTime.Now);
                cmd.Parameters.AddWithValue("@TaiKhoanID", PhienDangNhap.TaiKhoanID);

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