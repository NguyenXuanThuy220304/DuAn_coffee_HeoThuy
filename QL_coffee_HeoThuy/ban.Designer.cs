namespace QL_coffee_HeoThuy
{
    partial class ban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panThuocTinh = new Panel();
            panel1 = new Panel();
            lblChucVu = new Label();
            btnTroVe = new Button();
            panDM = new Panel();
            panel2 = new Panel();
            btntaotkchonhanvien = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            lblma = new Label();
            lbltime = new Label();
            panbtnDangXuat = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panThuocTinh.SuspendLayout();
            panel1.SuspendLayout();
            panDM.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panbtnDangXuat.SuspendLayout();
            SuspendLayout();
            // 
            // panThuocTinh
            // 
            panThuocTinh.Controls.Add(panDM);
            panThuocTinh.Controls.Add(panel1);
            panThuocTinh.Location = new Point(8, 9);
            panThuocTinh.Name = "panThuocTinh";
            panThuocTinh.Size = new Size(1262, 832);
            panThuocTinh.TabIndex = 3;
            panThuocTinh.Visible = false;
            panThuocTinh.Paint += panThuocTinh_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panbtnDangXuat);
            panel1.Controls.Add(btnTroVe);
            panel1.Controls.Add(lblChucVu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 64);
            panel1.TabIndex = 0;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblChucVu.Location = new Point(82, 18);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(105, 25);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức vụ:";
            // 
            // btnTroVe
            // 
            btnTroVe.BackColor = SystemColors.ActiveCaption;
            btnTroVe.Dock = DockStyle.Left;
            btnTroVe.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnTroVe.ForeColor = SystemColors.ControlText;
            btnTroVe.Location = new Point(0, 0);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(76, 64);
            btnTroVe.TabIndex = 1;
            btnTroVe.Text = "<";
            btnTroVe.TextAlign = ContentAlignment.TopCenter;
            btnTroVe.UseVisualStyleBackColor = false;
            // 
            // panDM
            // 
            panDM.BackColor = SystemColors.AppWorkspace;
            panDM.Controls.Add(label4);
            panDM.Controls.Add(label3);
            panDM.Controls.Add(button3);
            panDM.Controls.Add(button2);
            panDM.Controls.Add(btntaotkchonhanvien);
            panDM.Controls.Add(panel2);
            panDM.Location = new Point(0, 69);
            panDM.Name = "panDM";
            panDM.Size = new Size(1259, 759);
            panDM.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(lbltime);
            panel2.Controls.Add(lblma);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 537);
            panel2.TabIndex = 0;
            // 
            // btntaotkchonhanvien
            // 
            btntaotkchonhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntaotkchonhanvien.Location = new Point(4, 547);
            btntaotkchonhanvien.Name = "btntaotkchonhanvien";
            btntaotkchonhanvien.Size = new Size(408, 105);
            btntaotkchonhanvien.TabIndex = 1;
            btntaotkchonhanvien.Text = "Tạo tài khoản cho nhân viên";
            btntaotkchonhanvien.TextAlign = ContentAlignment.TopLeft;
            btntaotkchonhanvien.UseVisualStyleBackColor = true;
            btntaotkchonhanvien.Click += btntaotkchonhanvien_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(426, 547);
            button2.Name = "button2";
            button2.Size = new Size(408, 105);
            button2.TabIndex = 1;
            button2.Text = "Chương trình bán hàng";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(848, 547);
            button3.Name = "button3";
            button3.Size = new Size(408, 105);
            button3.TabIndex = 1;
            button3.Text = "Thực đơn";
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(830, 23);
            button4.Name = "button4";
            button4.Size = new Size(408, 105);
            button4.TabIndex = 1;
            button4.Text = "Quản lý ca\r\n\r\n";
            button4.TextAlign = ContentAlignment.TopLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(830, 166);
            button5.Name = "button5";
            button5.Size = new Size(408, 105);
            button5.TabIndex = 1;
            button5.Text = "Báo cáo";
            button5.TextAlign = ContentAlignment.TopLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(0, -38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(815, 603);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblma
            // 
            lblma.AutoSize = true;
            lblma.Location = new Point(844, 63);
            lblma.Name = "lblma";
            lblma.Size = new Size(52, 20);
            lblma.TabIndex = 3;
            lblma.Text = "Mã ca:";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Location = new Point(844, 93);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(123, 20);
            lbltime.TabIndex = 3;
            lbltime.Text = "Thời gian mở ca: ";
            // 
            // panbtnDangXuat
            // 
            panbtnDangXuat.BackColor = SystemColors.ActiveCaption;
            panbtnDangXuat.BorderStyle = BorderStyle.FixedSingle;
            panbtnDangXuat.Controls.Add(label1);
            panbtnDangXuat.Dock = DockStyle.Right;
            panbtnDangXuat.Location = new Point(1050, 0);
            panbtnDangXuat.Name = "panbtnDangXuat";
            panbtnDangXuat.Size = new Size(212, 64);
            panbtnDangXuat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 17);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "Đăng xuất";
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(1087, 500);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(159, 31);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đổi mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.Location = new Point(843, 209);
            label2.Name = "label2";
            label2.Size = new Size(374, 47);
            label2.TabIndex = 5;
            label2.Text = "Doanh thu, chương trình khuyến mãi, Mặt hàng bán chạy nhất";
            // 
            // label3
            // 
            label3.Location = new Point(444, 597);
            label3.Name = "label3";
            label3.Size = new Size(195, 22);
            label3.TabIndex = 6;
            label3.Text = "Khuyến mãi, phiếu giảm giá";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(864, 597);
            label4.Name = "label4";
            label4.Size = new Size(171, 22);
            label4.TabIndex = 6;
            label4.Text = "Thêm, sửa, xóa thực đơn";
            // 
            // ban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 851);
            Controls.Add(panThuocTinh);
            Name = "ban";
            Text = "Form1";
            panThuocTinh.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panDM.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panbtnDangXuat.ResumeLayout(false);
            panbtnDangXuat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pantieude;
        private Panel pankv;
        private Label lblma;
        private FlowLayoutPanel flpKhuVuc;
        private Panel panThuocTinh;
        private Panel panel1;
        private Button btnTroVe;
        private Label lblChucVu;
        private Panel panDM;
        private Button button3;
        private Button button2;
        private Button btntaotkchonhanvien;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox1;
        private Label lbltime;
        private Panel panbtnDangXuat;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}