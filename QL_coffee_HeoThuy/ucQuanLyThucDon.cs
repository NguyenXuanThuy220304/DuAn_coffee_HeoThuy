using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucQuanLyThucDon : UserControl
    {
        public event EventHandler GoBack;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // Biến lưu trữ ID đang chọn
        private int currentMenuID = -1;
        private int currentSanPhamID = -1;

        // Biến lưu đường dẫn thư mục ảnh
        private string thuMucAnh = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "hinh_anh_sp");

        public ucQuanLyThucDon()
        {
            InitializeComponent();

            // Gán sự kiện
            btnBack.Click += (s, e) => GoBack?.Invoke(this, EventArgs.Empty);
            btnLamMoi.Click += (s, e) => LamMoiForm();
            dgvThucDon.SelectionChanged += dgvThucDon_SelectionChanged;
            btnChonAnh.Click += btnChonAnh_Click;

            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
        }

        // Hàm được Form Kaavan gọi
        public void LoadData()
        {
            LoadDanhSachMon();
            LoadDanhSachDanhMuc();
            LamMoiForm();
        }

        // Tải toàn bộ món ăn (Menu) vào DataGridView
        // (Trong file ucQuanLyThucDon.cs)

        // (Trong file ucQuanLyThucDon.cs)

        // THAY THẾ TOÀN BỘ HÀM NÀY:
        private void LoadDanhSachMon()
        {
            string query = @"
        SELECT 
            m.MenuID, 
            s.SanPhamID,
            d.DanhMucID,      -- <<< LỖI LÀ DO BẠN THIẾU DÒNG NÀY
            d.TenDanhMuc,
            s.TenSanPham, 
            m.KichThuoc, 
            m.DonGia,
            s.MoTa
        FROM Menu AS m
        JOIN SanPham AS s ON m.SanPhamID = s.SanPhamID
        JOIN DanhMuc AS d ON s.DanhMucID = d.DanhMucID
        ORDER BY d.TenDanhMuc, s.TenSanPham";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvThucDon.DataSource = dt;

                // Ẩn các cột ID
                dgvThucDon.Columns["MenuID"].Visible = false;
                dgvThucDon.Columns["SanPhamID"].Visible = false;
                dgvThucDon.Columns["DanhMucID"].Visible = false; // <<< ẨN CỘT ID ĐI
            }
        }

        // Tải danh mục vào ComboBox
        private void LoadDanhSachDanhMuc()
        {
            string query = "SELECT DanhMucID, TenDanhMuc FROM DanhMuc";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbDanhMuc.DataSource = dt;
                cmbDanhMuc.DisplayMember = "TenDanhMuc";
                cmbDanhMuc.ValueMember = "DanhMucID";
            }
        }

        // Reset các trường
        private void LamMoiForm()
        {
            currentMenuID = -1;
            currentSanPhamID = -1;

            txtTenSP.Text = "";
            cmbDanhMuc.SelectedIndex = 0;
            txtKichThuoc.Text = "";
            numDonGia.Value = 0;
            picAnhSP.Image = null;
            txtDuongDanAnh.Text = "";

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvThucDon.ClearSelection();
        }

        // Khi click vào 1 dòng trong DataGridView
        private void dgvThucDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThucDon.SelectedRows.Count == 0) return;

            DataGridViewRow row = dgvThucDon.SelectedRows[0];

            // Lấy ID
            currentMenuID = Convert.ToInt32(row.Cells["MenuID"].Value);
            currentSanPhamID = Convert.ToInt32(row.Cells["SanPhamID"].Value);

            // Điền dữ liệu vào form
            txtTenSP.Text = row.Cells["TenSanPham"].Value.ToString();
            cmbDanhMuc.SelectedValue = row.Cells["DanhMucID"].Value; // (Sửa: Cần gán ValueMember từ ID)
                                                                     // (Chúng ta sẽ sửa LoadDanhSachMon để lấy DanhMucID)

            txtKichThuoc.Text = row.Cells["KichThuoc"].Value.ToString();
            numDonGia.Value = Convert.ToDecimal(row.Cells["DonGia"].Value);
            txtDuongDanAnh.Text = row.Cells["MoTa"].Value.ToString();

            // Tải ảnh
            try
            {
                string duongDanDayDu = Path.Combine(thuMucAnh, txtDuongDanAnh.Text);
                if (File.Exists(duongDanDayDu))
                    picAnhSP.Image = Image.FromFile(duongDanDayDu);
                else
                    picAnhSP.Image = null;
            }
            catch { picAnhSP.Image = null; }

            // Bật/tắt nút
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        // Nút "Chọn ảnh..."
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên file
                    string fileName = Path.GetFileName(ofd.FileName);
                    // Tạo đường dẫn đích (vào thư mục hinh_anh_sp)
                    string destPath = Path.Combine(thuMucAnh, fileName);

                    // Copy file
                    File.Copy(ofd.FileName, destPath, true);

                    // Hiển thị ảnh và lưu tên file
                    picAnhSP.Image = Image.FromFile(destPath);
                    txtDuongDanAnh.Text = fileName;
                }
            }
        }

        // Nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Logic: 
            // 1. Kiểm tra xem SanPham (tên gốc) đã tồn tại chưa.
            // 2. Nếu chưa, tạo SanPham mới.
            // 3. Lấy SanPhamID (mới hoặc cũ).
            // 4. Tạo món mới trong bảng Menu.

            string tenSPGoc = txtTenSP.Text;
            int danhMucID = (int)cmbDanhMuc.SelectedValue;
            string tenFileAnh = txtDuongDanAnh.Text;

            // 1. Tìm SanPham
            int sanPhamID = TimHoacTaoSanPham(tenSPGoc, danhMucID, tenFileAnh);
            if (sanPhamID == -1) return; // Lỗi

            // 2. Tạo món trong Menu
            string queryMenu = @"
                INSERT INTO Menu (SanPhamID, KichThuoc, DonGia)
                VALUES (@SanPhamID, @KichThuoc, @DonGia)";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(queryMenu, conn))
            {
                cmd.Parameters.AddWithValue("@SanPhamID", sanPhamID);
                cmd.Parameters.AddWithValue("@KichThuoc", txtKichThuoc.Text);
                cmd.Parameters.AddWithValue("@DonGia", numDonGia.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Thêm món mới thành công!");
            LoadData(); // Tải lại toàn bộ
        }

        // (Hàm phụ cho btnThem)
        private int TimHoacTaoSanPham(string tenSP, int danhMucID, string tenFileAnh)
        {
            // 1. Tìm
            string queryFind = "SELECT SanPhamID FROM SanPham WHERE TenSanPham = @Ten";
            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmdFind = new SqlCommand(queryFind, conn))
            {
                cmdFind.Parameters.AddWithValue("@Ten", tenSP);
                conn.Open();
                object result = cmdFind.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    // Đã tìm thấy, trả về ID
                    return Convert.ToInt32(result);
                }
            }

            // 2. Không tìm thấy -> Tạo mới
            string queryCreate = @"
                INSERT INTO SanPham (TenSanPham, DanhMucID, MoTa)
                VALUES (@Ten, @DanhMucID, @MoTa);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmdCreate = new SqlCommand(queryCreate, conn))
            {
                cmdCreate.Parameters.AddWithValue("@Ten", tenSP);
                cmdCreate.Parameters.AddWithValue("@DanhMucID", danhMucID);
                cmdCreate.Parameters.AddWithValue("@MoTa", tenFileAnh);
                conn.Open();
                return (int)cmdCreate.ExecuteScalar(); // Trả về ID mới
            }
        }

        // Nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentMenuID == -1) return;

            string query = @"
                UPDATE Menu SET KichThuoc = @KichThuoc, DonGia = @DonGia 
                WHERE MenuID = @MenuID;

                UPDATE SanPham SET TenSanPham = @TenSP, DanhMucID = @DanhMucID, MoTa = @MoTa 
                WHERE SanPhamID = @SanPhamID;";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@KichThuoc", txtKichThuoc.Text);
                cmd.Parameters.AddWithValue("@DonGia", numDonGia.Value);
                cmd.Parameters.AddWithValue("@MenuID", currentMenuID);

                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@DanhMucID", (int)cmbDanhMuc.SelectedValue);
                cmd.Parameters.AddWithValue("@MoTa", txtDuongDanAnh.Text);
                cmd.Parameters.AddWithValue("@SanPhamID", currentSanPhamID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật thành công!");
            LoadData(); // Tải lại
        }

        // Nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentMenuID == -1) return;

            DialogResult res = MessageBox.Show("Bạn có chắc muốn xóa món này? (Không thể hoàn tác)",
                                               "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;

            // Phải xóa ở bảng ChiTietHoaDon và ChiTietCombo trước
            string query = @"
                DELETE FROM ChiTietHoaDon WHERE MenuID = @MenuID;
                DELETE FROM ChiTietCombo WHERE MenuID = @MenuID;
                DELETE FROM Menu WHERE MenuID = @MenuID;";
            // (Tạm thời không xóa SanPham gốc, vì có thể dùng chung)

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MenuID", currentMenuID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Xóa món thành công!");
            LoadData(); // Tải lại
        }
    }
}