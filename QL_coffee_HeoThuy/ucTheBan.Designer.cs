namespace QL_coffee_HeoThuy
{
    partial class ucTheBan
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
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenBan
            // 
            this.lblTenBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenBan.Location = new System.Drawing.Point(0, 10);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(150, 30);
            this.lblTenBan.TabIndex = 0;
            this.lblTenBan.Text = "Bàn 1";
            this.lblTenBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThoiGian.Location = new System.Drawing.Point(0, 50);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(150, 30);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "Thời gian";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGia.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGia.Location = new System.Drawing.Point(0, 90);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(150, 30);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucTheBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblTenBan);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ucTheBan";
            this.Size = new System.Drawing.Size(150, 130); // Kích thước mới
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblGia;
    }
}