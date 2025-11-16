using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucQuanLyCa : UserControl
    {
        // Sự kiện (event) để báo cho Form Kaavan là "Tôi đã xong, hãy quay lại"
        public event EventHandler GoBack;
        public event EventHandler ViewShiftListClicked; // <<< THÊM DÒNG NÀY
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // Biến để lưu ID của ca hiện tại
        private int idCaLamViecHienTai = -1;
        private DateTime thoiGianBatDauCa;

        public ucQuanLyCa()
        {
            InitializeComponent();

            // Gán sự kiện click cho các nút
            btnBack.Click += btnBack_Click;
            btnDongCa.Click += btnDongCa_Click;
            btnXemDanhSach.Click += btnXemDanhSach_Click; // <<< THÊM DÒNG NÀY
        }

        // Nút quay lại '<-'
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Bắn sự kiện "GoBack" lên Form Kaavan
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        // Hàm này được Kaavan/ucThuocTinh gọi để tải dữ liệu
        public void LoadData()
        {
            HienThiThongTinCa();
            LayDonHangTrongCa();
        }

        // Tải thông tin ca hiện tại
        private void HienThiThongTinCa()
        {
            string query = @"
        SELECT TOP 1 c.CaLamViecID, c.MaCa, c.ThoiGianBatDau, t.HoTen, t.TenDangNhap
        FROM CaLamViec AS c
        JOIN TaiKhoan AS t ON c.TaiKhoanID = t.TaiKhoanID
        WHERE c.ThoiGianKetThuc IS NULL 
        ORDER BY c.ThoiGianBatDau DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // === CA ĐANG MỞ ===
                        this.idCaLamViecHienTai = Convert.ToInt32(reader["CaLamViecID"]);
                        this.thoiGianBatDauCa = Convert.ToDateTime(reader["ThoiGianBatDau"]);

                        lblMaCa.Text = reader["MaCa"].ToString();
                        lblTenNhanVien.Text = reader["HoTen"].ToString();
                        lblEmailNhanVien.Text = reader["TenDangNhap"].ToString();
                        lblGioMoCa.Text = this.thoiGianBatDauCa.ToString("dd thg MM, yyyy, HH:mm");
                        lblGioDongCa.Text = "Đang mở";

                        // Đổi nút thành "Đóng ca"
                        btnDongCa.Text = "Đóng ca";
                        btnDongCa.Enabled = true;

                        // Hiển thị các tab
                        tabControlMain.Visible = true;
                        btnXemDanhSach.Enabled = true;
                        lnkChiTietCa.Visible = true;
                    }
                    else
                    {
                        // === KHÔNG CÓ CA MỞ ===
                        this.idCaLamViecHienTai = -1;

                        lblMaCa.Text = "N/A";
                        lblTenNhanVien.Text = "N/A";
                        lblEmailNhanVien.Text = "N/A";
                        lblGioMoCa.Text = "Chưa mở ca";
                        lblGioDongCa.Text = "Chưa mở ca";

                        // Đổi nút thành "Mở ca"
                        btnDongCa.Text = "Mở ca";
                        btnDongCa.Enabled = true; // Bật nút để mở ca

                        // Ẩn các tab
                        tabControlMain.Visible = false;
                        btnXemDanhSach.Enabled = true;
                        lnkChiTietCa.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải thông tin ca: " + ex.Message);
                }
            }
        }

        // Tải danh sách đơn hàng vào DataGridView
        private void LayDonHangTrongCa()
        {
            if (this.idCaLamViecHienTai == -1)
            {
                dgvDonHang.DataSource = null; // Xóa lưới
                return;
            }

            // Lấy tất cả hóa đơn ĐÃ THANH TOÁN (TrangThai = 1)
            // có thời gian VÀO (GioVao) nằm trong ca này.
            string query = @"
                SELECT 
                    HoaDonID, 
                    GioVao, 
                    GioRa, 
                    TongTien
                FROM HoaDon
                WHERE TrangThai = 1 AND GioVao >= @ThoiGianBatDau";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", this.thoiGianBatDauCa);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Hiển thị lên DataGridView
                dgvDonHang.DataSource = dt;

                // (Tùy chỉnh cột)
                dgvDonHang.Columns["HoaDonID"].HeaderText = "Mã HĐ";
                dgvDonHang.Columns["GioVao"].HeaderText = "Giờ vào";
                dgvDonHang.Columns["GioRa"].HeaderText = "Giờ ra";
                dgvDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            }
        }

        // Nút "Đóng ca"
        private void btnDongCa_Click(object sender, EventArgs e)
        {
            // Kiểm tra văn bản của nút
            if (btnDongCa.Text == "Đóng ca")
            {
                // --- Logic Đóng Ca (như cũ) ---
                if (this.idCaLamViecHienTai == -1) return;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ca này?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DongCaTrongCSDL();
                    MessageBox.Show("Đã đóng ca thành công!");
                    // Tải lại chính nó để chuyển sang trạng thái "Mở ca"
                    LoadData();
                }
            }
            else // Nếu nút đang là "Mở ca"
            {
                // --- Logic Mở Ca (Constraint 3) ---
                // (Code này gọi frmMoCa, đã có phân quyền theo ca)
                frmMoCa formMoCa = new frmMoCa();
                formMoCa.ShowDialog();

                // Tải lại dữ liệu sau khi Form Mở Ca đóng
                // Nó sẽ tự động chuyển sang trạng thái "Đóng ca" nếu mở thành công
                LoadData();
            }
        }

        // Hàm CSDL để đóng ca
        private void DongCaTrongCSDL()
        {
            string query = "UPDATE CaLamViec SET ThoiGianKetThuc = @GioDong WHERE CaLamViecID = @CaID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@GioDong", DateTime.Now);
                cmd.Parameters.AddWithValue("@CaID", this.idCaLamViecHienTai);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Khi bấm nút "Xem danh sách ca"
        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            // Bắn sự kiện lên Form Kaavan
            ViewShiftListClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}