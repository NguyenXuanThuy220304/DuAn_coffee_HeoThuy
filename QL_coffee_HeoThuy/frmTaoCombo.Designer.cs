namespace QL_coffee_HeoThuy
{
    partial class frmTaoCombo
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTongGia = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMonAn = new System.Windows.Forms.ComboBox();
            this.dgvChiTietCombo = new System.Windows.Forms.DataGridView();
            this.colMenuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuCombo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTongGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Combo:";
            // 
            // txtTenCombo
            // 
            this.txtTenCombo.Location = new System.Drawing.Point(120, 27);
            this.txtTenCombo.Name = "txtTenCombo";
            this.txtTenCombo.Size = new System.Drawing.Size(350, 27);
            this.txtTenCombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Giá:";
            // 
            // numTongGia
            // 
            this.numTongGia.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTongGia.Location = new System.Drawing.Point(120, 71);
            this.numTongGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTongGia.Name = "numTongGia";
            this.numTongGia.Size = new System.Drawing.Size(350, 27);
            this.numTongGia.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMon);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMonAn);
            this.groupBox1.Location = new System.Drawing.Point(29, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm món vào Combo";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(340, 63);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(94, 29);
            this.btnThemMon.TabIndex = 3;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(340, 28);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(94, 27);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // cmbMonAn
            // 
            this.cmbMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonAn.FormattingEnabled = true;
            this.cmbMonAn.Location = new System.Drawing.Point(15, 27);
            this.cmbMonAn.Name = "cmbMonAn";
            this.cmbMonAn.Size = new System.Drawing.Size(240, 28);
            this.cmbMonAn.TabIndex = 0;
            // 
            // dgvChiTietCombo
            // 
            this.dgvChiTietCombo.AllowUserToAddRows = false;
            this.dgvChiTietCombo.AllowUserToDeleteRows = false;
            this.dgvChiTietCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMenuID,
            this.colTenMon,
            this.colSoLuong});
            this.dgvChiTietCombo.Location = new System.Drawing.Point(29, 230);
            this.dgvChiTietCombo.Name = "dgvChiTietCombo";
            this.dgvChiTietCombo.ReadOnly = true;
            this.dgvChiTietCombo.RowHeadersWidth = 51;
            this.dgvChiTietCombo.RowTemplate.Height = 29;
            this.dgvChiTietCombo.Size = new System.Drawing.Size(441, 200);
            this.dgvChiTietCombo.TabIndex = 5;
            // 
            // colMenuID
            // 
            this.colMenuID.HeaderText = "ID";
            this.colMenuID.MinimumWidth = 6;
            this.colMenuID.Name = "colMenuID";
            this.colMenuID.ReadOnly = true;
            this.colMenuID.Visible = false;
            this.colMenuID.Width = 125;
            // 
            // colTenMon
            // 
            this.colTenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenMon.HeaderText = "Tên món";
            this.colTenMon.MinimumWidth = 6;
            this.colTenMon.Name = "colTenMon";
            this.colTenMon.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 80;
            // 
            // btnLuuCombo
            // 
            this.btnLuuCombo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuCombo.Location = new System.Drawing.Point(29, 445);
            this.btnLuuCombo.Name = "btnLuuCombo";
            this.btnLuuCombo.Size = new System.Drawing.Size(441, 40);
            this.btnLuuCombo.TabIndex = 6;
            this.btnLuuCombo.Text = "Lưu Combo";
            this.btnLuuCombo.UseVisualStyleBackColor = true;
            this.btnLuuCombo.Click += new System.EventHandler(this.btnLuuCombo_Click);
            // 
            // frmTaoCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 513);
            this.Controls.Add(this.btnLuuCombo);
            this.Controls.Add(this.dgvChiTietCombo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numTongGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenCombo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTaoCombo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo Combo";
            this.Load += new System.EventHandler(this.frmTaoCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTongGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTongGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMonAn;
        private System.Windows.Forms.DataGridView dgvChiTietCombo;
        private System.Windows.Forms.Button btnLuuCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}