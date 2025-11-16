using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
// Thêm thư viện Chart
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_coffee_HeoThuy
{
    public partial class ucBaoCao : UserControl
    {
        public event EventHandler GoBack;
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public ucBaoCao()
        {
            InitializeComponent();
            btnBack.Click += (s, e) => GoBack?.Invoke(this, EventArgs.Empty);
            btnLoc.Click += btnLoc_Click;
        }

        // Hàm được Form Kaavan gọi
        public void LoadData()
        {
            // Mặc định tải 30 ngày qua
            dtpBatDau.Value = DateTime.Now.AddDays(-30).Date;
            dtpKetThuc.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1); // 23:59:59

            // Chạy báo cáo
            RunReports();
        }

        // Nút Lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            RunReports();
        }

        // Hàm chạy tất cả báo cáo
        private void RunReports()
        {
            DateTime ngayBatDau = dtpBatDau.Value.Date;
            DateTime ngayKetThuc = dtpKetThuc.Value.Date.AddDays(1).AddSeconds(-1); // 23:59:59

            LoadKPIs(ngayBatDau, ngayKetThuc);
            LoadChartDoanhThu(ngayBatDau, ngayKetThuc);
            LoadMatHangBanChay(ngayBatDau, ngayKetThuc);
            LoadKhuyenMaiSuDung(ngayBatDau, ngayKetThuc);
        }

        // Tải 3 ô KPI
        private void LoadKPIs(DateTime batDau, DateTime ketThuc)
        {
            string query = @"
                SELECT 
                    ISNULL(SUM(TongTien), 0) AS TongDoanhThu, 
                    COUNT(HoaDonID) AS TongHoaDon
                FROM HoaDon 
                WHERE TrangThai = 1 AND GioRa BETWEEN @BatDau AND @KetThuc";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BatDau", batDau);
                cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    decimal tongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                    int tongHoaDon = Convert.ToInt32(reader["TongHoaDon"]);
                    decimal trungBinhBill = (tongHoaDon == 0) ? 0 : tongDoanhThu / tongHoaDon;

                    lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
                    lblTongHoaDon.Text = tongHoaDon.ToString();
                    lblTrungBinhBill.Text = trungBinhBill.ToString("N0") + " đ";
                }
            }
        }

        // Tải biểu đồ Doanh thu
        private void LoadChartDoanhThu(DateTime batDau, DateTime ketThuc)
        {
            string query = @"
                SELECT 
                    CAST(GioRa AS DATE) as Ngay, 
                    SUM(TongTien) as DoanhThu 
                FROM HoaDon 
                WHERE TrangThai = 1 AND GioRa BETWEEN @BatDau AND @KetThuc 
                GROUP BY CAST(GioRa AS DATE) 
                ORDER BY Ngay";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BatDau", batDau);
                cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            // Gán vào Chart
            chartDoanhThu.Series["Doanh thu"].Points.Clear();
            chartDoanhThu.Series["Doanh thu"].XValueMember = "Ngay";
            chartDoanhThu.Series["Doanh thu"].XValueType = ChartValueType.Date;
            chartDoanhThu.Series["Doanh thu"].YValueMembers = "DoanhThu";
            chartDoanhThu.Series["Doanh thu"].YValueType = ChartValueType.Double;
            chartDoanhThu.DataSource = dt;
        }

        // Tải Mặt hàng bán chạy
        private void LoadMatHangBanChay(DateTime batDau, DateTime ketThuc)
        {
            string query = @"
                SELECT 
                    TOP 10 s.TenSanPham, 
                    SUM(c.SoLuong) as TongSoLuong
                FROM ChiTietHoaDon c
                JOIN HoaDon h ON c.HoaDonID = h.HoaDonID
                JOIN Menu m ON c.MenuID = m.MenuID
                JOIN SanPham s ON m.SanPhamID = s.SanPhamID
                WHERE h.TrangThai = 1 AND h.GioRa BETWEEN @BatDau AND @KetThuc
                GROUP BY s.TenSanPham
                ORDER BY TongSoLuong DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BatDau", batDau);
                cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvMatHangChay.DataSource = dt;

                // (Tùy chỉnh cột)
                dgvMatHangChay.Columns["TenSanPham"].HeaderText = "Tên mặt hàng";
                dgvMatHangChay.Columns["TongSoLuong"].HeaderText = "Số lượng bán";
            }
        }

        // Tải Khuyến mãi
        private void LoadKhuyenMaiSuDung(DateTime batDau, DateTime ketThuc)
        {
            // (Hàm này yêu cầu bạn đã làm Bước 4: Sửa ucBanHang.cs)
            string query = @"
                SELECT 
                    k.TenChuongTrinh, 
                    COUNT(h.HoaDonID) as SoLanDung, 
                    SUM(h.GiamGia) as TongGiam
                FROM HoaDon h
                JOIN KhuyenMai k ON h.KhuyenMaiID = k.KhuyenMaiID
                WHERE h.TrangThai = 1 AND h.GioRa BETWEEN @BatDau AND @KetThuc
                GROUP BY k.TenChuongTrinh
                ORDER BY SoLanDung DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BatDau", batDau);
                cmd.Parameters.AddWithValue("@KetThuc", ketThuc);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKhuyenMai.DataSource = dt;

                // (Tùy chỉnh cột)
                dgvKhuyenMai.Columns["TenChuongTrinh"].HeaderText = "Tên khuyến mãi";
                dgvKhuyenMai.Columns["SoLanDung"].HeaderText = "Lần dùng";
                dgvKhuyenMai.Columns["TongGiam"].HeaderText = "Tổng giảm";
                dgvKhuyenMai.Columns["TongGiam"].DefaultCellStyle.Format = "N0";
            }
        }
    }
}