namespace QL_coffee_HeoThuy
{
    partial class ucKhuVuc
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
            this.flpKhuVuc = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTieuDeKhuVuc = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            // --- THÊM 2 CONTROL MỚI ---
            this.panelThongKe = new System.Windows.Forms.Panel();
            this.lblThongKeBan = new System.Windows.Forms.Label();
            this.panelTieuDeKhuVuc.SuspendLayout();
            this.panelThongKe.SuspendLayout(); // <-- Thêm
            this.SuspendLayout();
            // 
            // flpKhuVuc
            // 
            this.flpKhuVuc.AutoScroll = true;
            this.flpKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.flpKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            // --- SỬA VỊ TRÍ (Location) ---
            this.flpKhuVuc.Location = new System.Drawing.Point(0, 107); // (Cao 67 + 40 = 107)
            this.flpKhuVuc.Name = "flpKhuVuc";
            this.flpKhuVuc.Padding = new System.Windows.Forms.Padding(20);
            // --- SỬA KÍCH THƯỚC (Size) ---
            this.flpKhuVuc.Size = new System.Drawing.Size(1262, 725); // (Cao 832 - 107 = 725)
            this.flpKhuVuc.TabIndex = 0;
            // 
            // panelTieuDeKhuVuc
            // 
            // --- SỬA MÀU NỀN VÀ MÀU CHỮ ---
            this.panelTieuDeKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.panelTieuDeKhuVuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTieuDeKhuVuc.Controls.Add(this.lblTieuDe);
            this.panelTieuDeKhuVuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDeKhuVuc.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDeKhuVuc.Name = "panelTieuDeKhuVuc";
            this.panelTieuDeKhuVuc.Size = new System.Drawing.Size(1262, 67);
            this.panelTieuDeKhuVuc.TabIndex = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White; // <-- Thêm
            this.lblTieuDe.Location = new System.Drawing.Point(20, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(350, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Khu vực (Trong nhà / Ngoài sân)";
            // 
            // --- THÊM PANEL MỚI ---
            // 
            // panelThongKe
            // 
            this.panelThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.panelThongKe.Controls.Add(this.lblThongKeBan);
            this.panelThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongKe.Location = new System.Drawing.Point(0, 67);
            this.panelThongKe.Name = "panelThongKe";
            this.panelThongKe.Size = new System.Drawing.Size(1262, 40);
            this.panelThongKe.TabIndex = 2;
            // 
            // lblThongKeBan
            // 
            this.lblThongKeBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongKeBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThongKeBan.ForeColor = System.Drawing.Color.White;
            this.lblThongKeBan.Location = new System.Drawing.Point(0, 0);
            this.lblThongKeBan.Name = "lblThongKeBan";
            this.lblThongKeBan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.lblThongKeBan.Size = new System.Drawing.Size(1262, 40);
            this.lblThongKeBan.TabIndex = 0;
            this.lblThongKeBan.Text = "Đang tải thống kê...";
            this.lblThongKeBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpKhuVuc);
            // --- THÊM CONTROL MỚI VÀO (thứ tự quan trọng) ---
            this.Controls.Add(this.panelThongKe);
            this.Controls.Add(this.panelTieuDeKhuVuc);
            this.Name = "ucKhuVuc";
            this.Size = new System.Drawing.Size(1262, 832);
            this.panelTieuDeKhuVuc.ResumeLayout(false);
            this.panelTieuDeKhuVuc.PerformLayout();
            this.panelThongKe.ResumeLayout(false); // <-- Thêm
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKhuVuc;
        private System.Windows.Forms.Panel panelTieuDeKhuVuc;
        private System.Windows.Forms.Label lblTieuDe;
        // --- KHAI BÁO 2 BIẾN MỚI ---
        private System.Windows.Forms.Panel panelThongKe;
        private System.Windows.Forms.Label lblThongKeBan;
    }
}