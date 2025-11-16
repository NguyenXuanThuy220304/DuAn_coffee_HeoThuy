using System; // Cần dùng thư viện này

namespace QL_coffee_HeoThuy
{
    public class TableSelectEventArgs : EventArgs
    {
        public int BanID { get; set; }
        public string TenBan { get; set; }
        public int HoaDonID { get; set; }
        public DateTime GioVao { get; set; }
    }
}