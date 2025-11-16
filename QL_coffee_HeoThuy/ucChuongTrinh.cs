using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucChuongTrinh : UserControl
    {
        public event EventHandler GoBack;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // Biến để lưu trạng thái đang chọn
        private string loaiChuongTrinhHienTai = "Khuyến mãi";

        public ucChuongTrinh()
        {
            InitializeComponent();

            btnBack.Click += btnBack_Click;
            btnTaoMoi.Click += btnTaoMoi_Click;

            // Gán sự kiện cho các nút điều hướng bên trái
            lblKhuyenMai.Click += (s, e) => ChonLoaiChuongTrinh("Khuyến mãi");
            lblCombo.Click += (s, e) => ChonLoaiChuongTrinh("Combo");
            lblGiamGia.Click += (s, e) => ChonLoaiChuongTrinh("Giảm giá");
            // (Thêm cho các nút khác...)
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        public void LoadData()
        {
            // Mặc định tải mục "Chương trình khuyến mãi"
            ChonLoaiChuongTrinh("Khuyến mãi");
        }

        // HÀM MỚI: Xử lý khi chọn loại chương trình
        private void ChonLoaiChuongTrinh(string loai)
        {
            this.loaiChuongTrinhHienTai = loai; // Lưu lại
            lvChuongTrinh.Items.Clear();

            // Cập nhật giao diện
            if (loai == "Khuyến mãi")
            {
                lblTitle.Text = "Chương trình khuyến mãi";
                btnTaoMoi.Text = "Tạo CT khuyến mãi";
            }
            else if (loai == "Combo")
            {
                lblTitle.Text = "Combo";
                btnTaoMoi.Text = "Tạo Combo";
            }
            else if (loai == "Giảm giá")
            {
                lblTitle.Text = "Giảm giá";
                btnTaoMoi.Text = "Tạo giảm giá";
            }
            // (Thêm các 'else if' cho các mục khác...)

            // Tải dữ liệu từ CSDL
            LoadDataFromDatabase(loai);
        }

        // HÀM SỬA: Tải dữ liệu từ CSDL
        private void LoadDataFromDatabase(string loaiChuongTrinh)
        {
            lvChuongTrinh.Items.Clear();
            string query = "";
            bool laCombo = false;

            if (loaiChuongTrinh == "Khuyến mãi" || loaiChuongTrinh == "Giảm giá")
            {
                query = "SELECT TenChuongTrinh, ChiTiet FROM KhuyenMai WHERE LoaiChuongTrinh = @Loai AND TrangThai = 1";
            }
            else if (loaiChuongTrinh == "Combo")
            {
                query = "SELECT TenCombo, TongGia FROM Combo WHERE TrangThai = 1";
                laCombo = true;
            }
            else
            {
                return; // Không làm gì
            }

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Loai", loaiChuongTrinh);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader[0].ToString()); // TenChuongTrinh or TenCombo

                        if (laCombo)
                        {
                            item.SubItems.Add(Convert.ToDecimal(reader[1]).ToString("N0") + " đ"); // TongGia
                        }
                        else
                        {
                            item.SubItems.Add(reader[1].ToString()); // ChiTiet
                        }
                        lvChuongTrinh.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
                }
            }
        }

        // HÀM SỬA: Nút "Tạo..."
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            // Mở form tương ứng dựa trên trạng thái đã lưu
            switch (this.loaiChuongTrinhHienTai)
            {
                case "Khuyến mãi":
                    frmTaoKhuyenMai frmKM = new frmTaoKhuyenMai();
                    frmKM.ShowDialog();
                    break;
                case "Combo":
                    frmTaoCombo frmCB = new frmTaoCombo();
                    frmCB.ShowDialog();
                    break;
                case "Giảm giá":
                    // SỬA Ở ĐÂY: Mở form mới
                    frmTaoGiamGia frmGG = new frmTaoGiamGia();
                    frmGG.ShowDialog();
                    break;
            }

            // Tải lại danh sách sau khi Form tạo mới đóng lại
            LoadDataFromDatabase(this.loaiChuongTrinhHienTai);
        }
    }
}