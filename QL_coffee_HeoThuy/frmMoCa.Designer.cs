namespace QL_coffee_HeoThuy
{
    partial class frmMoCa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoCaSang = new System.Windows.Forms.Button();
            this.btnMoCaChieu = new System.Windows.Forms.Button();
            this.btnMoCaToi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoCaSang
            // 
            this.btnMoCaSang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoCaSang.Location = new System.Drawing.Point(50, 50); // Tọa độ mẫu
            this.btnMoCaSang.Name = "btnMoCaSang";
            this.btnMoCaSang.Size = new System.Drawing.Size(200, 80); // Kích thước mẫu
            this.btnMoCaSang.TabIndex = 0;
            this.btnMoCaSang.Text = "Mở Ca Sáng (1)";
            this.btnMoCaSang.UseVisualStyleBackColor = true;
            this.btnMoCaSang.Click += new System.EventHandler(this.btnMoCaSang_Click);
            // 
            // btnMoCaChieu
            // 
            this.btnMoCaChieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoCaChieu.Location = new System.Drawing.Point(50, 150); // Tọa độ mẫu
            this.btnMoCaChieu.Name = "btnMoCaChieu";
            this.btnMoCaChieu.Size = new System.Drawing.Size(200, 80); // Kích thước mẫu
            this.btnMoCaChieu.TabIndex = 1;
            this.btnMoCaChieu.Text = "Mở Ca Chiều (2)";
            this.btnMoCaChieu.UseVisualStyleBackColor = true;
            this.btnMoCaChieu.Click += new System.EventHandler(this.btnMoCaChieu_Click);
            // 
            // btnMoCaToi
            // 
            this.btnMoCaToi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnMoCaToi.Location = new System.Drawing.Point(50, 250); // Tọa độ mẫu
            this.btnMoCaToi.Name = "btnMoCaToi";
            this.btnMoCaToi.Size = new System.Drawing.Size(200, 80); // Kích thước mẫu
            this.btnMoCaToi.TabIndex = 2;
            this.btnMoCaToi.Text = "Mở Ca Tối (3)";
            this.btnMoCaToi.UseVisualStyleBackColor = true;
            this.btnMoCaToi.Click += new System.EventHandler(this.btnMoCaToi_Click);
            // 
            // frmMoCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 380); // Kích thước Form mẫu
            this.Controls.Add(this.btnMoCaToi);
            this.Controls.Add(this.btnMoCaChieu);
            this.Controls.Add(this.btnMoCaSang);
            this.Name = "frmMoCa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mở Ca Làm Việc";
            this.ResumeLayout(false);

        }

        #endregion

        // Các biến được tự động thêm vào
        private System.Windows.Forms.Button btnMoCaSang;
        private System.Windows.Forms.Button btnMoCaChieu;
        private System.Windows.Forms.Button btnMoCaToi;
    }
}