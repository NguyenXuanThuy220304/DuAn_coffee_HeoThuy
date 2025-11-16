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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.splitGiaoDien = new System.Windows.Forms.SplitContainer();
            this.panNav = new System.Windows.Forms.Panel();
            this.panPhiDichVu = new System.Windows.Forms.Panel();
            this.lblPhiDichVu = new System.Windows.Forms.Label();
            this.panGiamGiaHV = new System.Windows.Forms.Panel();
            this.lblGiamGiaHV = new System.Windows.Forms.Label();
            this.panGiamGia = new System.Windows.Forms.Panel();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.panCombo = new System.Windows.Forms.Panel();
            this.lblCombo = new System.Windows.Forms.Label();
            this.panKhuyenMai = new System.Windows.Forms.Panel();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.lvChuongTrinh = new System.Windows.Forms.ListView();
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChiTiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelContentHeader = new System.Windows.Forms.Panel();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGiaoDien)).BeginInit();
            this.splitGiaoDien.Panel1.SuspendLayout();
            this.splitGiaoDien.Panel2.SuspendLayout();
            this.splitGiaoDien.SuspendLayout();
            this.panNav.SuspendLayout();
            this.panPhiDichVu.SuspendLayout();
            this.panGiamGiaHV.SuspendLayout();
            this.panGiamGia.SuspendLayout();
            this.panCombo.SuspendLayout();
            this.panKhuyenMai.SuspendLayout();
            this.panelContentHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(70, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chương trình bán hàng";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 60);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // splitGiaoDien
            // 
            this.splitGiaoDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGiaoDien.Location = new System.Drawing.Point(0, 60);
            this.splitGiaoDien.Name = "splitGiaoDien";
            // 
            // splitGiaoDien.Panel1
            // 
            this.splitGiaoDien.Panel1.Controls.Add(this.panNav);
            this.splitGiaoDien.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitGiaoDien.Panel2
            // 
            this.splitGiaoDien.Panel2.Controls.Add(this.lvChuongTrinh);
            this.splitGiaoDien.Panel2.Controls.Add(this.panelContentHeader);
            this.splitGiaoDien.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitGiaoDien.Size = new System.Drawing.Size(1262, 772);
            this.splitGiaoDien.SplitterDistance = 300;
            this.splitGiaoDien.TabIndex = 3;
            // 
            // panNav
            // 
            this.panNav.BackColor = System.Drawing.SystemColors.Control;
            this.panNav.Controls.Add(this.panPhiDichVu);
            this.panNav.Controls.Add(this.panGiamGiaHV);
            this.panNav.Controls.Add(this.panGiamGia);
            this.panNav.Controls.Add(this.panCombo);
            this.panNav.Controls.Add(this.panKhuyenMai);
            this.panNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panNav.Location = new System.Drawing.Point(5, 5);
            this.panNav.Name = "panNav";
            this.panNav.Size = new System.Drawing.Size(290, 762);
            this.panNav.TabIndex = 0;
            // 
            // panPhiDichVu
            // 
            this.panPhiDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPhiDichVu.Controls.Add(this.lblPhiDichVu);
            this.panPhiDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPhiDichVu.Location = new System.Drawing.Point(0, 240);
            this.panPhiDichVu.Name = "panPhiDichVu";
            this.panPhiDichVu.Size = new System.Drawing.Size(290, 60);
            this.panPhiDichVu.TabIndex = 4;
            // 
            // lblPhiDichVu
            // 
            this.lblPhiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhiDichVu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhiDichVu.Location = new System.Drawing.Point(0, 0);
            this.lblPhiDichVu.Name = "lblPhiDichVu";
            this.lblPhiDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblPhiDichVu.Size = new System.Drawing.Size(288, 58);
            this.lblPhiDichVu.TabIndex = 0;
            this.lblPhiDichVu.Text = "Phí dịch vụ";
            this.lblPhiDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panGiamGiaHV
            // 
            this.panGiamGiaHV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panGiamGiaHV.Controls.Add(this.lblGiamGiaHV);
            this.panGiamGiaHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGiamGiaHV.Location = new System.Drawing.Point(0, 180);
            this.panGiamGiaHV.Name = "panGiamGiaHV";
            this.panGiamGiaHV.Size = new System.Drawing.Size(290, 60);
            this.panGiamGiaHV.TabIndex = 3;
            // 
            // lblGiamGiaHV
            // 
            this.lblGiamGiaHV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGiamGiaHV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGiamGiaHV.Location = new System.Drawing.Point(0, 0);
            this.lblGiamGiaHV.Name = "lblGiamGiaHV";
            this.lblGiamGiaHV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGiamGiaHV.Size = new System.Drawing.Size(288, 58);
            this.lblGiamGiaHV.TabIndex = 0;
            this.lblGiamGiaHV.Text = "Giảm giá hội viên";
            this.lblGiamGiaHV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panGiamGia
            // 
            this.panGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panGiamGia.Controls.Add(this.lblGiamGia);
            this.panGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGiamGia.Location = new System.Drawing.Point(0, 120);
            this.panGiamGia.Name = "panGiamGia";
            this.panGiamGia.Size = new System.Drawing.Size(290, 60);
            this.panGiamGia.TabIndex = 2;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGiamGia.Location = new System.Drawing.Point(0, 0);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblGiamGia.Size = new System.Drawing.Size(288, 58);
            this.lblGiamGia.TabIndex = 0;
            this.lblGiamGia.Text = "Giảm giá";
            this.lblGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panCombo
            // 
            this.panCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panCombo.Controls.Add(this.lblCombo);
            this.panCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panCombo.Location = new System.Drawing.Point(0, 60);
            this.panCombo.Name = "panCombo";
            this.panCombo.Size = new System.Drawing.Size(290, 60);
            this.panCombo.TabIndex = 1;
            // 
            // lblCombo
            // 
            this.lblCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCombo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCombo.Location = new System.Drawing.Point(0, 0);
            this.lblCombo.Name = "lblCombo";
            this.lblCombo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCombo.Size = new System.Drawing.Size(288, 58);
            this.lblCombo.TabIndex = 0;
            this.lblCombo.Text = "Combo";
            this.lblCombo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panKhuyenMai
            // 
            this.panKhuyenMai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panKhuyenMai.Controls.Add(this.lblKhuyenMai);
            this.panKhuyenMai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panKhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.panKhuyenMai.Name = "panKhuyenMai";
            this.panKhuyenMai.Size = new System.Drawing.Size(290, 60);
            this.panKhuyenMai.TabIndex = 0;
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblKhuyenMai.Size = new System.Drawing.Size(288, 58);
            this.lblKhuyenMai.TabIndex = 0;
            this.lblKhuyenMai.Text = "Chương trình khuyến mãi";
            this.lblKhuyenMai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvChuongTrinh
            // 
            this.lvChuongTrinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTen,
            this.colChiTiet});
            this.lvChuongTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvChuongTrinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvChuongTrinh.FullRowSelect = true;
            this.lvChuongTrinh.GridLines = true;
            this.lvChuongTrinh.Location = new System.Drawing.Point(5, 70);
            this.lvChuongTrinh.Name = "lvChuongTrinh";
            this.lvChuongTrinh.Size = new System.Drawing.Size(948, 697);
            this.lvChuongTrinh.TabIndex = 1;
            this.lvChuongTrinh.UseCompatibleStateImageBehavior = false;
            this.lvChuongTrinh.View = System.Windows.Forms.View.Details;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên chương trình";
            this.colTen.Width = 400;
            // 
            // colChiTiet
            // 
            this.colChiTiet.Text = "Chi tiết";
            this.colChiTiet.Width = 300;
            // 
            // panelContentHeader
            // 
            this.panelContentHeader.Controls.Add(this.btnTaoMoi);
            this.panelContentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContentHeader.Location = new System.Drawing.Point(5, 5);
            this.panelContentHeader.Name = "panelContentHeader";
            this.panelContentHeader.Size = new System.Drawing.Size(948, 65);
            this.panelContentHeader.TabIndex = 0;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTaoMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Location = new System.Drawing.Point(3, 10);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(200, 45);
            this.btnTaoMoi.TabIndex = 0;
            this.btnTaoMoi.Text = "Tạo CT khuyến mãi";
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            // 
            // ucChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitGiaoDien);
            this.Controls.Add(this.panelHeader);
            this.Name = "ucChuongTrinh";
            this.Size = new System.Drawing.Size(1262, 832);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitGiaoDien.Panel1.ResumeLayout(false);
            this.splitGiaoDien.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGiaoDien)).EndInit();
            this.splitGiaoDien.ResumeLayout(false);
            this.panNav.ResumeLayout(false);
            this.panPhiDichVu.ResumeLayout(false);
            this.panGiamGiaHV.ResumeLayout(false);
            this.panGiamGia.ResumeLayout(false);
            this.panCombo.ResumeLayout(false);
            this.panKhuyenMai.ResumeLayout(false);
            this.panelContentHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SplitContainer splitGiaoDien;
        private System.Windows.Forms.Panel panNav;
        private System.Windows.Forms.Panel panKhuyenMai;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Panel panPhiDichVu;
        private System.Windows.Forms.Label lblPhiDichVu;
        private System.Windows.Forms.Panel panGiamGiaHV;
        private System.Windows.Forms.Label lblGiamGiaHV;
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