namespace QL_coffee_HeoThuy
{
    partial class frmTaoKhuyenMai
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { /* ... */ }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chương trình:";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(157, 30);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(350, 27);
            this.txtTenCT.TabIndex = 1;
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(157, 75);
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(350, 27);
            this.txtChiTiet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chi tiết:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(157, 120);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(150, 27);
            this.dtpBatDau.TabIndex = 5;
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(157, 165);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(150, 27);
            this.dtpKetThuc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(157, 220);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(350, 40);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu chương trình";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmTaoKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 291);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpKetThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenCT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTaoKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo chương trình khuyến mãi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
    }
}