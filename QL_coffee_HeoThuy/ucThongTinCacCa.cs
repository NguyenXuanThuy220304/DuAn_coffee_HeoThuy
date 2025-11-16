using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucThongTinCacCa : UserControl
    {
        // Sự kiện (event) để báo cho Form Kaavan là "Tôi đã xong, hãy quay lại"
        public event EventHandler GoBack;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public ucThongTinCacCa()
        {
            InitializeComponent();

            // Gán sự kiện
            btnBack.Click += btnBack_Click;
            btnTimKiem.Click += btnTimKiem_Click;
        }

        // Nút quay lại '<-'
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Bắn sự kiện "GoBack" lên Form Kaavan
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        // Hàm này được Kaavan gọi khi UC này được hiển thị
        public void LoadData()
        {
            // Mặc định tải 7 ngày qua
            dtpBatDau.Value = DateTime.Now.AddDays(-7).Date; // Bắt đầu từ 00:00
            dtpKetThuc.Value = DateTime.Now;

            // Chạy tìm kiếm
            TaiDanhSachCaDaDong(dtpBatDau.Value, dtpKetThuc.Value);
        }

        // Nút "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDanhSachCaDaDong(dtpBatDau.Value, dtpKetThuc.Value);
        }

        // Hàm chính: Lấy dữ liệu và tính toán
        // (Trong file ucThongTinCacCa.cs)

        // THAY THẾ HÀM NÀY:
        private void TaiDanhSachCaDaDong(DateTime batDau, DateTime ketThuc)
        {
            // Câu SQL này đã được sửa lại:
            // 1. Bỏ "WHERE c.ThoiGianKetThuc IS NOT NULL" -> để lấy cả ca đang mở.
            // 2. Sửa JOIN: Doanh thu của ca đang mở sẽ được tính từ lúc mở ca (GioVao) 
            //    cho đến thời điểm hiện tại (GETDATE()).
            // 3. Sửa WHERE: Lọc các ca BẮT ĐẦU trong khoảng thời gian đã chọn.
            string query = @"
        SELECT 
            c.MaCa AS N'Mã Ca',
            t.TenDangNhap AS N'Nhân viên',
            c.ThoiGianBatDau AS N'Giờ mở ca',
            c.ThoiGianKetThuc AS N'Giờ đóng ca',
            COUNT(h.HoaDonID) AS N'Số đơn hàng',
            ISNULL(SUM(h.TongTien), 0) AS N'Doanh thu'
        FROM CaLamViec AS c
        JOIN TaiKhoan AS t ON c.TaiKhoanID = t.TaiKhoanID
        
        -- Doanh thu được tính = các hóa đơn (Đã thanh toán) 
        -- có giờ ra (GioRa) nằm trong khoảng thời gian ca làm việc
        LEFT JOIN HoaDon AS h 
            ON h.TrangThai = 1 
            AND h.GioRa BETWEEN c.ThoiGianBatDau AND ISNULL(c.ThoiGianKetThuc, GETDATE())
            
        WHERE 
            -- Lấy tất cả ca (đã đóng HOẶC đang mở)
            -- có thời gian BẮT ĐẦU nằm trong khoảng đã chọn
            c.ThoiGianBatDau BETWEEN @BatDau AND @KetThuc
            
        GROUP BY 
            c.CaLamViecID, c.MaCa, t.TenDangNhap, c.ThoiGianBatDau, c.ThoiGianKetThuc
        ORDER BY 
            c.ThoiGianBatDau DESC"; // Sắp xếp ca mới nhất lên đầu

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BatDau", batDau);
                cmd.Parameters.AddWithValue("@KetThuc", ketThuc);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDanhSachCa.DataSource = dt;

                // Tùy chỉnh định dạng cột
                dgvDanhSachCa.Columns["Doanh thu"].DefaultCellStyle.Format = "N0";
                dgvDanhSachCa.Columns["Giờ mở ca"].DefaultCellStyle.Format = "dd/MM HH:mm";
                dgvDanhSachCa.Columns["Giờ đóng ca"].DefaultCellStyle.Format = "dd/MM HH:mm";
            }
        }
    }
}