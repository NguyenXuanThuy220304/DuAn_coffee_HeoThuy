using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_coffee_HeoThuy
{
    // (Bên ngoài class ucBanHang)
    public class GiamGia
    {
        public int ID { get; set; }
        public string TenHienThi { get; set; } // "Giảm 10%"
        public string ChiTiet { get; set; } // "10%" hoặc "20000" (giảm tiền)
        public string Loai { get; set; } // "Giảm giá", "Combo" (đồng giá)

        public override string ToString()
        {
            return TenHienThi;
        }
    }
}
