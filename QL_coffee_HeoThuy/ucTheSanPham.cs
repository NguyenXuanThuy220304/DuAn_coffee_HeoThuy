using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy // Đảm bảo namespace này khớp với project của bạn
{
    public partial class ucTheSanPham : UserControl
    {
        public ucTheSanPham()
        {
            InitializeComponent();
        }

        // --- TẠO CÁC THUỘC TÍNH (PROPERTIES) CÔNG KHAI ---
        // Đây là các "cổng" để Form chính gán dữ liệu vào

        // Cổng để gán TÊN vào lblTen
        public string ProductName
        {
            get { return lblTen.Text; }
            set { lblTen.Text = value; }
        }

        // Cổng để gán GIÁ vào lblGia
        public string ProductPrice
        {
            get { return lblGia.Text; }
            set { lblGia.Text = value; }
        }

        // Cổng để gán ẢNH vào picAnh
        public Image ProductImage
        {
            get { return picAnh.Image; }
            set { picAnh.Image = value; }
        }

        // Cổng để LƯU TRỮ đối tượng SanPham (dùng thuộc tính Tag có sẵn)
        public object ProductTag
        {
            get { return this.Tag; }
            set { this.Tag = value; }
        }

        // --- XỬ LÝ SỰ KIỆN CLICK (NÂNG CAO) ---
        // Giúp click vào Ảnh, Tên, hoặc Giá cũng đều tính là click vào cả thẻ

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Gọi hàm gốc

            // Gán sự kiện click của các control con
            // để chúng "chuyển tiếp" sự kiện cho UserControl cha (this)
            picAnh.Click += (sender, args) => this.OnClick(args);
            lblTen.Click += (sender, args) => this.OnClick(args);
            lblGia.Click += (sender, args) => this.OnClick(args);
        }
    }
}