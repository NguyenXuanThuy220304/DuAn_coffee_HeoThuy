namespace QL_coffee_HeoThuy
{
    partial class dang_nhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelLogin = new Panel();
            picLogo = new PictureBox(); // Thêm PictureBox
            button1 = new Button();
            txtmk = new TextBox();
            txttk = new TextBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 190);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(400, 50);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 250);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(116, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 320);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(82, 23);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // panelLogin
            // 
            // Đổi màu nền cho đồng bộ
            panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(picLogo);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(txtmk);
            panelLogin.Controls.Add(txttk);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.ImeMode = ImeMode.NoControl;
            // Căn giữa panel
            panelLogin.Location = new Point(191, 52);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(400, 450);
            panelLogin.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo1; // Lấy logo từ Resources
            picLogo.Location = new Point(125, 30);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(150, 150);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 3;
            picLogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(50, 400);
            button1.Name = "button1";
            button1.Size = new Size(300, 45);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtmk
            // 
            txtmk.Font = new Font("Segoe UI", 12F);
            txtmk.Location = new Point(50, 345);
            txtmk.Name = "txtmk";
            txtmk.PasswordChar = '*'; // Thêm ký tự che mật khẩu
            txtmk.Size = new Size(300, 34);
            txtmk.TabIndex = 1;
            // 
            // txttk
            // 
            txttk.Font = new Font("Segoe UI", 12F);
            txttk.Location = new Point(50, 275);
            txttk.Name = "txttk";
            txttk.Size = new Size(300, 34);
            txttk.TabIndex = 0; // Đổi TabIndex
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            // Đổi màu nền Form
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            // Bỏ ảnh nền
            // BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(783, 554);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow; // Cửa sổ gọn gàng
            Name = "dang_nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập Kaavan Coffee";
            Load += dang_nhap_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(picLogo)).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelLogin;
        private TextBox txttk;
        private TextBox txtmk;
        private Button button1;
        private PictureBox picLogo; // Khai báo PictureBox
    }
}