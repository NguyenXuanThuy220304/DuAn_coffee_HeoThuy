using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucChuongTrinh : UserControl
    {
        // Sự kiện (event) để báo cho Form Kaavan là "Tôi đã xong, hãy quay lại"
        public event EventHandler GoBack;

        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        public ucChuongTrinh()
        {
            InitializeComponent();

            // Gán sự kiện
            btnBack.Click += btnBack_Click;
            btnTaoMoi.Click += btnTaoMoi_Click;

            // Gán sự kiện cho các nút điều hướng bên trái
            lblKhuyenMai.Click += (s, e) => LoadChuongTrinh("Khuyến mãi");
            lblCombo.Click += (s, e) => LoadChuongTrinh("Combo");
            lblGiamGia.Click += (s, e) => LoadChuongTrinh("Giảm giá");
            // (Thêm cho các nút khác...)
        }

        // Nút quay lại '<-'
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Bắn sự kiện "GoBack" lên Form Kaavan
            GoBack?.Invoke(this, EventArgs.Empty);
        }

        // Hàm này được Kaavan gọi khi UC này được hiển thị
        public void LoadData()
        {
            // Mặc định tải mục "Chương trình khuyến mãi"
            LoadChuongTrinh("Khuyến mãi");
        }

        // Tải dữ liệu vào ListView dựa trên danh mục
        private void LoadChuongTrinh(string loaiChuongTrinh)
        {
            // (Vì CSDL của bạn chưa có bảng KhuyenMai,
            // chúng ta sẽ dùng dữ liệu giả lập (dummy data) giống ảnh mẫu)

            lvChuongTrinh.Items.Clear();

            if (loaiChuongTrinh == "Khuyến mãi")
            {
                lblTitle.Text = "Chương trình khuyến mãi";
                btnTaoMoi.Text = "Tạo CT khuyến mãi";

                // Thêm dữ liệu giả lập
                var item1 = new ListViewItem("ĐỒNG GIÁ 25K - GAMUDA CS5");
                item1.SubItems.Add("giảm giá 100%");
                lvChuongTrinh.Items.Add(item1);

                var item2 = new ListViewItem("GIẢM 100%");
                item2.SubItems.Add("giảm 100%");
                lvChuongTrinh.Items.Add(item2);
            }
            else if (loaiChuongTrinh == "Combo")
            {
                lblTitle.Text = "Combo";
                btnTaoMoi.Text = "Tạo Combo";
                // (Thêm dữ liệu giả lập cho Combo)
            }
            else if (loaiChuongTrinh == "Giảm giá")
            {
                lblTitle.Text = "Giảm giá";
                btnTaoMoi.Text = "Tạo giảm giá";
                // (Thêm dữ liệu giả lập cho Giảm giá)
            }
            // (Thêm các 'else if' cho các mục khác...)
        }

        // Nút "Tạo..."
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            // (Sau này, bạn sẽ mở một Form mới 'frmTaoKhuyenMai' tại đây)
            MessageBox.Show("Mở Form tạo mới...");
        }
    }
}