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
            this.panelTieuDeKhuVuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpKhuVuc
            // 
            this.flpKhuVuc.AutoScroll = true;
            // Sửa 1: Đổi màu nền cho giống ảnh mẫu
            this.flpKhuVuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(71)))));
            this.flpKhuVuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKhuVuc.Location = new System.Drawing.Point(0, 67);
            this.flpKhuVuc.Name = "flpKhuVuc";
            // Sửa 2: Thêm Padding cho các thẻ bàn cách xa lề
            this.flpKhuVuc.Padding = new System.Windows.Forms.Padding(20);
            this.flpKhuVuc.Size = new System.Drawing.Size(1262, 765);
            this.flpKhuVuc.TabIndex = 0;
            // 
            // panelTieuDeKhuVuc
            // 
            this.panelTieuDeKhuVuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.lblTieuDe.Location = new System.Drawing.Point(20, 16);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(350, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Khu vực (Trong nhà / Ngoài sân)";
            // 
            // ucKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpKhuVuc);
            this.Controls.Add(this.panelTieuDeKhuVuc);
            this.Name = "ucKhuVuc";
            this.Size = new System.Drawing.Size(1262, 832);
            this.panelTieuDeKhuVuc.ResumeLayout(false);
            this.panelTieuDeKhuVuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKhuVuc;
        private System.Windows.Forms.Panel panelTieuDeKhuVuc;
        private System.Windows.Forms.Label lblTieuDe;
    }
}