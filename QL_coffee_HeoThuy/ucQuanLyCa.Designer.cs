namespace QL_coffee_HeoThuy
{
    partial class ucQuanLyCa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            btnBack = new Button();
            splitContainerMain = new SplitContainer();
            btnXemDanhSach = new Button();
            btnDongCa = new Button();
            panelShiftInfo = new Panel();
            lnkChiTietCa = new LinkLabel();
            lblGioDongCa = new Label();
            label7 = new Label();
            lblGioMoCa = new Label();
            label5 = new Label();
            lblEmailNhanVien = new Label();
            lblTenNhanVien = new Label();
            label2 = new Label();
            lblMaCa = new Label();
            label3 = new Label();
            lblOpenShiftsTitle = new Label();
            tabControlMain = new TabControl();
            tabPageDonHang = new TabPage();
            dgvDonHang = new DataGridView();
            tabPageThuChi = new TabPage();
            tabPageThanhToanNo = new TabPage();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            panelShiftInfo.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnBack);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1262, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(558, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 31);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Quản lý ca";
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
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 60);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(btnXemDanhSach);
            splitContainerMain.Panel1.Controls.Add(btnDongCa);
            splitContainerMain.Panel1.Controls.Add(panelShiftInfo);
            splitContainerMain.Panel1.Controls.Add(lblOpenShiftsTitle);
            splitContainerMain.Panel1.Padding = new Padding(10);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(tabControlMain);
            splitContainerMain.Size = new Size(1262, 772);
            splitContainerMain.SplitterDistance = 420;
            splitContainerMain.TabIndex = 1;
            // 
            // btnXemDanhSach
            // 
            btnXemDanhSach.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXemDanhSach.Location = new Point(13, 477);
            btnXemDanhSach.Name = "btnXemDanhSach";
            btnXemDanhSach.Size = new Size(394, 48);
            btnXemDanhSach.TabIndex = 3;
            btnXemDanhSach.Text = "Xem danh sách ca";
            btnXemDanhSach.UseVisualStyleBackColor = true;
            // 
            // btnDongCa
            // 
            btnDongCa.BackColor = Color.SandyBrown;
            btnDongCa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDongCa.Location = new Point(13, 423);
            btnDongCa.Name = "btnDongCa";
            btnDongCa.Size = new Size(394, 48);
            btnDongCa.TabIndex = 2;
            btnDongCa.Text = "Đóng ca";
            btnDongCa.UseVisualStyleBackColor = false;
            // 
            // panelShiftInfo
            // 
            panelShiftInfo.BorderStyle = BorderStyle.FixedSingle;
            panelShiftInfo.Controls.Add(lnkChiTietCa);
            panelShiftInfo.Controls.Add(lblGioDongCa);
            panelShiftInfo.Controls.Add(label7);
            panelShiftInfo.Controls.Add(lblGioMoCa);
            panelShiftInfo.Controls.Add(label5);
            panelShiftInfo.Controls.Add(lblEmailNhanVien);
            panelShiftInfo.Controls.Add(lblTenNhanVien);
            panelShiftInfo.Controls.Add(label2);
            panelShiftInfo.Controls.Add(lblMaCa);
            panelShiftInfo.Controls.Add(label3);
            panelShiftInfo.Location = new Point(13, 50);
            panelShiftInfo.Name = "panelShiftInfo";
            panelShiftInfo.Size = new Size(394, 367);
            panelShiftInfo.TabIndex = 1;
            // 
            // lnkChiTietCa
            // 
            lnkChiTietCa.AutoSize = true;
            lnkChiTietCa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lnkChiTietCa.Location = new Point(280, 335);
            lnkChiTietCa.Name = "lnkChiTietCa";
            lnkChiTietCa.Size = new Size(109, 20);
            lnkChiTietCa.TabIndex = 9;
            lnkChiTietCa.TabStop = true;
            lnkChiTietCa.Text = "Chi tiết ca >>>";
            // 
            // lblGioDongCa
            // 
            lblGioDongCa.AutoSize = true;
            lblGioDongCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioDongCa.Location = new Point(14, 281);
            lblGioDongCa.Name = "lblGioDongCa";
            lblGioDongCa.Size = new Size(73, 20);
            lblGioDongCa.TabIndex = 8;
            lblGioDongCa.Text = "Đang mở";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 252);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 7;
            label7.Text = "Giờ đóng ca";
            // 
            // lblGioMoCa
            // 
            lblGioMoCa.AutoSize = true;
            lblGioMoCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioMoCa.Location = new Point(14, 218);
            lblGioMoCa.Name = "lblGioMoCa";
            lblGioMoCa.Size = new Size(169, 20);
            lblGioMoCa.TabIndex = 6;
            lblGioMoCa.Text = "16 thg 11, 2025, 17:34";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 189);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 5;
            label5.Text = "Giờ mở ca";
            // 
            // lblEmailNhanVien
            // 
            lblEmailNhanVien.AutoSize = true;
            lblEmailNhanVien.Location = new Point(14, 155);
            lblEmailNhanVien.Name = "lblEmailNhanVien";
            lblEmailNhanVien.Size = new Size(116, 20);
            lblEmailNhanVien.TabIndex = 4;
            lblEmailNhanVien.Text = "ca1@gmail.com";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNhanVien.Location = new Point(14, 126);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(142, 20);
            lblTenNhanVien.TabIndex = 3;
            lblTenNhanVien.Text = "kaavan.gamudacs5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhân viên";
            // 
            // lblMaCa
            // 
            lblMaCa.AutoSize = true;
            lblMaCa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaCa.Location = new Point(14, 48);
            lblMaCa.Name = "lblMaCa";
            lblMaCa.Size = new Size(199, 20);
            lblMaCa.TabIndex = 1;
            lblMaCa.Text = "18812266815A03TIHA8E8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã ca";
            // 
            // lblOpenShiftsTitle
            // 
            lblOpenShiftsTitle.AutoSize = true;
            lblOpenShiftsTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpenShiftsTitle.Location = new Point(13, 10);
            lblOpenShiftsTitle.Name = "lblOpenShiftsTitle";
            lblOpenShiftsTitle.Size = new Size(204, 25);
            lblOpenShiftsTitle.TabIndex = 0;
            lblOpenShiftsTitle.Text = "Danh sách ca đang mở";
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageDonHang);
            tabControlMain.Controls.Add(tabPageThuChi);
            tabControlMain.Controls.Add(tabPageThanhToanNo);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(838, 772);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageDonHang
            // 
            tabPageDonHang.Controls.Add(dgvDonHang);
            tabPageDonHang.Location = new Point(4, 32);
            tabPageDonHang.Name = "tabPageDonHang";
            tabPageDonHang.Padding = new Padding(3);
            tabPageDonHang.Size = new Size(830, 736);
            tabPageDonHang.TabIndex = 0;
            tabPageDonHang.Text = "Danh sách đơn hàng";
            tabPageDonHang.UseVisualStyleBackColor = true;
            // 
            // dgvDonHang
            // 
            dgvDonHang.AllowUserToAddRows = false;
            dgvDonHang.AllowUserToDeleteRows = false;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Dock = DockStyle.Fill;
            dgvDonHang.Location = new Point(3, 3);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.RowTemplate.Height = 29;
            dgvDonHang.Size = new Size(824, 730);
            dgvDonHang.TabIndex = 0;
            // 
            // tabPageThuChi
            // 
            tabPageThuChi.Location = new Point(4, 32);
            tabPageThuChi.Name = "tabPageThuChi";
            tabPageThuChi.Padding = new Padding(3);
            tabPageThuChi.Size = new Size(655, 504);
            tabPageThuChi.TabIndex = 1;
            tabPageThuChi.Text = "Quản lý thu, chi";
            tabPageThuChi.UseVisualStyleBackColor = true;
            // 
            // tabPageThanhToanNo
            // 
            tabPageThanhToanNo.Location = new Point(4, 32);
            tabPageThanhToanNo.Name = "tabPageThanhToanNo";
            tabPageThanhToanNo.Size = new Size(655, 504);
            tabPageThanhToanNo.TabIndex = 2;
            tabPageThanhToanNo.Text = "Phiếu thanh toán nợ";
            tabPageThanhToanNo.UseVisualStyleBackColor = true;
            // 
            // ucQuanLyCa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainerMain);
            Controls.Add(panelHeader);
            Name = "ucQuanLyCa";
            Size = new Size(1262, 832);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel1.PerformLayout();
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            panelShiftInfo.ResumeLayout(false);
            panelShiftInfo.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageDonHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label lblOpenShiftsTitle;
        private System.Windows.Forms.Panel panelShiftInfo;
        private System.Windows.Forms.Label lblMaCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmailNhanVien;
        private System.Windows.Forms.Label lblGioDongCa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGioMoCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkChiTietCa;
        private System.Windows.Forms.Button btnXemDanhSach;
        private System.Windows.Forms.Button btnDongCa;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDonHang;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.TabPage tabPageThuChi;
        private System.Windows.Forms.TabPage tabPageThanhToanNo;
    }
}