namespace QL_coffee_HeoThuy
{
    partial class ucChuongTrinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            splitGiaoDien = new SplitContainer();
            panNav = new Panel();
            panGiamGia = new Panel();
            lblGiamGia = new Label();
            panCombo = new Panel();
            lblCombo = new Label();
            panKhuyenMai = new Panel();
            lblKhuyenMai = new Label();
            lvChuongTrinh = new ListView();
            colTen = new ColumnHeader();
            colChiTiet = new ColumnHeader();
            panelContentHeader = new Panel();
            btnTaoMoi = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitGiaoDien).BeginInit();
            splitGiaoDien.Panel1.SuspendLayout();
            splitGiaoDien.Panel2.SuspendLayout();
            splitGiaoDien.SuspendLayout();
            panNav.SuspendLayout();
            panGiamGia.SuspendLayout();
            panCombo.SuspendLayout();
            panKhuyenMai.SuspendLayout();
            panelContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(60, 70, 90);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1262, 60);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Chương trình bán hàng";
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Left;
            btnBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(64, 60);
            btnBack.TabIndex = 0;
            btnBack.Text = "<-";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // splitGiaoDien
            // 
            splitGiaoDien.Dock = DockStyle.Fill;
            splitGiaoDien.Location = new Point(0, 60);
            splitGiaoDien.Name = "splitGiaoDien";
            // 
            // splitGiaoDien.Panel1
            // 
            splitGiaoDien.Panel1.BackColor = Color.FromArgb(45, 52, 71);
            splitGiaoDien.Panel1.Controls.Add(panNav);
            splitGiaoDien.Panel1.Padding = new Padding(5);
            // 
            // splitGiaoDien.Panel2
            // 
            splitGiaoDien.Panel2.BackColor = Color.FromArgb(45, 52, 71);
            splitGiaoDien.Panel2.Controls.Add(lvChuongTrinh);
            splitGiaoDien.Panel2.Controls.Add(panelContentHeader);
            splitGiaoDien.Panel2.Padding = new Padding(5);
            splitGiaoDien.Size = new Size(1262, 772);
            splitGiaoDien.SplitterDistance = 300;
            splitGiaoDien.TabIndex = 3;
            // 
            // panNav
            // 
            panNav.BackColor = Color.FromArgb(55, 62, 81);
            panNav.Controls.Add(panGiamGia);
            panNav.Controls.Add(panCombo);
            panNav.Controls.Add(panKhuyenMai);
            panNav.Dock = DockStyle.Fill;
            panNav.Location = new Point(5, 5);
            panNav.Name = "panNav";
            panNav.Size = new Size(290, 762);
            panNav.TabIndex = 0;
            // 
            // panGiamGia
            // 
            panGiamGia.BorderStyle = BorderStyle.FixedSingle;
            panGiamGia.Controls.Add(lblGiamGia);
            panGiamGia.Dock = DockStyle.Top;
            panGiamGia.Location = new Point(0, 120);
            panGiamGia.Name = "panGiamGia";
            panGiamGia.Size = new Size(290, 60);
            panGiamGia.TabIndex = 2;
            // 
            // lblGiamGia
            // 
            lblGiamGia.Dock = DockStyle.Fill;
            lblGiamGia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiamGia.ForeColor = Color.White;
            lblGiamGia.Location = new Point(0, 0);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Padding = new Padding(10, 0, 0, 0);
            lblGiamGia.Size = new Size(288, 58);
            lblGiamGia.TabIndex = 0;
            lblGiamGia.Text = "Giảm giá";
            lblGiamGia.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panCombo
            // 
            panCombo.BorderStyle = BorderStyle.FixedSingle;
            panCombo.Controls.Add(lblCombo);
            panCombo.Dock = DockStyle.Top;
            panCombo.Location = new Point(0, 60);
            panCombo.Name = "panCombo";
            panCombo.Size = new Size(290, 60);
            panCombo.TabIndex = 1;
            // 
            // lblCombo
            // 
            lblCombo.Dock = DockStyle.Fill;
            lblCombo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblCombo.ForeColor = Color.White;
            lblCombo.Location = new Point(0, 0);
            lblCombo.Name = "lblCombo";
            lblCombo.Padding = new Padding(10, 0, 0, 0);
            lblCombo.Size = new Size(288, 58);
            lblCombo.TabIndex = 0;
            lblCombo.Text = "Combo";
            lblCombo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panKhuyenMai
            // 
            panKhuyenMai.BorderStyle = BorderStyle.FixedSingle;
            panKhuyenMai.Controls.Add(lblKhuyenMai);
            panKhuyenMai.Dock = DockStyle.Top;
            panKhuyenMai.Location = new Point(0, 0);
            panKhuyenMai.Name = "panKhuyenMai";
            panKhuyenMai.Size = new Size(290, 60);
            panKhuyenMai.TabIndex = 0;
            // 
            // lblKhuyenMai
            // 
            lblKhuyenMai.Dock = DockStyle.Fill;
            lblKhuyenMai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblKhuyenMai.ForeColor = Color.White;
            lblKhuyenMai.Location = new Point(0, 0);
            lblKhuyenMai.Name = "lblKhuyenMai";
            lblKhuyenMai.Padding = new Padding(10, 0, 0, 0);
            lblKhuyenMai.Size = new Size(288, 58);
            lblKhuyenMai.TabIndex = 0;
            lblKhuyenMai.Text = "Chương trình khuyến mãi";
            lblKhuyenMai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvChuongTrinh
            // 
            lvChuongTrinh.BackColor = SystemColors.Menu;
            lvChuongTrinh.Columns.AddRange(new ColumnHeader[] { colTen, colChiTiet });
            lvChuongTrinh.Dock = DockStyle.Fill;
            lvChuongTrinh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lvChuongTrinh.FullRowSelect = true;
            lvChuongTrinh.GridLines = true;
            lvChuongTrinh.Location = new Point(5, 70);
            lvChuongTrinh.Name = "lvChuongTrinh";
            lvChuongTrinh.Size = new Size(948, 697);
            lvChuongTrinh.TabIndex = 1;
            lvChuongTrinh.UseCompatibleStateImageBehavior = false;
            lvChuongTrinh.View = View.Details;
            // 
            // colTen
            // 
            colTen.Text = "Tên chương trình";
            colTen.Width = 400;
            // 
            // colChiTiet
            // 
            colChiTiet.Text = "Chi tiết";
            colChiTiet.Width = 300;
            // 
            // panelContentHeader
            // 
            panelContentHeader.BackColor = Color.FromArgb(45, 52, 71);
            panelContentHeader.Controls.Add(btnTaoMoi);
            panelContentHeader.Dock = DockStyle.Top;
            panelContentHeader.Location = new Point(5, 5);
            panelContentHeader.Name = "panelContentHeader";
            panelContentHeader.Size = new Size(948, 65);
            panelContentHeader.TabIndex = 0;
            // 
            // btnTaoMoi
            // 
            btnTaoMoi.BackColor = SystemColors.MenuHighlight;
            btnTaoMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoMoi.ForeColor = Color.White;
            btnTaoMoi.Location = new Point(3, 10);
            btnTaoMoi.Name = "btnTaoMoi";
            btnTaoMoi.Size = new Size(200, 45);
            btnTaoMoi.TabIndex = 0;
            btnTaoMoi.Text = "Tạo CT khuyến mãi";
            btnTaoMoi.UseVisualStyleBackColor = false;
            // 
            // ucChuongTrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 52, 71);
            Controls.Add(splitGiaoDien);
            Controls.Add(panelHeader);
            Name = "ucChuongTrinh";
            Size = new Size(1262, 832);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitGiaoDien.Panel1.ResumeLayout(false);
            splitGiaoDien.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitGiaoDien).EndInit();
            splitGiaoDien.ResumeLayout(false);
            panNav.ResumeLayout(false);
            panGiamGia.ResumeLayout(false);
            panCombo.ResumeLayout(false);
            panKhuyenMai.ResumeLayout(false);
            panelContentHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SplitContainer splitGiaoDien;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Panel panKhuyenMai;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Panel panGiamGia;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Panel panCombo;
        private System.Windows.Forms.Label lblCombo;
        private System.Windows.Forms.ListView lvChuongTrinh;
        private System.Windows.Forms.Panel panelContentHeader;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colChiTiet;
    }
}