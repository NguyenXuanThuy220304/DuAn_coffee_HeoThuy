using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucThuocTinh : UserControl
    {
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // Sự kiện (event) để báo cho Kaavan
        public event EventHandler ManageShiftClicked;
        public event EventHandler LoggedOut;
        public event EventHandler ChuongTrinhBanHangClicked; // <<< SỰ KIỆN MỚI
        public ucThuocTinh()
        {
            InitializeComponent();

            // Gán sự kiện click cho các nút
            // (Đảm bảo tên control trong Designer khớp)
            panQuanLyCa.Click += btnQuanLyCa_Click;
            panTaoTaiKhoan.Click += panTaoTaiKhoan_Click;

            // Gán luôn cho các Label bên trong (nếu có)
            // (Tên Label bên trong 'panQuanLyCa')
            lblma.Click += (s, e) => btnQuanLyCa_Click(s, e);
            lbltime.Click += (s, e) => btnQuanLyCa_Click(s, e);
            // (Tên Label bên trong 'panTaoTaiKhoan')
            // labelTaoTaiKhoan.Click += (s, e) => panTaoTaiKhoan_Click(s, e);
            panChuongTrinh.Click += panChuongTrinh_Click;
        }

        // Hàm này public để Kaavan.cs có thể gọi
        public void HienThiDuLieu()
        {
            HienThiThongTinCa();
            PhanQuyen();
        }

        // === HÀM PHÂN QUYỀN (ĐÃ BẬT LẠI) ===
        private void PhanQuyen()
        {
            // (Đảm bảo bạn có Label 'lblChucVu' trong Designer)
            lblChucVu.Text = PhienDangNhap.ChucVu;

            bool laQuanLy = (PhienDangNhap.ChucVu == "Quản lý");
            // 1. Bật/Tắt các nút
            panTaoTaiKhoan.Enabled = laQuanLy;
            panBaoCao.Enabled = laQuanLy;
            panChuongTrinh.Enabled = laQuanLy;
            panThucDon.Enabled = laQuanLy;

            // Nút Quản lý ca luôn được BẬT cho cả 2
            panQuanLyCa.Enabled = true;

            // 2. Đổi màu nút bị tắt cho dễ nhìn
            if (!laQuanLy)
            {
                panTaoTaiKhoan.BackColor = Color.Gray;
                panBaoCao.BackColor = Color.Gray;
                panChuongTrinh.BackColor = Color.Gray;
                panThucDon.BackColor = Color.Gray;
            }
            else
            {
                // (Set lại màu gốc nếu là Quản lý)
                panTaoTaiKhoan.BackColor = SystemColors.Control;
                panBaoCao.BackColor = SystemColors.Control;
                panChuongTrinh.BackColor = SystemColors.Control;
                panThucDon.BackColor = SystemColors.Control;
            }
        }

        // === HÀM TẢI CA (ĐÃ BẬT LẠI) ===
        // (Trong file ucThuocTinh.cs)

        // SỬA HÀM NÀY
        private void HienThiThongTinCa()
        {
            // (Chúng ta vẫn cần hàm này để cập nhật Label
            // trên màn hình ucThuocTinh)
            string query = @"
        SELECT TOP 1 MaCa, ThoiGianBatDau 
        FROM CaLamViec 
        WHERE ThoiGianKetThuc IS NULL 
        ORDER BY ThoiGianBatDau DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblma.Text = reader["MaCa"].ToString();
                        lbltime.Text = Convert.ToDateTime(reader["ThoiGianBatDau"]).ToString("HH:mm dd/MM");
                    }
                    else
                    {
                        lblma.Text = "N/A";
                        lbltime.Text = "Chưa mở ca";
                    }
                }
                catch (Exception) { /* Bỏ qua lỗi */ }
            }
        }

        // SỬA HÀM NÀY
        private void btnQuanLyCa_Click(object sender, EventArgs e)
        {
            // Luôn luôn bắn sự kiện
            // Form Kaavan sẽ quyết định mở ucQuanLyCa
            ManageShiftClicked?.Invoke(this, EventArgs.Empty);
        }

        private void panTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            // Mở Form tạo tài khoản
            frmTaoTaiKhoan formTaoTK = new frmTaoTaiKhoan();
            formTaoTK.ShowDialog(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panThoat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // 1. Hỏi xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Bắn sự kiện "LoggedOut" lên cho Form Kaavan
                LoggedOut?.Invoke(this, EventArgs.Empty);
            }
        }
        private void panChuongTrinh_Click(object sender, EventArgs e)
        {
            // Bắn sự kiện lên Form Kaavan
            ChuongTrinhBanHangClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}