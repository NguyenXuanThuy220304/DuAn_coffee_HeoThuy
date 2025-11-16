using System;
using System.Drawing;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucTheBan : UserControl
    {
        public int BanID { get; set; }
        public string TrangThai { get; set; }
        public int HoaDonID { get; set; }
        public DateTime GioVao { get; set; }

        public string TenBan
        {
            get { return lblTenBan.Text; }
        }

        public ucTheBan()
        {
            InitializeComponent();

            // "Truyền" sự kiện click từ 3 Label ra UserControl
            this.lblTenBan.Click += (s, e) => this.OnClick(e);
            this.lblThoiGian.Click += (s, e) => this.OnClick(e);
            this.lblGia.Click += (s, e) => this.OnClick(e);
        }

        // --- HÀM ĐÃ SỬA ---
        // Quay lại dùng 4 tham số như logic cũ của bạn
        // (Trong file ucTheBan.cs)

        // THAY THẾ HÀM NÀY:
        public void CapNhatThongTin(string ten, string thoiGian, string gia, string trangThai)
        {
            lblTenBan.Text = ten;
            this.TrangThai = trangThai;

            if (trangThai == "Trống")
            {
                // 1. Ẩn 2 label
                lblThoiGian.Visible = false;
                lblGia.Visible = false;

                // 2. Đổi màu (màu xanh nhạt)
                this.BackColor = System.Drawing.Color.FromArgb(204, 229, 255);
            }
            else // "Có khách"
            {
                // 1. Gán giá trị và HIỆN 2 label
                lblThoiGian.Text = thoiGian;
                lblGia.Text = gia;
                lblThoiGian.Visible = true;
                lblGia.Visible = true;

                // 2. Đổi màu (màu cam nhạt)
                this.BackColor = System.Drawing.Color.FromArgb(255, 213, 153);
                lblGia.ForeColor = Color.DarkRed;
            }
        }
    }
}