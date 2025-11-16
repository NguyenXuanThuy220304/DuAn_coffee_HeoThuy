 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class ucTheBan : UserControl
    {
        public int BanID { get; set; } // Biến này quan trọng nhất
        public string TrangThai { get; set; }
        public string TenBan
        {
            get { return lblTenBan.Text; }
        }
        public ucTheBan()
        {
            InitializeComponent();
        }
        public void CapNhatThongTin(string ten, string thoiGian, string gia, string trangThai)
        {
            lblTenBan.Text = ten;
            lblThoiGian.Text = thoiGian;
            lblGia.Text = gia;
            this.TrangThai = trangThai;

            // Đổi màu dựa trên trạng thái
            if (trangThai == "Trống")
            {
                this.BackColor = Color.SkyBlue; // Màu bàn trống
            }
            else
            {
                this.BackColor = Color.Orange; // Màu bàn có khách
            }
        }
    }
}
    

