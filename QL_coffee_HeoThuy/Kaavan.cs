using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QL_coffee_HeoThuy
{

    public partial class Kaavan : Form
    {
        public Kaavan()
        {
            InitializeComponent();
        }
        private void CapNhatGiaoDienTongTien()
        {
            string giaText = this.tongTienHienTai.ToString("N0") + " đ";

            // === SỬA LỖI (0) ===
            // Tính toán lại tổng số lượng từ cột "SL"
            int soLuongMon = 0;
            foreach (ListViewItem item in lvGioHang.Items)
            {
                // Lấy text từ cột 2 (index 1) và cộng dồn
                soLuongMon += int.Parse(item.SubItems[1].Text);
            }
            // ====================

            // Cập nhật Header
            // Giả sử Label của bạn tên là lblGioHangInfo
            lblGioHangInfo.Text = $"Giỏ hàng ({soLuongMon}) - {giaText}";

            // Cập nhật Nút Thanh toán
            // Giả sử nút của bạn tên là btnThanhToan
            btnThanhToan.Text = $"Thanh toán\n{giaText}";
        }

        // Hàm này để xóa sạch giỏ hàng khi thoát
        private void XoaSachGioHang()
        {
            lvGioHang.Items.Clear();
            this.tongTienHienTai = 0;
            CapNhatGiaoDienTongTien();
        }
        private decimal tongTienHienTai = 0; // <<< THÊM BIẾN NÀY
        private int idBanDangChon = -1;       // ID của bàn đang được chọn
        private int idHoaDonHienTai = -1;  // ID của hóa đơn đang xử lý
        private string tenBanDangChon = "";  // Tên bàn đang chọn
        private DateTime thoiGianMoBan;      // Thời gian mở bàn
        private List<SanPham> LaySanPhamTuCSDL(string tenDanhMuc)
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();

            // 1. Lấy chuỗi kết nối
            string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

            // 2. Viết câu truy vấn
            string cauTruyVanSQL = @"
        SELECT 
            m.MenuID, 
            s.TenSanPham, 
            m.KichThuoc, 
            m.DonGia, 
            s.MoTa  -- <<< THAY ĐỔI 1: Lấy từ cột MoTa
        FROM Menu AS m
        INNER JOIN SanPham AS s ON m.SanPhamID = s.SanPhamID
        INNER JOIN DanhMuc AS d ON s.DanhMucID = d.DanhMucID
        WHERE d.TenDanhMuc = @TenDanhMuc";

            // 3. Tạo kết nối và thực thi
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            {
                using (SqlCommand lenh = new SqlCommand(cauTruyVanSQL, ketNoi))
                {
                    lenh.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);

                    try
                    {
                        ketNoi.Open();
                        using (SqlDataReader dauDoc = lenh.ExecuteReader())
                        {
                            // 4. Đọc từng dòng dữ liệu
                            while (dauDoc.Read())
                            {
                                SanPham sanPham = new SanPham();

                                sanPham.ID_Menu = Convert.ToInt32(dauDoc["MenuID"]);
                                sanPham.Gia = Convert.ToDecimal(dauDoc["DonGia"]);

                                // <<< THAY ĐỔI 2: Đọc từ cột MoTa
                                sanPham.DuongDanAnh = dauDoc["MoTa"].ToString();

                                // --- PHẦN KÍCH THƯỚC (ĐÃ CÓ SẴN) ---
                                // Gộp Tên sản phẩm và Kích thước
                                string tenSP = dauDoc["TenSanPham"].ToString();
                                string kichThuoc = dauDoc["KichThuoc"].ToString();
                                sanPham.Ten = string.IsNullOrEmpty(kichThuoc) ? tenSP : $"{tenSP} ({kichThuoc})";
                                // ------------------------------------

                                danhSachSanPham.Add(sanPham);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải sản phẩm: " + ex.Message);
                    }
                }
            }
            return danhSachSanPham;
        }
        private void TaiSanPhamLenPanel(string tenDanhMuc)
        {
            // 1. Xóa sản phẩm cũ
            flpDanhSachSanPham.Controls.Clear();

            // 2. Lấy dữ liệu mới từ CSDL
            List<SanPham> danhSachSanPham = LaySanPhamTuCSDL(tenDanhMuc);

            // 3. XÁC ĐỊNH ĐƯỜNG DẪN GỐC CHỨA ẢNH
            // Lấy đường dẫn của file .exe đang chạy (ví dụ: ...\bin\Debug)
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // Ghép nó với tên thư mục HinhAnh
            string thuMucAnh = Path.Combine(exePath, "hinh_anh_sp");


            // 4. Duyệt qua danh sách và tạo User Control
            foreach (SanPham sanPham in danhSachSanPham)
            {
                ucTheSanPham the = new ucTheSanPham();

                // Gán dữ liệu cho thẻ
                the.ProductName = sanPham.Ten;
                the.ProductPrice = string.Format("{0:N0} đ", sanPham.Gia);
                the.ProductTag = sanPham;

                // --- PHẦN TẢI ẢNH ĐÃ SỬA ---
                try
                {
                    // Ghép đường dẫn thư mục với tên file ảnh
                    // VD: "...HinhAnh" + "nauden.jpg"
                    string duongDanDayDu = Path.Combine(thuMucAnh, sanPham.DuongDanAnh);

                    // Kiểm tra xem file có tồn tại ở đường dẫn đó không
                    if (File.Exists(duongDanDayDu))
                    {
                        // Tải ảnh từ đường dẫn đầy đủ
                        the.ProductImage = Image.FromFile(duongDanDayDu);
                    }
                    else
                    {
                        // (Tùy chọn) Load một ảnh mặc định nếu không tìm thấy
                        // a.ProductImage = Properties.Resources.placeholder;
                        // Hoặc báo lỗi:
                        // MessageBox.Show("Không tìm thấy ảnh: " + duongDanDayDu);
                    }
                }
                catch (Exception)
                {
                    // (Tùy chọn) Xử lý nếu file ảnh bị hỏng hoặc không đọc được
                }

                // Thêm sự kiện click
                the.Click += TheSanPham_Click;

                // 5. Thêm thẻ vào FlowLayoutPanel
                flpDanhSachSanPham.Controls.Add(the);
            }
        }
        private void TheSanPham_Click(object sender, EventArgs e)
        {
            if (this.idHoaDonHienTai == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!");
                return;
            }
            SanPham sanPhamDaChon = (sender as ucTheSanPham).ProductTag as SanPham;

            // ----- [LOGIC GỘP MÓN MỚI] -----
            // 1. Kiểm tra xem món (MenuID) này đã có trong hóa đơn chưa
            int chiTietID_DaCo = TimChiTietMon(this.idHoaDonHienTai, sanPhamDaChon.ID_Menu);

            if (chiTietID_DaCo != -1) // Món đã có
            {
                // 2a. Món đã có -> Tăng số lượng
                // Tìm dòng ListViewItem tương ứng
                ListViewItem itemDaCo = null;
                foreach (ListViewItem item in lvGioHang.Items)
                {
                    if ((int)item.Tag == chiTietID_DaCo)
                    {
                        itemDaCo = item;
                        break;
                    }
                }

                if (itemDaCo != null)
                {
                    // Lấy số lượng cũ từ UI
                    int soLuongCu = int.Parse(itemDaCo.SubItems[1].Text);
                    int soLuongMoi = soLuongCu + 1;

                    // Cập nhật CSDL
                    CapNhatSoLuong(chiTietID_DaCo, soLuongMoi);
                    // Cập nhật UI
                    itemDaCo.SubItems[1].Text = soLuongMoi.ToString();
                    itemDaCo.SubItems[3].Text = DateTime.Now.ToString("HH:mm"); // Cập nhật thời gian
                }
            }
            else // Món chưa có
            {
                // 2b. Món chưa có -> Thêm món mới (như cũ)
                int newChiTietID = ThemMonVaoChiTietHoaDon(this.idHoaDonHienTai, sanPhamDaChon.ID_Menu, 1, sanPhamDaChon.Gia);
                if (newChiTietID == -1) return; // Lỗi

                // Thêm vào ListView (UI)
                ListViewItem item = new ListViewItem(sanPhamDaChon.Ten);
                item.SubItems.Add("1"); // SL
                item.SubItems.Add(sanPhamDaChon.Gia.ToString("N0")); // Đơn giá
                item.SubItems.Add(DateTime.Now.ToString("HH:mm")); // Thời gian
                item.Tag = newChiTietID; // Lưu ID chi tiết
                lvGioHang.Items.Add(item);
            }
            // ----- [HẾT LOGIC GỘP MÓN] -----

            // 3. Cập nhật tổng tiền (CSDL và UI)
            decimal tongTienMoi = CapNhatTongTienHoaDon(this.idHoaDonHienTai);
            this.tongTienHienTai = tongTienMoi;
            CapNhatGiaoDienTongTien(); // Cập nhật Label giỏ hàng
        }
        private void NutDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = "";

            // Xác định xem người dùng click vào Panel hay Label
            if (sender is Label) // TH 1: Click vào chữ (Label)
            {
                tenDanhMuc = (sender as Label).Text;
            }
            else if (sender is Panel) // TH 2: Click vào vùng trống (Panel)
            {
                // Tìm cái Label đầu tiên bên trong Panel đó
                Label labelBenTrong = (sender as Panel).Controls.OfType<Label>().FirstOrDefault();

                if (labelBenTrong != null)
                {
                    tenDanhMuc = labelBenTrong.Text;
                }
            }

            // Nếu đã tìm thấy tên danh mục
            if (!string.IsNullOrEmpty(tenDanhMuc))
            {
                // In ra để kiểm tra (tùy chọn)
                // MessageBox.Show("Đang tải danh mục: " + tenDanhMuc);

                // Gọi hàm tải sản phẩm
                // Lưu ý: Tên trên Label phải khớp 100% với CSDL
                TaiSanPhamLenPanel(tenDanhMuc);
            }
        }
        private void Kaavan_Load(object sender, EventArgs e)
        {
            panbh.Visible = false;
        }

        private void panbtnbanhang_Click(object sender, EventArgs e)
        {
            panbh.Visible = !panbh.Visible;

        }
        // Dán chuỗi kết nối của bạn vào đây
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // 1. TÌM HÓA ĐƠN CHƯA THANH TOÁN
        private int TimHoaDonChuaThanhToan(int banID)
        {
            string query = "SELECT HoaDonID FROM HoaDon WHERE BanID = @BanID AND TrangThai = 0"; // 0 = chưa thanh toán
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BanID", banID);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tìm HĐ: " + ex.Message); }
            }
            return -1; // Không tìm thấy
        }

        // 2. TẠO HÓA ĐƠN MỚI
        private int TaoHoaDonMoi(int banID, DateTime gioVao)
        {
            // Giả sử TaiKhoanID = 1
            string query = @"
        INSERT INTO HoaDon (BanID, TaiKhoanID, GioVao, TrangThai, GiamGia, TongTien) 
        VALUES (@BanID, 1, @GioVao, 0, 0, 0);
        SELECT CAST(SCOPE_IDENTITY() AS INT);"; // Lấy ID vừa tạo

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@BanID", banID);
                cmd.Parameters.AddWithValue("@GioVao", gioVao);
                try
                {
                    conn.Open();
                    return (int)cmd.ExecuteScalar(); // Trả về HoaDonID mới
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tạo HĐ: " + ex.Message); return -1; }
            }
        }

        // 3. THÊM MÓN VÀO CHI TIẾT HÓA ĐƠN
        private int ThemMonVaoChiTietHoaDon(int hoaDonID, int menuID, int soLuong, decimal donGia)
        {
            // Thêm ThoiGianChon (như lần trước) và lấy ID vừa tạo
            string query = @"
        INSERT INTO ChiTietHoaDon (HoaDonID, MenuID, SoLuong, DonGia, GhiChu, ThoiGianChon)
        VALUES (@HoaDonID, @MenuID, @SoLuong, @DonGia, NULL, @ThoiGianChon);
        SELECT CAST(SCOPE_IDENTITY() AS INT);"; // <<< LẤY ID MỚI TẠO

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@MenuID", menuID);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                cmd.Parameters.AddWithValue("@ThoiGianChon", DateTime.Now);
                try
                {
                    conn.Open();
                    // Thực thi và lấy ID trả về
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm món: " + ex.Message);
                    return -1; // Báo lỗi
                }
            }
        }

        // 4. CẬP NHẬT TỔNG TIỀN (TRONG BẢNG HOADON)
        private decimal CapNhatTongTienHoaDon(int hoaDonID)
        {
            // Sửa 1: Tính tổng từ cột ThanhTien (đã được CSDL tự tính)
            string queryTinhTong = "SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE HoaDonID = @HoaDonID";
            string queryCapNhat = "UPDATE HoaDon SET TongTien = @TongTien WHERE HoaDonID = @HoaDonID";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                // ... (code kết nối) ...
                conn.Open();
                decimal tongTienMoi = 0;

                using (SqlCommand cmd = new SqlCommand(queryTinhTong, conn))
                {
                    cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        tongTienMoi = Convert.ToDecimal(result);
                    }
                }
                // ... (code cập nhật) ...
                using (SqlCommand cmd = new SqlCommand(queryCapNhat, conn))
                {
                    cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                    cmd.Parameters.AddWithValue("@TongTien", tongTienMoi);
                    cmd.ExecuteNonQuery();
                }
                return tongTienMoi;
            }
        }

        // 5. TẢI LẠI CÁC MÓN ĐÃ GỌI (TỪ CSDL LÊN LISTVIEW)
        private void TaiLaiMonDaGoi(int hoaDonID)
        {
            lvGioHang.Items.Clear();
            this.tongTienHienTai = 0;

            string query = @"
        SELECT 
            s.TenSanPham, m.KichThuoc, c.SoLuong, c.DonGia, c.ThoiGianChon, c.ChiTietID
        FROM ChiTietHoaDon AS c
        INNER JOIN Menu AS m ON c.MenuID = m.MenuID
        INNER JOIN SanPham AS s ON m.SanPhamID = s.SanPhamID
        WHERE c.HoaDonID = @HoaDonID
        ORDER BY c.ThoiGianChon ASC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // <<< BẠN ĐÃ QUÊN DÒNG NÀY
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                // >>> HẾT

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenSP = reader["TenSanPham"].ToString();
                    string kichThuoc = reader["KichThuoc"].ToString();
                    string tenDayDu = string.IsNullOrEmpty(kichThuoc) ? tenSP : $"{tenSP} ({kichThuoc})";
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    decimal donGia = Convert.ToDecimal(reader["DonGia"]);
                    DateTime thoiGian = Convert.ToDateTime(reader["ThoiGianChon"]);
                    int chiTietID = Convert.ToInt32(reader["ChiTietID"]);

                    ListViewItem item = new ListViewItem(tenDayDu);
                    item.SubItems.Add(soLuong.ToString());
                    item.SubItems.Add(donGia.ToString("N0"));
                    item.SubItems.Add(thoiGian.ToString("HH:mm"));
                    item.Tag = chiTietID;

                    lvGioHang.Items.Add(item);
                    this.tongTienHienTai += (donGia * soLuong);
                }
            }
            CapNhatGiaoDienTongTien();
        }

        // HÀM PHỤ (CHO BƯỚC 2)
        private DateTime LayGioVaoTuHoaDon(int hoaDonID)
        {
            string query = "SELECT GioVao FROM HoaDon WHERE HoaDonID = @HoaDonID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                conn.Open();
                return (DateTime)cmd.ExecuteScalar();
            }
        }
        private void TaiDanhSachBan()
        {
            // Giả sử FlowLayoutPanel chứa các bàn tên là flpKhuVuc
            flpKhuVuc.Controls.Clear();

            // Đảm bảo bạn dùng chuỗi kết nối đúng
            string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

            // Câu lệnh đã sửa lại tên cột (GioVao)
            string query = @"
        SELECT 
            b.BanID, 
            b.TenBan, 
            b.TrangThai, 
            h.GioVao,      -- <<< ĐÃ SỬA
            h.TongTien
        FROM Ban AS b
        LEFT JOIN HoaDon AS h ON b.BanID = h.BanID AND h.TrangThai = 0"; // Giả sử 0 = chưa thanh toán

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ucTheBan theBan = new ucTheBan();
                        theBan.BanID = Convert.ToInt32(reader["BanID"]);

                        string ten = reader["TenBan"].ToString();
                        string thoiGian = "Thời gian"; // Mặc định
                        string gia = "Giá"; // Mặc định

                        // Lấy trạng thái từ Bảng Ban (ví dụ: "Trống", "Có khách")
                        string trangThai = reader["TrangThai"].ToString();

                        // Kiểm tra xem bàn này có hóa đơn đang mở không
                        // (Nếu không có hóa đơn, GioVao sẽ là NULL)
                        if (reader["GioVao"] != DBNull.Value) // <<< ĐÃ SỬA
                        {
                            // Nếu có hóa đơn, cập nhật lại thông tin
                            thoiGian = Convert.ToDateTime(reader["GioVao"]).ToString("HH:mm"); // <<< ĐÃ SỬA
                            gia = Convert.ToDecimal(reader["TongTien"]).ToString("N0") + " đ";
                            trangThai = "Có khách"; // Ghi đè trạng thái
                        }

                        // Cập nhật thẻ bàn
                        theBan.CapNhatThongTin(ten, thoiGian, gia, trangThai);

                        // Gán sự kiện Click cho thẻ bàn
                        theBan.Click += ucTheBan_Click;
                        flpKhuVuc.Controls.Add(theBan);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách bàn: " + ex.Message);
                }
            }
        }
        // Hàm 1: Xóa 1 món ăn khỏi CSDL
        private void XoaMonKhoiCSDL(int chiTietID)
        {
            string query = "DELETE FROM ChiTietHoaDon WHERE ChiTietID = @ChiTietID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ChiTietID", chiTietID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Hàm 2: Xóa 1 hóa đơn rỗng khỏi CSDL
        private void XoaHoaDon(int hoaDonID)
        {
            string query = "DELETE FROM HoaDon WHERE HoaDonID = @HoaDonID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void ucTheBan_Click(object sender, EventArgs e)
        {
            ucTheBan clickedBan = sender as ucTheBan;

            // 1. LƯU LẠI BIẾN TOÀN CỤC
            this.idBanDangChon = clickedBan.BanID;
            this.tenBanDangChon = clickedBan.TenBan;

            // 2. TÌM HOẶC TẠO HÓA ĐƠN MỚI (DÙNG CODE THẬT)
            int idHoaDon = TimHoaDonChuaThanhToan(this.idBanDangChon);

            if (idHoaDon == -1) // Không tìm thấy, tạo hóa đơn mới
            {
                this.thoiGianMoBan = DateTime.Now;
                idHoaDon = TaoHoaDonMoi(this.idBanDangChon, this.thoiGianMoBan);

                // Reset giỏ hàng
                this.tongTienHienTai = 0;
                lvGioHang.Items.Clear();
            }
            else // Tìm thấy hóa đơn cũ, tải lại
            {
                this.thoiGianMoBan = LayGioVaoTuHoaDon(idHoaDon); // Lấy giờ vào cũ
                TaiLaiMonDaGoi(idHoaDon); // Tải lại món và tự tính tổng tiền
            }

            this.idHoaDonHienTai = idHoaDon; // LƯU LẠI ID HÓA ĐƠN ĐANG XỬ LÝ

            // 3. CHUYỂN SANG PANEL BÁN HÀNG
            panKhuVuc.Visible = false;
            panbh.Visible = true;

            // 4. CẬP NHẬT THÔNG TIN TRÊN PANEL BÁN HÀNG
            // (Bạn cần thêm 2 Label `lblTenBanHienTai` và `lblThoiGianVao` vào `pantieude`)
            lblTenBanHienTai.Text = this.tenBanDangChon;
            lblThoiGianVao.Text = this.thoiGianMoBan.ToString("dd/MM/yyyy HH:mm");

            // 5. CẬP NHẬT GIAO DIỆN GIỎ HÀNG (Lần nữa cho chắc)
            CapNhatGiaoDienTongTien();
        }
        private void panbtnkhuvuc_Click(object sender, EventArgs e)
        {
            {
                // Hiển thị panel khu vực, ẩn panel bán hàng
                panKhuVuc.Visible = true; // Panel chứa các bàn
                panbh.Visible = false;

                TaiDanhSachBan();
            }
        }
        // Hàm 1: Tìm 1 món (MenuID) đã có trong Hóa đơn chưa
        // Trả về ChiTietID nếu tìm thấy, ngược lại trả về -1
        private int TimChiTietMon(int hoaDonID, int menuID)
        {
            // Chỉ cần ChiTietID
            string query = "SELECT ChiTietID FROM ChiTietHoaDon WHERE HoaDonID = @HoaDonID AND MenuID = @MenuID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@MenuID", menuID);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tìm chi tiết món: " + ex.Message); }
            }
            return -1; // Không tìm thấy
        }

        // Hàm 2: Cập nhật số lượng cho 1 món
        private void CapNhatSoLuong(int chiTietID, int soLuongMoi)
        {
            string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong WHERE ChiTietID = @ChiTietID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                cmd.Parameters.AddWithValue("@ChiTietID", chiTietID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void pantrove_Click(object sender, EventArgs e)
        {
            panbh.Visible = !panbh.Visible;
        }

        private void panthanhtoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có chọn món nào chưa
            if (lvGioHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa.");
                return;
            }

            // 2. Lấy món đã chọn
            ListViewItem item = lvGioHang.SelectedItems[0];

            // 3. Lấy ChiTietID đã lưu trong Tag
            int chiTietID = (int)item.Tag;

            // 4. Xóa món khỏi CSDL
            XoaMonKhoiCSDL(chiTietID);

            // 5. Xóa món khỏi ListView (UI)
            lvGioHang.Items.Remove(item);

            // 6. Cập nhật lại tổng tiền (trong CSDL và UI)
            decimal tongTienMoi = CapNhatTongTienHoaDon(this.idHoaDonHienTai);
            this.tongTienHienTai = tongTienMoi;
            CapNhatGiaoDienTongTien(); // Cập nhật Label giỏ hàng

            // 7. KIỂM TRA BÀN TRỐNG (Yêu cầu 2 của bạn)
            if (lvGioHang.Items.Count == 0)
            {
                // Nếu giỏ hàng rỗng, xóa luôn hóa đơn
                XoaHoaDon(this.idHoaDonHienTai);

                MessageBox.Show("Bàn đã trống, quay về màn hình khu vực.");

                // Gọi hàm quay lại (giống hệt nút '<')
                pantrove_Click(sender, e);
            }
        }

        private void btnGiamSL_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món để giảm số lượng.");
                return;
            }

            ListViewItem item = lvGioHang.SelectedItems[0];
            int chiTietID = (int)item.Tag;
            int soLuongCu = int.Parse(item.SubItems[1].Text);

            if (soLuongCu == 1)
            {
                // Nếu số lượng là 1, chạy logic của nút "Xóa món"
                // (Chúng ta gọi hàm btnXoaMon_Click trực tiếp)
                btnXoaMon_Click(sender, e);
            }
            else // Nếu số lượng > 1
            {
                int soLuongMoi = soLuongCu - 1;

                // Cập nhật CSDL
                CapNhatSoLuong(chiTietID, soLuongMoi);

                // Cập nhật UI
                item.SubItems[1].Text = soLuongMoi.ToString();
                item.SubItems[3].Text = DateTime.Now.ToString("HH:mm"); // Cập nhật thời gian

                // Cập nhật tổng tiền
                decimal tongTienMoi = CapNhatTongTienHoaDon(this.idHoaDonHienTai);
                this.tongTienHienTai = tongTienMoi;
                CapNhatGiaoDienTongTien();
            }
        }

        private void btnTangSL_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món để tăng số lượng.");
                return;
            }

            ListViewItem item = lvGioHang.SelectedItems[0];
            int chiTietID = (int)item.Tag;
            int soLuongCu = int.Parse(item.SubItems[1].Text);
            int soLuongMoi = soLuongCu + 1;

            // Cập nhật CSDL
            CapNhatSoLuong(chiTietID, soLuongMoi);

            // Cập nhật UI
            item.SubItems[1].Text = soLuongMoi.ToString();
            item.SubItems[3].Text = DateTime.Now.ToString("HH:mm"); // Cập nhật thời gian

            // Cập nhật tổng tiền
            decimal tongTienMoi = CapNhatTongTienHoaDon(this.idHoaDonHienTai);
            this.tongTienHienTai = tongTienMoi;
            CapNhatGiaoDienTongTien();
        }
        // Hàm mới: Hoàn tất thanh toán, cập nhật Hóa Đơn và Bàn
        private void HoanTatThanhToan(int hoaDonID, int banID)
        {
            // Cập nhật 2 bảng: HoaDon và Ban
            string query = @"
        -- 1. Đóng hóa đơn
        UPDATE HoaDon 
        SET TrangThai = 1,          -- 1 = Đã thanh toán
            GioRa = GETDATE()       -- GETDATE() là DateTime.Now của SQL
        WHERE HoaDonID = @HoaDonID;

        -- 2. Chuyển bàn về trạng thái 'Trống'
        -- (Bạn có thể cần thay 'Trống' bằng tên trạng thái chính xác)
        UPDATE Ban 
        SET TrangThai = N'Trống' 
        WHERE BanID = @BanID;";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@BanID", banID);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); // Thực thi 2 câu UPDATE
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem có hóa đơn để thanh toán không
            if (this.idHoaDonHienTai == -1)
            {
                MessageBox.Show("Không có hóa đơn để thanh toán.");
                return;
            }

            // 2. Hỏi xác nhận
            string thongBao = $"Xác nhận thanh toán cho {this.tenBanDangChon}\nTổng tiền: {this.tongTienHienTai.ToString("N0")} đ";
            DialogResult result = MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // 3. Gọi hàm CSDL để hoàn tất
                HoanTatThanhToan(this.idHoaDonHienTai, this.idBanDangChon);

                MessageBox.Show("Thanh toán thành công!");

                // 4. Quay về màn hình Khu Vực
                // Chúng ta gọi lại hàm `pantrove_Click` vì nó đã làm
                // chính xác những gì ta muốn: reset biến và tải lại bàn.
                pantrove_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra
            if (this.idHoaDonHienTai == -1) { /* ... (như cũ) ... */ return; }

            // 2. Hỏi xác nhận
            string thongBao = $"Xác nhận thanh toán cho {this.tenBanDangChon}\nTổng tiền: {this.tongTienHienTai.ToString("N0")} đ";
            DialogResult result = MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // 3. Gọi hàm CSDL
                HoanTatThanhToan(this.idHoaDonHienTai, this.idBanDangChon);

                // --- PHẦN IN HÓA ĐƠN ---
                MessageBox.Show("Đã thanh toán. (Đang chuẩn bị in hóa đơn...)");
                //
                // (Đây là nơi bạn sẽ gọi code in, ví dụ dùng Crystal Reports, RDLC...)
                //
                // -------------------------

                // 4. Quay về màn hình Khu Vực
                pantrove_Click(sender, e);
            }
        }
        // Hàm này chạy khi Form được tải
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            HienThiThongTinCa();
            PhanQuyen();
        }

        // Hàm mới để kiểm tra và áp dụng quyền
        private void PhanQuyen()
        {
            // 1. Hiển thị chức vụ
            lblChucVu.Text = PhienDangNhap.ChucVu; // (Bạn cần tạo 1 Label tên lblChucVu)

            bool laQuanLy = (PhienDangNhap.ChucVu == "Quản lý");

            // 2. Bật/Tắt các nút

            // Nút "Tạo tài khoản"
            btntaotkchonhanvien.Enabled = laQuanLy;

            // Nút "Báo cáo"
            btnBaoCao.Enabled = laQuanLy;

            // Nút "Chương trình bán hàng"
            btnChuongTrinh.Enabled = laQuanLy;

            // Nút "Thực đơn"
            btnThucDon.Enabled = laQuanLy;

            // Nút "Quản lý ca" luôn được BẬT cho cả 2
            btnQuanLyCa.Enabled = true;

            // 3. (Tùy chọn) Đổi màu nút bị tắt cho dễ nhìn
            if (!laQuanLy)
            {
                btntaotkchonhanvien.BackColor = Color.Gray;
                btnBaoCao.BackColor = Color.Gray;
                btnChuongTrinh.BackColor = Color.Gray;
                btnThucDon.BackColor = Color.Gray;
            }
        }

        // Hàm mới để tải ca làm việc hiện tại (nếu có)
        private void HienThiThongTinCa()
        {
            // Lấy ca MỚI NHẤT chưa kết thúc
            string query = @"
        SELECT TOP 1 MaCa, ThoiGianBatDau 
        FROM CaLamViec 
        WHERE ThoiGianKetThuc IS NULL 
        ORDER BY ThoiGianBatDau DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Cập nhật lên Label
                    // (Giả sử tên là lblMaCa và lblThoiGianMoCa)
                    lblma.Text = reader["MaCa"].ToString();
                    lbltime.Text = Convert.ToDateTime(reader["ThoiGianBatDau"]).ToString("HH:mm dd/MM");
                }
                else
                {
                    lblma.Text = "N/A";
                    lbltime.Text = "Chưa mở ca";
                }
            }
        }

        private void btnQuanLyCa_Click(object sender, EventArgs e)
        {
            frmMoCa formMoCa = new frmMoCa();
            formMoCa.ShowDialog(); // ShowDialog để nó ưu tiên

            // Sau khi Form Mở Ca đóng lại, tải lại thông tin ca
            HienThiThongTinCa();
        }

        private void panbtnql_Click(object sender, EventArgs e)
        {
            panThuocTinh.Visible = !panThuocTinh.Visible;
            panbh.Visible = false;
            panKhuVuc.Visible = false;  
        }
    }
}
