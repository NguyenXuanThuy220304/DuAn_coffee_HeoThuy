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
            int soLuongMon = lvGioHang.Items.Count; // (Tạm tính, sau này bạn sẽ cộng SL)

            // Cập nhật Header
            lblGioHangInfo.Text = $"Giỏ hàng ({soLuongMon}) - {giaText}";

            // Cập nhật Nút Thanh toán
            // (Chúng ta dùng \n để xuống dòng)
            btnThanhToan.Text = $"Thanh toán\n{giaText}";
            // (Bạn cũng cần set Font cho btnThanhToan lớn một chút)
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
            // 1. Kiểm tra xem có bàn nào được chọn chưa
            if (this.idHoaDonHienTai == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món!");
                return;
            }

            // 2. Lấy thông tin sản phẩm
            ucTheSanPham theDaClick = sender as ucTheSanPham;
            SanPham sanPhamDaChon = theDaClick.ProductTag as SanPham;

            // ----- [PHẦN NÂNG CẤP] -----
            // Bạn nên kiểm tra xem món này đã có trong lvGioHang chưa.
            // Nếu có, chỉ cần tăng số lượng (SL).
            // Nếu chưa, mới Add item mới.
            // (Tạm thời chúng ta sẽ luôn thêm dòng mới cho đơn giản)
            // ----------------------------

            // 3. THÊM VÀO CSDL (Bảng ChiTietHoaDon)
            // (Hàm này bạn sẽ tự viết)
            // ThemMonVaoCSDL(this.idHoaDonHienTai, sanPhamDaChon.ID_Menu, 1, sanPhamDaChon.Gia);

            // 4. HIỂN THỊ LÊN GIAO DIỆN ListView
            // Tạo 1 dòng mới
            ListViewItem item = new ListViewItem(sanPhamDaChon.Ten); // Cột 1 (Tên món)

            // Thêm các cột phụ (sub-items)
            item.SubItems.Add("1"); // Cột 2 (SL)
            item.SubItems.Add(sanPhamDaChon.Gia.ToString("N0")); // Cột 3 (Đơn giá)
            item.SubItems.Add(DateTime.Now.ToString("HH:mm")); // Cột 4 (Thời gian)

            // Lưu lại đối tượng sanPham vào Tag (để sau này tính tiền)
            item.Tag = sanPhamDaChon;

            // Thêm dòng mới vào ListView
            lvGioHang.Items.Add(item);

            // 5. CẬP NHẬT TỔNG TIỀN
            // (Hàm này bạn cũng sẽ tự viết để cập nhật CSDL)
            // CapNhatTongTienCSDL(this.idHoaDonHienTai, sanPhamDaChon.Gia);

            // 6. CẬP NHẬT TỔNG TIỀN TRÊN GIAO DIỆN
            this.tongTienHienTai += sanPhamDaChon.Gia;
            CapNhatGiaoDienTongTien();
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
        private void panbtnkhuvuc_Click(object sender, EventArgs e)
        {

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
    }
}
