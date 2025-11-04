using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // <--- SỬA 1: Thêm thư viện này

namespace QL_coffee_HeoThuy
{
    public partial class Trang_chu : Form
    {
        public Trang_chu()
        {
            InitializeComponent();
        }

        // Khai báo biến ở đây là đúng
        private List<string> imagePaths = new List<string>();
        private int currentImageIndex = 0;

        // SỬA 2: Chuyển toàn bộ code từ panel_Paint vào đây
        private void Trang_chu_Load(object sender, EventArgs e)
        {
            // Cài đặt cho PictureBox (nên đặt ở đây)
            picSlider.SizeMode = PictureBoxSizeMode.StretchImage; // Hoặc StretchImage

            // 3. Tải danh sách ảnh từ thư mục
            LoadImagePaths();

            // 4. Hiển thị ảnh đầu tiên và khởi động Timer
            if (imagePaths.Count > 0)
            {
                // Hiển thị ảnh đầu tiên
                picSlider.ImageLocation = imagePaths[0];

                // Cấu hình và khởi động Timer
                sliderTimer.Interval = 3000; // 3 giây
                sliderTimer.Enabled = true;
                sliderTimer.Start();
            }
            else
            {
                // Xử lý trường hợp không tìm thấy ảnh
                picSlider.Image = null;
                MessageBox.Show("Không tìm thấy ảnh nào trong thư mục 'hinh_anh_mo_dau'");
            }
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {
            // Để trống
        }

        private void LoadImagePaths()
        {
            try
            {
                string appPath = Application.StartupPath;
                string imagesFolder = Path.Combine(appPath, "hinh_anh_mo_dau");

                if (Directory.Exists(imagesFolder))
                {
                    // Lấy tất cả file .jpg và .png (SỬA 4: Thêm cả .png)
                    imagePaths.AddRange(Directory.GetFiles(imagesFolder, "*.jpg"));
                    imagePaths.AddRange(Directory.GetFiles(imagesFolder, "*.png")); // Thêm dòng này
                }
                else
                {
                    // Thông báo nếu không tìm thấy thư mục
                    MessageBox.Show("Không tìm thấy thư mục: " + imagesFolder);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
        }

        // Sự kiện Tick của Timer đã đúng
        private void sliderTimer_Tick(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0) return;

            currentImageIndex++;

            if (currentImageIndex >= imagePaths.Count)
            {
                currentImageIndex = 0;
            }

            picSlider.ImageLocation = imagePaths[currentImageIndex];
        }
        private void picSlider_Click(object sender, EventArgs e)
        {

        }

        private void sliderTimer_Tick_1(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0) return;

            currentImageIndex++;

            if (currentImageIndex >= imagePaths.Count)
            {
                currentImageIndex = 0;
            }

            picSlider.ImageLocation = imagePaths[currentImageIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dang_nhap dn = new dang_nhap();
            dn.Show();
            this.Hide();

        }
    }
}