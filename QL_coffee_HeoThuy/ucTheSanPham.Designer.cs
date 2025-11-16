// Xóa toàn bộ code cũ trong file Designer.cs và thay bằng code này
namespace QL_coffee_HeoThuy
{
    partial class ucTheSanPham
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
            picAnh = new PictureBox();
            lblTen = new Label();
            lblGia = new Label();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // picAnh
            // 
            picAnh.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            picAnh.BorderStyle = BorderStyle.FixedSingle;
            picAnh.Location = new Point(14, 16);
            picAnh.Margin = new Padding(3, 4, 3, 4);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(261, 230);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 0;
            picAnh.TabStop = false;
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTen.ForeColor = Color.White;
            lblTen.Location = new Point(-1, 263);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(294, 29);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên Sản Phẩm";
            lblTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGia
            // 
            lblGia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGia.ForeColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            lblGia.Location = new Point(85, 318);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(120, 29);
            lblGia.TabIndex = 2;
            lblGia.Text = "25.000 đ";
            lblGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucTheSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(62)))), ((int)(((byte)(81)))));
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblGia);
            Controls.Add(lblTen);
            Controls.Add(picAnh);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucTheSanPham";
            Size = new Size(292, 362);
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);

        }

        #endregion

        // Các biến cho control (PHẦN NÀY QUAN TRỌNG)
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
    }
}