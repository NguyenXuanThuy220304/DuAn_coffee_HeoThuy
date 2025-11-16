using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucKhuVuc : UserControl
    {
        public event EventHandler<TableSelectEventArgs> TableSelected;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public ucKhuVuc()
        {
            InitializeComponent();
        }

        // --- HÀM NÀY ĐÃ ĐƯỢC CẬP NHẬT ĐỂ ĐẾM BÀN ---
        public void TaiDanhSachBan()
        {
            flpKhuVuc.Controls.Clear();

            // Biến đếm
            int tongSoBan = 0;
            int soBanCoKhach = 0;

            string query = @"
                SELECT 
                    b.BanID, b.TenBan, b.TrangThai, 
                    h.GioVao, h.TongTien, h.HoaDonID
                FROM Ban AS b
                LEFT JOIN HoaDon AS h ON b.BanID = h.BanID AND h.TrangThai = 0";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tongSoBan++; // Đếm tổng số bàn
                        ucTheBan theBan = new ucTheBan();
                        theBan.BanID = Convert.ToInt32(reader["BanID"]);

                        string ten = reader["TenBan"].ToString();
                        string trangThai = reader["TrangThai"].ToString();
                        string thoiGian = "";
                        string gia = "";

                        if (reader["GioVao"] != DBNull.Value)
                        {
                            soBanCoKhach++; // Đếm bàn có khách
                            theBan.HoaDonID = Convert.ToInt32(reader["HoaDonID"]);
                            theBan.GioVao = Convert.ToDateTime(reader["GioVao"]);
                            trangThai = "Có khách";
                            thoiGian = theBan.GioVao.ToString("HH:mm");
                            gia = Convert.ToDecimal(reader["TongTien"]).ToString("N0") + " đ";
                        }
                        else
                        {
                            theBan.HoaDonID = -1;
                        }

                        // (Hàm này là logic ẩn/hiện "Giá", "Thời gian" từ lần trước)
                        theBan.CapNhatThongTin(ten, thoiGian, gia, trangThai);

                        theBan.Click += ucTheBan_Click;
                        flpKhuVuc.Controls.Add(theBan);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách bàn: " + ex.Message);
                }
            } // Kết nối tự động đóng ở đây

            // === CẬP NHẬT LABEL THỐNG KÊ ===
            // (Thực hiện sau khi vòng lặp kết thúc)
            int soBanTrong = tongSoBan - soBanCoKhach;
            lblThongKeBan.Text = $"Tổng: {tongSoBan} bàn   |   Trống: {soBanTrong}   |   Có khách: {soBanCoKhach}";
        }

        // (Các hàm ucTheBan_Click và TaoHoaDonMoi giữ nguyên)
        private void ucTheBan_Click(object sender, EventArgs e)
        {
            ucTheBan clickedBan = sender as ucTheBan;
            int idHoaDon = clickedBan.HoaDonID;
            DateTime gioVao = clickedBan.GioVao;

            if (idHoaDon == -1)
            {
                gioVao = DateTime.Now;
                idHoaDon = TaoHoaDonMoi(clickedBan.BanID, gioVao);
                if (idHoaDon == -1) return;
            }

            TableSelected?.Invoke(this, new TableSelectEventArgs
            {
                BanID = clickedBan.BanID,
                TenBan = clickedBan.TenBan,
                HoaDonID = idHoaDon,
                GioVao = gioVao
            });
        }

        private int TaoHoaDonMoi(int banID, DateTime gioVao)
        {
            string query = @"
                INSERT INTO HoaDon (BanID, TaiKhoanID, GioVao, TrangThai, GiamGia, TongTien) 
                VALUES (@BanID, @TaiKhoanID, @GioVao, 0, 0, 0);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BanID", banID);
                cmd.Parameters.AddWithValue("@GioVao", gioVao);
                cmd.Parameters.AddWithValue("@TaiKhoanID", PhienDangNhap.TaiKhoanID);
                try
                {
                    conn.Open();
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tạo HĐ: " + ex.Message); return -1; }
            }
        }
    }
}