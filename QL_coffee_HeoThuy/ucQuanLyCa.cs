using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    // ĐẢM BẢO BẠN CÓ DÒNG NÀY ( : UserControl )
    public partial class ucQuanLyCa : UserControl
    {
        // Sự kiện (event) để báo cho Form Kaavan
        public event EventHandler GoBack;
        public event EventHandler ViewShiftListClicked;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        private int idCaLamViecHienTai = -1;
        private DateTime thoiGianBatDauCa;

        public ucQuanLyCa()
        {
            InitializeComponent(); // Dòng này gọi file .Designer.cs

            // Gán sự kiện click cho các nút
            btnBack.Click += btnBack_Click;
            btnDongCa.Click += btnDongCa_Click;
            btnXemDanhSach.Click += btnXemDanhSach_Click;
        }

        // Nút quay lại '<-'
        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        // Nút "Xem danh sách ca"
        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            ViewShiftListClicked?.Invoke(this, EventArgs.Empty);
        }

        // Hàm này được Kaavan/ucThuocTinh gọi để tải dữ liệu
        public void LoadData()
        {
            HienThiThongTinCa();
            LayDonHangTrongCa();
        }

        // Tải thông tin ca hiện tại (Logic Mở/Đóng)
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

                        btnDongCa.Text = "Đóng ca";
                        btnDongCa.Enabled = true;

                        tabControlMain.Visible = true;
                        btnXemDanhSach.Enabled = true;
                        
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

                        btnDongCa.Text = "Mở ca";
                        btnDongCa.Enabled = true;

                        tabControlMain.Visible = false;
                        btnXemDanhSach.Enabled = false;
                        
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

            string query = @"
                SELECT HoaDonID, GioVao, GioRa, TongTien
                FROM HoaDon
                WHERE TrangThai = 1 AND GioVao >= @ThoiGianBatDau";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ThoiGianBatDau", this.thoiGianBatDauCa);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDonHang.DataSource = dt;

                dgvDonHang.Columns["HoaDonID"].HeaderText = "Mã HĐ";
                dgvDonHang.Columns["GioVao"].HeaderText = "Giờ vào";
                dgvDonHang.Columns["GioRa"].HeaderText = "Giờ ra";
                dgvDonHang.Columns["TongTien"].HeaderText = "Tổng tiền";
            }
        }

        // Nút "Đóng ca" / "Mở ca"
        private void btnDongCa_Click(object sender, EventArgs e)
        {
            if (btnDongCa.Text == "Đóng ca")
            {
                if (this.idCaLamViecHienTai == -1) return;
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ca này?",
                                                      "Xác nhận",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DongCaTrongCSDL();
                    MessageBox.Show("Đã đóng ca thành công!");
                    LoadData();
                }
            }
            else // Nếu nút đang là "Mở ca"
            {
                frmMoCa formMoCa = new frmMoCa();
                formMoCa.ShowDialog();
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
    }
}