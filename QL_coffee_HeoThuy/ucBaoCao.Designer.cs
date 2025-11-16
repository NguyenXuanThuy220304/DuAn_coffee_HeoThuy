namespace QL_coffee_HeoThuy
{
    partial class ucBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.FlowLayoutPanel flpKPIs;
        private System.Windows.Forms.GroupBox gbTongDoanhThu;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.GroupBox gbTongHoaDon;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.GroupBox gbTrungBinhBill;
        private System.Windows.Forms.Label lblTrungBinhBill;
        private System.Windows.Forms.DataGridView dgvMatHangChay;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flpKPIs = new System.Windows.Forms.FlowLayoutPanel();
            this.gbTongDoanhThu = new System.Windows.Forms.GroupBox();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.gbTongHoaDon = new System.Windows.Forms.GroupBox();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.gbTrungBinhBill = new System.Windows.Forms.GroupBox();
            this.lblTrungBinhBill = new System.Windows.Forms.Label();
            this.dgvMatHangChay = new System.Windows.Forms.DataGridView();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.flpKPIs.SuspendLayout();
            this.gbTongDoanhThu.SuspendLayout();
            this.gbTongHoaDon.SuspendLayout();
            this.gbTrungBinhBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
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
            this.panelHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(70, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Báo cáo Doanh thu";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 60);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.panelFilter.Controls.Add(this.btnLoc);
            this.panelFilter.Controls.Add(this.dtpKetThuc);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.dtpBatDau);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.ForeColor = System.Drawing.Color.White;
            this.panelFilter.Location = new System.Drawing.Point(0, 60);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1262, 55);
            this.panelFilter.TabIndex = 5;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(623, 10);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(121, 35);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKetThuc.Location = new System.Drawing.Point(401, 15);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(199, 27);
            this.dtpKetThuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến ngày:";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(92, 15);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(212, 27);
            this.dtpBatDau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.tlpDashboard.ColumnCount = 2;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDashboard.Controls.Add(this.chartDoanhThu, 0, 0);
            this.tlpDashboard.Controls.Add(this.flpKPIs, 1, 0);
            this.tlpDashboard.Controls.Add(this.dgvMatHangChay, 0, 2);
            this.tlpDashboard.Controls.Add(this.dgvKhuyenMai, 1, 2);
            this.tlpDashboard.Controls.Add(this.label3, 0, 1);
            this.tlpDashboard.Controls.Add(this.label4, 1, 1);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 115);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 3;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboard.Size = new System.Drawing.Size(1262, 717);
            this.tlpDashboard.TabIndex = 6;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(877, 337);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // flpKPIs
            // 
            this.flpKPIs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.flpKPIs.Controls.Add(this.gbTongDoanhThu);
            this.flpKPIs.Controls.Add(this.gbTongHoaDon);
            this.flpKPIs.Controls.Add(this.gbTrungBinhBill);
            this.flpKPIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKPIs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpKPIs.Location = new System.Drawing.Point(886, 3);
            this.flpKPIs.Name = "flpKPIs";
            this.flpKPIs.Size = new System.Drawing.Size(373, 337);
            this.flpKPIs.TabIndex = 1;
            // 
            // gbTongDoanhThu
            // 
            this.gbTongDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.gbTongDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.gbTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTongDoanhThu.ForeColor = System.Drawing.Color.White;
            this.gbTongDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.gbTongDoanhThu.Name = "gbTongDoanhThu";
            this.gbTongDoanhThu.Size = new System.Drawing.Size(367, 100);
            this.gbTongDoanhThu.TabIndex = 0;
            this.gbTongDoanhThu.TabStop = false;
            this.gbTongDoanhThu.Text = "TỔNG DOANH THU";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Green;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(3, 23);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(361, 74);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "0 đ";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTongHoaDon
            // 
            this.gbTongHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.gbTongHoaDon.Controls.Add(this.lblTongHoaDon);
            this.gbTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTongHoaDon.ForeColor = System.Drawing.Color.White;
            this.gbTongHoaDon.Location = new System.Drawing.Point(3, 109);
            this.gbTongHoaDon.Name = "gbTongHoaDon";
            this.gbTongHoaDon.Size = new System.Drawing.Size(367, 100);
            this.gbTongHoaDon.TabIndex = 1;
            this.gbTongHoaDon.TabStop = false;
            this.gbTongHoaDon.Text = "TỔNG SỐ HÓA ĐƠN";
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongHoaDon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTongHoaDon.Location = new System.Drawing.Point(3, 23);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(361, 74);
            this.lblTongHoaDon.TabIndex = 0;
            this.lblTongHoaDon.Text = "0";
            this.lblTongHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTrungBinhBill
            // 
            this.gbTrungBinhBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            this.gbTrungBinhBill.Controls.Add(this.lblTrungBinhBill);
            this.gbTrungBinhBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTrungBinhBill.ForeColor = System.Drawing.Color.White;
            this.gbTrungBinhBill.Location = new System.Drawing.Point(3, 215);
            this.gbTrungBinhBill.Name = "gbTrungBinhBill";
            this.gbTrungBinhBill.Size = new System.Drawing.Size(367, 100);
            this.gbTrungBinhBill.TabIndex = 2;
            this.gbTrungBinhBill.TabStop = false;
            this.gbTrungBinhBill.Text = "TRUNG BÌNH / HÓA ĐƠN";
            // 
            // lblTrungBinhBill
            // 
            this.lblTrungBinhBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrungBinhBill.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrungBinhBill.Location = new System.Drawing.Point(3, 23);
            this.lblTrungBinhBill.Name = "lblTrungBinhBill";
            this.lblTrungBinhBill.Size = new System.Drawing.Size(361, 74);
            this.lblTrungBinhBill.TabIndex = 0;
            this.lblTrungBinhBill.Text = "0 đ";
            this.lblTrungBinhBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMatHangChay
            // 
            this.dgvMatHangChay.AllowUserToAddRows = false;
            this.dgvMatHangChay.AllowUserToDeleteRows = false;
            this.dgvMatHangChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatHangChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHangChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHangChay.Location = new System.Drawing.Point(3, 376);
            this.dgvMatHangChay.Name = "dgvMatHangChay";
            this.dgvMatHangChay.ReadOnly = true;
            this.dgvMatHangChay.RowHeadersWidth = 51;
            this.dgvMatHangChay.RowTemplate.Height = 29;
            this.dgvMatHangChay.Size = new System.Drawing.Size(877, 338);
            this.dgvMatHangChay.TabIndex = 2;
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            this.dgvKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(886, 376);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 29;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(373, 338);
            this.dgvKhuyenMai.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOP MẶT HÀNG BÁN CHẠY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(888, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "KHUYẾN MÃI SỬ DỤNG";
            // 
            // ucBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.tlpDashboard);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.Name = "ucBaoCao";
            this.Size = new System.Drawing.Size(1262, 832);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
            this.tlpDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.flpKPIs.ResumeLayout(false);
            this.gbTongDoanhThu.ResumeLayout(false);
            this.gbTongHoaDon.ResumeLayout(false);
            this.gbTrungBinhBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}