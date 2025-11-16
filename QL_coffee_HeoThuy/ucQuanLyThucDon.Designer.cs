namespace QL_coffee_HeoThuy
{
    partial class ucQuanLyThucDon
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
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picAnhSP = new System.Windows.Forms.PictureBox();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGiaoDien)).BeginInit();
            this.splitGiaoDien.Panel1.SuspendLayout();
            this.splitGiaoDien.Panel2.SuspendLayout();
            this.splitGiaoDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 60);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(211, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản lý Thực đơn";
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
            this.splitGiaoDien.Panel1.Controls.Add(this.dgvThucDon);
            this.splitGiaoDien.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitGiaoDien.Panel2
            // 
            this.splitGiaoDien.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.splitGiaoDien.Panel2.Controls.Add(this.gbChiTiet);
            this.splitGiaoDien.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitGiaoDien.Size = new System.Drawing.Size(1262, 772);
            this.splitGiaoDien.SplitterDistance = 750;
            this.splitGiaoDien.TabIndex = 4;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AllowUserToDeleteRows = false;
            this.dgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucDon.Location = new System.Drawing.Point(5, 5);
            this.dgvThucDon.MultiSelect = false;
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersWidth = 51;
            this.dgvThucDon.RowTemplate.Height = 29;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(740, 762);
            this.dgvThucDon.TabIndex = 0;
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.gbChiTiet.Controls.Add(this.btnLamMoi);
            this.gbChiTiet.Controls.Add(this.btnXoa);
            this.gbChiTiet.Controls.Add(this.btnSua);
            this.gbChiTiet.Controls.Add(this.btnThem);
            this.gbChiTiet.Controls.Add(this.btnChonAnh);
            this.gbChiTiet.Controls.Add(this.txtDuongDanAnh);
            this.gbChiTiet.Controls.Add(this.label6);
            this.gbChiTiet.Controls.Add(this.picAnhSP);
            this.gbChiTiet.Controls.Add(this.numDonGia);
            this.gbChiTiet.Controls.Add(this.label5);
            this.gbChiTiet.Controls.Add(this.txtKichThuoc);
            this.gbChiTiet.Controls.Add(this.label4);
            this.gbChiTiet.Controls.Add(this.cmbDanhMuc);
            this.gbChiTiet.Controls.Add(this.label3);
            this.gbChiTiet.Controls.Add(this.txtTenSP);
            this.gbChiTiet.Controls.Add(this.label1);
            this.gbChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbChiTiet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbChiTiet.ForeColor = System.Drawing.Color.White;
            this.gbChiTiet.Location = new System.Drawing.Point(5, 5);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(498, 762);
            this.gbChiTiet.TabIndex = 0;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Chi tiết món";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.Location = new System.Drawing.Point(20, 600);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(372, 600);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(255, 600);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGreen;
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(138, 600);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonAnh.Location = new System.Drawing.Point(372, 532);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 30);
            this.btnChonAnh.TabIndex = 11;
            this.btnChonAnh.Text = "Chọn...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Location = new System.Drawing.Point(145, 533);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(221, 30);
            this.txtDuongDanAnh.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên file ảnh:";
            // 
            // picAnhSP
            // 
            this.picAnhSP.BackColor = System.Drawing.Color.DarkGray;
            this.picAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhSP.Location = new System.Drawing.Point(145, 360);
            this.picAnhSP.Name = "picAnhSP";
            this.picAnhSP.Size = new System.Drawing.Size(160, 160);
            this.picAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhSP.TabIndex = 8;
            this.picAnhSP.TabStop = false;
            // 
            // numDonGia
            // 
            this.numDonGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDonGia.Location = new System.Drawing.Point(20, 290);
            this.numDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(452, 30);
            this.numDonGia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn giá:";
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(20, 210);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(452, 30);
            this.txtKichThuoc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kích thước (VD: M, L...):";
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(20, 130);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(452, 31);
            this.cmbDanhMuc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(20, 50);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(452, 30);
            this.txtTenSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm (Gốc):";
            // 
            // ucQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.splitGiaoDien);
            this.Controls.Add(this.panelHeader);
            this.Name = "ucQuanLyThucDon";
            this.Size = new System.Drawing.Size(1262, 832);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.splitGiaoDien.Panel1.ResumeLayout(false);
            this.splitGiaoDien.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGiaoDien)).EndInit();
            this.splitGiaoDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.gbChiTiet.ResumeLayout(false);
            this.gbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SplitContainer splitGiaoDien;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKichThuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.PictureBox picAnhSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}   