using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucBanHang : UserControl
    {
        // === CÁC BIẾN CỤC BỘ ===
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";
        private int idBanDangChon = -1;
        private int idHoaDonHienTai = -1;
        private string tenBanDangChon = "";
        private DateTime thoiGianMoBan;
        private decimal tongTienHienTai = 0;

        // === CÁC SỰ KIỆN (EVENT) ĐỂ BÁO LÊN FORM CHA ===
        public event EventHandler GoBack;
        public event EventHandler PaymentCompleted;

        public ucBanHang()
        {
            InitializeComponent();

            // Gán sự kiện cho các nút trong UserControl này
            this.pantrove.Click += pantrove_Click;
            this.label14.Click += (s, e) => pantrove_Click(s, e);
            AssignCategoryClicks(pandanhmuc);
            this.btnThanhToan.Click += btnThanhToan_Click;
            this.button1.Click += btnThanhToanVaXuatHoaDon_Click;
            this.btnXoaMon.Click += btnXoaMon_Click;
            this.btnTangSL.Click += btnTangSL_Click;
            this.btnGiamSL.Click += btnGiamSL_Click;
            this.cbGiamGia.SelectedIndexChanged += new System.EventHandler(this.cbGiamGia_SelectedIndexChanged);
        }

        // Hàm này public để Kaavan.cs có thể gọi
        public void LoadOrder(int banID, string tenBan, int hoaDonID, DateTime gioVao)
        {
            this.idBanDangChon = banID;
            this.tenBanDangChon = tenBan;
            this.idHoaDonHienTai = hoaDonID;
            this.thoiGianMoBan = gioVao;

            lblTenBanHienTai.Text = this.tenBanDangChon;
            lblThoiGianVao.Text = this.thoiGianMoBan.ToString("dd/MM/yyyy HH:mm");
            LoadDanhSachGiamGia(); // Tải danh sách
            cbGiamGia.SelectedIndex = 0; // Chọn "(Không áp dụng)"
            TaiLaiMonDaGoi(this.idHoaDonHienTai);
            TaiSanPhamLenPanel("Coffee máy");
        }

        // === HÀM SỰ KIỆN NỘI BỘ ===
        private void pantrove_Click(object sender, EventArgs e)
        {
            XoaSachGioHang();
            this.idHoaDonHienTai = -1;
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        private void AssignCategoryClicks(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Panel)
                {
                    c.Click += NutDanhMuc_Click;
                    foreach (Control label in c.Controls)
                    {
                        if (label is Label)
                            label.Click += NutDanhMuc_Click;
                    }
                }
            }
        }

        private void NutDanhMuc_Click(object sender, EventArgs e)
        {
            string tenDanhMuc = "";
            if (sender is Label)
                tenDanhMuc = (sender as Label).Text;
            else if (sender is Panel)
                tenDanhMuc = (sender as Panel).Controls.OfType<Label>().FirstOrDefault()?.Text;

            if (!string.IsNullOrEmpty(tenDanhMuc))
                TaiSanPhamLenPanel(tenDanhMuc);
        }

        private void TaiSanPhamLenPanel(string tenDanhMuc)
        {
            flpDanhSachSanPham.Controls.Clear();
            List<SanPham> danhSachSanPham = LaySanPhamTuCSDL(tenDanhMuc);
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string thuMucAnh = Path.Combine(exePath, "hinh_anh_sp");

            foreach (SanPham sanPham in danhSachSanPham)
            {
                ucTheSanPham the = new ucTheSanPham();
                the.ProductName = sanPham.Ten;
                the.ProductPrice = string.Format("{0:N0} đ", sanPham.Gia);
                the.ProductTag = sanPham;
                try
                {
                    string duongDanDayDu = Path.Combine(thuMucAnh, sanPham.DuongDanAnh);
                    if (File.Exists(duongDanDayDu))
                        the.ProductImage = Image.FromFile(duongDanDayDu);
                }
                catch { }
                the.Click += TheSanPham_Click;
                flpDanhSachSanPham.Controls.Add(the);
            }
        }

        private void TheSanPham_Click(object sender, EventArgs e)
        {
            if (this.idHoaDonHienTai == -1) { return; }
            SanPham sanPhamDaChon = (sender as ucTheSanPham).ProductTag as SanPham;
            int chiTietID_DaCo = TimChiTietMon(this.idHoaDonHienTai, sanPhamDaChon.ID_Menu);

            if (chiTietID_DaCo != -1) // Món đã có
            {
                ListViewItem itemDaCo = lvGioHang.Items.Cast<ListViewItem>().FirstOrDefault(item => (int)item.Tag == chiTietID_DaCo);
                if (itemDaCo != null)
                {
                    int soLuongMoi = int.Parse(itemDaCo.SubItems[1].Text) + 1;
                    CapNhatSoLuong(chiTietID_DaCo, soLuongMoi);
                    itemDaCo.SubItems[1].Text = soLuongMoi.ToString();
                    itemDaCo.SubItems[3].Text = DateTime.Now.ToString("HH:mm");
                }
            }
            else // Món chưa có
            {
                int newChiTietID = ThemMonVaoChiTietHoaDon(this.idHoaDonHienTai, sanPhamDaChon.ID_Menu, 1, sanPhamDaChon.Gia);
                if (newChiTietID == -1) return;
                ListViewItem item = new ListViewItem(sanPhamDaChon.Ten);
                item.SubItems.Add("1");
                item.SubItems.Add(sanPhamDaChon.Gia.ToString("N0"));
                item.SubItems.Add(DateTime.Now.ToString("HH:mm"));
                item.Tag = newChiTietID;
                lvGioHang.Items.Add(item);
            }
            TinhToanHoaDon();
        }
        // (Bên trong class ucBanHang)
        private void cbGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi đổi giảm giá, tính lại toàn bộ hóa đơn
            if (this.idHoaDonHienTai != -1) // Chỉ tính khi có hóa đơn
            {
                TinhToanHoaDon();
            }
        }
        private void btnTangSL_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0) return;
            ListViewItem item = lvGioHang.SelectedItems[0];
            int chiTietID = (int)item.Tag;
            int soLuongMoi = int.Parse(item.SubItems[1].Text) + 1;

            CapNhatSoLuong(chiTietID, soLuongMoi);
            item.SubItems[1].Text = soLuongMoi.ToString();
            item.SubItems[3].Text = DateTime.Now.ToString("HH:mm");
            TinhToanHoaDon();
        }

        private void btnGiamSL_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0) return;
            ListViewItem item = lvGioHang.SelectedItems[0];
            int soLuongCu = int.Parse(item.SubItems[1].Text);

            if (soLuongCu == 1) { btnXoaMon_Click(sender, e); }
            else
            {
                int chiTietID = (int)item.Tag;
                int soLuongMoi = soLuongCu - 1;
                CapNhatSoLuong(chiTietID, soLuongMoi);
                item.SubItems[1].Text = soLuongMoi.ToString();
                item.SubItems[3].Text = DateTime.Now.ToString("HH:mm");
                TinhToanHoaDon();
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count == 0) return;
            ListViewItem item = lvGioHang.SelectedItems[0];
            int chiTietID = (int)item.Tag;

            XoaMonKhoiCSDL(chiTietID);
            lvGioHang.Items.Remove(item);
            TinhToanHoaDon();

            if (lvGioHang.Items.Count == 0)
            {
                XoaHoaDon(this.idHoaDonHienTai);
                MessageBox.Show("Bàn đã trống, quay về màn hình khu vực.");
                pantrove_Click(sender, e);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (this.idHoaDonHienTai == -1) return;
            string thongBao = $"Xác nhận thanh toán cho {this.tenBanDangChon}\nTổng tiền: {this.tongTienHienTai.ToString("N0")} đ";
            if (MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                HoanTatThanhToan(this.idHoaDonHienTai, this.idBanDangChon);
                MessageBox.Show("Thanh toán thành công!");
                PaymentCompleted?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnThanhToanVaXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (this.idHoaDonHienTai == -1) return;
            string thongBao = $"Xác nhận thanh toán cho {this.tenBanDangChon}\nTổng tiền: {this.tongTienHienTai.ToString("N0")} đ";
            if (MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                HoanTatThanhToan(this.idHoaDonHienTai, this.idBanDangChon);
                MessageBox.Show("Đã thanh toán. (Đang chuẩn bị in hóa đơn...)");
                // (Code in hóa đơn sẽ ở đây)
                PaymentCompleted?.Invoke(this, EventArgs.Empty);
            }
        }

        // === CÁC HÀM GIAO DIỆN PHỤ ===
        // (Bên trong class ucBanHang)
        // THAY THẾ HÀM NÀY:
        // === THAY THẾ HÀM NÀY ===
        private void CapNhatGiaoDienTongTien(decimal tongCong)
        {
            string giaText = tongCong.ToString("N0") + " đ";
            int soLuongMon = 0;
            foreach (ListViewItem item in lvGioHang.Items)
            {
                soLuongMon += int.Parse(item.SubItems[1].Text);
            }
            lblGioHangInfo.Text = $"Giỏ hàng ({soLuongMon}) - {giaText}";
            btnThanhToan.Text = $"Thanh toán\n{giaText}";
        }
        private void XoaSachGioHang()
        {
            lvGioHang.Items.Clear();
            this.tongTienHienTai = 0;
            TinhToanHoaDon();
        }

        // === CÁC HÀM CSDL ===
        private List<SanPham> LaySanPhamTuCSDL(string tenDanhMuc)
        {
            List<SanPham> danhSachSanPham = new List<SanPham>();
            string cauTruyVanSQL = @"
                SELECT m.MenuID, s.TenSanPham, m.KichThuoc, m.DonGia, s.MoTa 
                FROM Menu AS m
                INNER JOIN SanPham AS s ON m.SanPhamID = s.SanPhamID
                INNER JOIN DanhMuc AS d ON s.DanhMucID = d.DanhMucID
                WHERE d.TenDanhMuc = @TenDanhMuc";
            using (SqlConnection ketNoi = new SqlConnection(chuoiKetNoi))
            using (SqlCommand lenh = new SqlCommand(cauTruyVanSQL, ketNoi))
            {
                lenh.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                ketNoi.Open();
                using (SqlDataReader dauDoc = lenh.ExecuteReader())
                {
                    while (dauDoc.Read())
                    {
                        SanPham sp = new SanPham();
                        sp.ID_Menu = Convert.ToInt32(dauDoc["MenuID"]);
                        sp.Gia = Convert.ToDecimal(dauDoc["DonGia"]);
                        sp.DuongDanAnh = dauDoc["MoTa"].ToString();
                        string ten = dauDoc["TenSanPham"].ToString();
                        string kt = dauDoc["KichThuoc"].ToString();
                        sp.Ten = string.IsNullOrEmpty(kt) ? ten : $"{ten} ({kt})";
                        danhSachSanPham.Add(sp);
                    }
                }
            }
            return danhSachSanPham;
        }

        private int TimChiTietMon(int hoaDonID, int menuID)
        {
            string query = "SELECT ChiTietID FROM ChiTietHoaDon WHERE HoaDonID = @HoaDonID AND MenuID = @MenuID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@MenuID", menuID);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : -1;
            }
        }
        private void CapNhatSoLuong(int chiTietID, int soLuongMoi)
        {
            string query = "UPDATE ChiTietHoaDon SET SoLuong = @SoLuong, ThoiGianChon = GETDATE() WHERE ChiTietID = @ChiTietID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SoLuong", soLuongMoi);
                cmd.Parameters.AddWithValue("@ChiTietID", chiTietID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private int ThemMonVaoChiTietHoaDon(int hoaDonID, int menuID, int soLuong, decimal donGia)
        {
            string query = @"
                INSERT INTO ChiTietHoaDon (HoaDonID, MenuID, SoLuong, DonGia, GhiChu, ThoiGianChon)
                VALUES (@HoaDonID, @MenuID, @SoLuong, @DonGia, NULL, GETDATE());
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@MenuID", menuID);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@DonGia", donGia);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        private decimal CapNhatTongTienHoaDon(int hoaDonID)
        {
            string queryTinhTong = "SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE HoaDonID = @HoaDonID";
            string queryCapNhat = "UPDATE HoaDon SET TongTien = ISNULL(@TongTien, 0) WHERE HoaDonID = @HoaDonID";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                decimal tongTienMoi = 0;
                using (SqlCommand cmd = new SqlCommand(queryTinhTong, conn))
                {
                    cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value) tongTienMoi = Convert.ToDecimal(result);
                }
                using (SqlCommand cmd = new SqlCommand(queryCapNhat, conn))
                {
                    cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                    cmd.Parameters.AddWithValue("@TongTien", tongTienMoi);
                    cmd.ExecuteNonQuery();
                }
                return tongTienMoi;
            }
        }
        private void TaiLaiMonDaGoi(int hoaDonID)
        {
            lvGioHang.Items.Clear();
            this.tongTienHienTai = 0;
            string query = @"
                SELECT s.TenSanPham, m.KichThuoc, c.SoLuong, c.DonGia, c.ThoiGianChon, c.ChiTietID
                FROM ChiTietHoaDon AS c
                INNER JOIN Menu AS m ON c.MenuID = m.MenuID
                INNER JOIN SanPham AS s ON m.SanPhamID = s.SanPhamID
                WHERE c.HoaDonID = @HoaDonID ORDER BY c.ThoiGianChon ASC";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
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
            TinhToanHoaDon();
        }
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
        private void HoanTatThanhToan(int hoaDonID, int banID)
        {
            string query = @"
                UPDATE HoaDon SET TrangThai = 1, GioRa = GETDATE() WHERE HoaDonID = @HoaDonID;
                UPDATE Ban SET TrangThai = N'Trống' WHERE BanID = @BanID;";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@BanID", banID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // (Bên trong class ucBanHang)

        // Hàm mới: Tải tất cả CT Khuyến mãi và Giảm giá
        private void LoadDanhSachGiamGia()
        {
            var danhSach = new List<GiamGia>();
            danhSach.Add(new GiamGia { ID = 0, TenHienThi = "(Không áp dụng)", ChiTiet = "0" });

            string query = "SELECT KhuyenMaiID, TenChuongTrinh, ChiTiet, LoaiChuongTrinh FROM KhuyenMai WHERE TrangThai = 1";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        danhSach.Add(new GiamGia
                        {
                            ID = Convert.ToInt32(reader["KhuyenMaiID"]),
                            TenHienThi = reader["TenChuongTrinh"].ToString(),
                            ChiTiet = reader["ChiTiet"].ToString(),
                            Loai = reader["LoaiChuongTrinh"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách giảm giá: " + ex.Message);
                }
            }
            cbGiamGia.DataSource = danhSach;
            cbGiamGia.DisplayMember = "TenHienThi";
        }
        // (Bên trong class ucBanHang)

        // HÀM MỚI: Tính toán lại toàn bộ tiền
        // === DÁN HÀM MỚI NÀY ===
        private void TinhToanHoaDon()
        {
            // 1. Lấy tổng tiền món ăn (Tạm tính)
            decimal tamTinh = CapNhatTongTienHoaDon(this.idHoaDonHienTai);

            // 2. Lấy thông tin giảm giá
            GiamGia giamChon = cbGiamGia.SelectedItem as GiamGia;
            decimal soTienGiam = 0;

            if (giamChon != null && giamChon.ID != 0)
            {
                string chiTiet = giamChon.ChiTiet;
                try
                {
                    if (chiTiet.Contains("%")) // Case 1: Giảm theo %
                    {
                        decimal phanTram = decimal.Parse(chiTiet.Replace("%", ""));
                        soTienGiam = tamTinh * (phanTram / 100);
                    }
                    else if (giamChon.Loai == "Combo") // Case 2: Combo (Đồng giá)
                    {
                        decimal giaDong = decimal.Parse(chiTiet);
                        int soLuongMon = lvGioHang.Items.Cast<ListViewItem>().Sum(item => int.Parse(item.SubItems[1].Text));
                        soTienGiam = tamTinh - (soLuongMon * giaDong);
                        if (soTienGiam < 0) soTienGiam = 0; // Đảm bảo không giảm âm
                    }
                    else // Case 3: Giảm tiền trực tiếp (VND)
                    {
                        soTienGiam = decimal.Parse(chiTiet);
                    }
                }
                catch (Exception ex) { soTienGiam = 0; }
            }

            // 3. Tính tổng cuối cùng
            decimal tongCong = tamTinh - soTienGiam;
            if (tongCong < 0) tongCong = 0;

            // 4. Lưu vào biến toàn cục
            this.tongTienHienTai = tongCong;

            // 5. Cập nhật giao diện
            // (Bạn cần tạo 3 Label: lblTamTinh, lblGiamGia, lblTongCong)
            // lblTamTinh.Text = tamTinh.ToString("N0") + " đ";
            // lblGiamGia.Text = soTienGiam.ToString("N0") + " đ";
            // lblTongCong.Text = tongCong.ToString("N0") + " đ";

            // Cập nhật Header + Nút Thanh toán
            CapNhatGiaoDienTongTien(tongCong); // Gọi hàm cũ đã sửa

            // 6. Lưu Tổng tiền và Tiền giảm vào CSDL
            LuuTongTienVaoHoaDon(this.idHoaDonHienTai, tongCong, soTienGiam);
        }
        // (Bên trong class ucBanHang)
        // === DÁN HÀM MỚI NÀY ===
        // (Trong file ucBanHang.cs)

        // THAY THẾ HÀM NÀY
        private void LuuTongTienVaoHoaDon(int hoaDonID, decimal tongTien, decimal giamGia)
        {
            // Lấy KhuyenMaiID từ ComboBox
            int khuyenMaiID = 0;
            if (cbGiamGia.SelectedItem != null)
            {
                GiamGia giamChon = cbGiamGia.SelectedItem as GiamGia;
                if (giamChon.ID != 0)
                {
                    khuyenMaiID = giamChon.ID;
                }
            }

            // Cập nhật cả 3 cột
            string queryCapNhat = "UPDATE HoaDon SET TongTien = @TongTien, GiamGia = @GiamGia, KhuyenMaiID = @KMID WHERE HoaDonID = @HoaDonID";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(queryCapNhat, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HoaDonID", hoaDonID);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                cmd.Parameters.AddWithValue("@GiamGia", giamGia);

                // Thêm ID khuyến mãi (hoặc NULL nếu không chọn)
                if (khuyenMaiID == 0)
                    cmd.Parameters.AddWithValue("@KMID", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@KMID", khuyenMaiID);

                cmd.ExecuteNonQuery();
            }
        }
        private void panbh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}