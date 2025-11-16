using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class Kaavan : Form
    {
        // 1. Khai báo 4 UserControl
        ucThuocTinh ucThuocTinh1;
        ucBanHang ucBanHang1;
        ucKhuVuc ucKhuVuc1;
        ucQuanLyCa ucQuanLyCa1;
        ucThongTinCacCa ucThongTinCacCa1; // Thêm UserControl danh sách ca
        ucChuongTrinh ucChuongTrinh1;
        public Kaavan()
        {
            InitializeComponent();

            // 2. Khởi tạo (new)
            ucBanHang1 = new ucBanHang();
            ucKhuVuc1 = new ucKhuVuc();
            ucThuocTinh1 = new ucThuocTinh();
            ucQuanLyCa1 = new ucQuanLyCa();
            ucThongTinCacCa1 = new ucThongTinCacCa();
            ucChuongTrinh1 = new ucChuongTrinh();

            // 3. Cài đặt Dock
            ucBanHang1.Dock = DockStyle.Fill;
            ucKhuVuc1.Dock = DockStyle.Fill;
            ucThuocTinh1.Dock = DockStyle.Fill;
            ucQuanLyCa1.Dock = DockStyle.Fill;
            ucThongTinCacCa1.Dock = DockStyle.Fill;
            ucChuongTrinh1.Dock = DockStyle.Fill;
            // 4. Thêm vào 'panuc'
            panuc.Controls.Add(ucBanHang1);
            panuc.Controls.Add(ucKhuVuc1);
            panuc.Controls.Add(ucThuocTinh1);
            panuc.Controls.Add(ucQuanLyCa1);
            panuc.Controls.Add(ucThongTinCacCa1);
            panuc.Controls.Add(ucChuongTrinh1);
            // 5. Đăng ký sự kiện
            ucKhuVuc1.TableSelected += UcKhuVuc_TableSelected;
            ucBanHang1.GoBack += UcBanHang_GoBack;
            ucBanHang1.PaymentCompleted += UcBanHang_PaymentCompleted;
            ucThuocTinh1.ManageShiftClicked += UcThuocTinh_ManageShiftClicked;
            ucQuanLyCa1.GoBack += UcQuanLyCa_GoBack;
            ucQuanLyCa1.ViewShiftListClicked += UcQuanLyCa_ViewShiftListClicked;
            ucThongTinCacCa1.GoBack += UcThongTinCacCa_GoBack;
            ucThuocTinh1.LoggedOut += UcThuocTinh_LoggedOut;
            ucThuocTinh1.ChuongTrinhBanHangClicked += UcThuocTinh_ChuongTrinhBanHangClicked;
            ucChuongTrinh1.GoBack += UcChuongTrinh_GoBack;
        }

        private void Kaavan_Load(object sender, EventArgs e)
        {
            // Khi load, hiển thị Khu Vực đầu tiên
            panbtnkhuvuc_Click(sender, e);
        }

        // === CÁC NÚT ĐIỀU HƯỚNG CHÍNH (DƯỚI CÙNG) ===

        private void panbtnbanhang_Click(object sender, EventArgs e)
        {
            panbtnkhuvuc_Click(sender, e);
        }

        // --- SỬA LỖI ĐIỀU HƯỚNG ---
        private void panbtnkhuvuc_Click(object sender, EventArgs e)
        {
            ucKhuVuc1.BringToFront(); // Dùng BringToFront
            ucKhuVuc1.TaiDanhSachBan();
        }

        // --- SỬA LỖI ĐIỀU HƯỚNG ---
        private void panbtnql_Click(object sender, EventArgs e)
        {
            ucThuocTinh1.BringToFront(); // Dùng BringToFront
            ucThuocTinh1.HienThiDuLieu();
        }

        // === CÁC HÀM TRUNG GIAN (MEDIATOR) ===
        private void UcKhuVuc_TableSelected(object sender, TableSelectEventArgs e)
        {
            ucBanHang1.LoadOrder(e.BanID, e.TenBan, e.HoaDonID, e.GioVao);
            ucBanHang1.BringToFront(); // Dùng BringToFront
        }

        private void UcBanHang_GoBack(object sender, EventArgs e)
        {
            panbtnkhuvuc_Click(sender, e);
        }

        private void UcBanHang_PaymentCompleted(object sender, EventArgs e)
        {
            panbtnkhuvuc_Click(sender, e);
        }

        private void UcThuocTinh_ManageShiftClicked(object sender, EventArgs e)
        {
            ucQuanLyCa1.LoadData();
            ucQuanLyCa1.BringToFront();
        }

        private void UcQuanLyCa_GoBack(object sender, EventArgs e)
        {
            ucThuocTinh1.HienThiDuLieu();
            ucThuocTinh1.BringToFront();
        }

        private void UcQuanLyCa_ViewShiftListClicked(object sender, EventArgs e)
        {
            ucThongTinCacCa1.LoadData();
            ucThongTinCacCa1.BringToFront();
        }

        private void UcThongTinCacCa_GoBack(object sender, EventArgs e)
        {
            ucQuanLyCa1.LoadData();
            ucQuanLyCa1.BringToFront();
        }
        // HÀM MỚI: XỬ LÝ KHI NHẬN ĐƯỢC TÍN HIỆU ĐĂNG XUẤT
        private void UcThuocTinh_LoggedOut(object sender, EventArgs e)
        {
            // 1. Tìm Form Đăng nhập (tên là 'dang_nhap' theo Solution Explorer)
            // đang chạy bị ẩn đi.
            dang_nhap frmLogin = Application.OpenForms.OfType<dang_nhap>().FirstOrDefault();

            if (frmLogin != null)
            {
                // 2. Cho hiện lại Form Đăng nhập
                frmLogin.Show();
            }
            else
            {
                // (Dự phòng: Nếu Form Đăng nhập đã bị đóng, tạo cái mới)
                dang_nhap newLogin = new dang_nhap();
                newLogin.Show();
            }

            // 3. Đóng Form Kaavan này lại
            this.Close();
        }
        // === THÊM 2 HÀM MỚI NÀY ===

        // Khi ucThuocTinh báo "Mở chương trình bán hàng"
        private void UcThuocTinh_ChuongTrinhBanHangClicked(object sender, EventArgs e)
        {
            ucChuongTrinh1.LoadData();
            ucChuongTrinh1.BringToFront();
        }

        // Khi ucChuongTrinh báo "Quay lại"
        private void UcChuongTrinh_GoBack(object sender, EventArgs e)
        {
            ucThuocTinh1.HienThiDuLieu(); // Tải lại ucThuocTinh
            ucThuocTinh1.BringToFront(); // Quay về ucThuocTinh
        }
    }
}