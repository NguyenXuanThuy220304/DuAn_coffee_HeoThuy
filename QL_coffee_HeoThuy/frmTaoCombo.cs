using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QL_coffee_HeoThuy
{
    public partial class frmTaoCombo : Form
    {
        private string chuoiKetNoi = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QL_coffee;Integrated Security=True;Encrypt=False";

        // Class nội bộ để chứa danh sách món
        private class MenuVatPham
        {
            public int MenuID { get; set; }
            public string TenHienThi { get; set; }
        }

        public frmTaoCombo()
        {
            InitializeComponent();
        }

        // Khi Form load, tải tất cả món ăn từ CSDL
        private void frmTaoCombo_Load(object sender, EventArgs e)
        {
            LoadDanhSachMon();
        }

        private void LoadDanhSachMon()
        {
            List<MenuVatPham> danhSachMon = new List<MenuVatPham>();

            string query = @"
                SELECT m.MenuID, s.TenSanPham, m.KichThuoc 
                FROM Menu m 
                JOIN SanPham s ON m.SanPhamID = s.SanPhamID";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string tenSP = reader["TenSanPham"].ToString();
                    string kichThuoc = reader["KichThuoc"].ToString();
                    danhSachMon.Add(new MenuVatPham
                    {
                        MenuID = Convert.ToInt32(reader["MenuID"]),
                        TenHienThi = string.IsNullOrEmpty(kichThuoc) ? tenSP : $"{tenSP} ({kichThuoc})"
                    });
                }
            }

            // Gán vào ComboBox
            cmbMonAn.DataSource = danhSachMon;
            cmbMonAn.DisplayMember = "TenHienThi";
            cmbMonAn.ValueMember = "MenuID";
        }

        // Nút "Thêm" món vào DataGridView
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cmbMonAn.SelectedItem == null) return;

            MenuVatPham monChon = cmbMonAn.SelectedItem as MenuVatPham;
            int soLuong = (int)numSoLuong.Value;

            // (Bạn có thể thêm logic kiểm tra món đã tồn tại trong lưới chưa)

            // Thêm vào DataGridView
            dgvChiTietCombo.Rows.Add(monChon.MenuID, monChon.TenHienThi, soLuong);
        }

        // Nút "Lưu Combo" (Phần quan trọng nhất)
        private void btnLuuCombo_Click(object sender, EventArgs e)
        {
            string tenCombo = txtTenCombo.Text;
            decimal tongGia = numTongGia.Value;

            if (string.IsNullOrEmpty(tenCombo))
            {
                MessageBox.Show("Vui lòng nhập Tên Combo.");
                return;
            }
            if (dgvChiTietCombo.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 món vào Combo.");
                return;
            }

            // Bắt đầu Giao dịch CSDL (Transaction)
            // Việc này đảm bảo nếu lưu ChiTietCombo lỗi,
            // thì Combo cũng sẽ không được tạo.

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. LƯU BẢNG CHA (Combo)
                    string queryCombo = @"
                        INSERT INTO Combo (TenCombo, TongGia, TrangThai)
                        VALUES (@Ten, @Gia, 1);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);"; // Lấy ID vừa tạo

                    int comboIDMoi;
                    using (SqlCommand cmdCombo = new SqlCommand(queryCombo, conn, transaction))
                    {
                        cmdCombo.Parameters.AddWithValue("@Ten", tenCombo);
                        cmdCombo.Parameters.AddWithValue("@Gia", tongGia);
                        comboIDMoi = (int)cmdCombo.ExecuteScalar();
                    }

                    // 2. LƯU BẢNG CON (ChiTietCombo)
                    string queryChiTiet = @"
                        INSERT INTO ChiTietCombo (ComboID, MenuID, SoLuong)
                        VALUES (@ComboID, @MenuID, @SoLuong)";

                    // Lặp qua từng dòng trong DataGridView
                    foreach (DataGridViewRow row in dgvChiTietCombo.Rows)
                    {
                        using (SqlCommand cmdChiTiet = new SqlCommand(queryChiTiet, conn, transaction))
                        {
                            cmdChiTiet.Parameters.AddWithValue("@ComboID", comboIDMoi);
                            cmdChiTiet.Parameters.AddWithValue("@MenuID", Convert.ToInt32(row.Cells["colMenuID"].Value));
                            cmdChiTiet.Parameters.AddWithValue("@SoLuong", Convert.ToInt32(row.Cells["colSoLuong"].Value));
                            cmdChiTiet.ExecuteNonQuery();
                        }
                    }

                    // 3. Nếu mọi thứ thành công, Commit giao dịch
                    transaction.Commit();
                    MessageBox.Show("Tạo Combo thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // 4. Nếu có lỗi, Rollback (hủy bỏ)
                    transaction.Rollback();
                    MessageBox.Show("Lỗi tạo Combo: " + ex.Message);
                }
            }
        }
    }
}