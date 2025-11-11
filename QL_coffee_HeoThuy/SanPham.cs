using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_coffee_HeoThuy
{
    public class SanPham
    {
        public int ID_Menu { get; set; } // Lấy ID từ bảng Menu
        public string Ten { get; set; }     // Sẽ là "Tên (Kích thước)"
        public decimal Gia { get; set; }   // Giá từ bảng Menu
        public string DuongDanAnh { get; set; } // Đường dẫn ảnh từ bảng SanPham
    }
}
