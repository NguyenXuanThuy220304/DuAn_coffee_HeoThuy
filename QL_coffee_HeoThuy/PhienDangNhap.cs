// Đây là file PhienDangNhap.cs
using System;

public static class PhienDangNhap
{
    // Chúng ta dùng 'static' để có thể truy cập
    // các biến này từ bất kỳ Form nào

    public static int TaiKhoanID { get; set; }
    public static string TenDangNhap { get; set; }
    public static string ChucVu { get; set; }

    // (Bạn có thể thêm các thông tin khác như Tên nhân viên...)
}