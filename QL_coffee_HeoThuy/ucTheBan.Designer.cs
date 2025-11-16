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
            lblTenBan = new Label();
            lblThoiGian = new Label();
            lblGia = new Label();
            SuspendLayout();
            // 
            // lblTenBan
            // 
            lblTenBan.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenBan.Location = new Point(0, 14);
            lblTenBan.Name = "lblTenBan";
            lblTenBan.Size = new Size(179, 33);
            lblTenBan.TabIndex = 0;
            lblTenBan.Text = "Tên bàn";
            lblTenBan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThoiGian
            // 
            lblThoiGian.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblThoiGian.Location = new Point(0, 86);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(179, 38);
            lblThoiGian.TabIndex = 0;
            lblThoiGian.Text = "Thời gian";
            lblThoiGian.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGia
            // 
            lblGia.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGia.Location = new Point(0, 149);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(179, 38);
            lblGia.TabIndex = 0;
            lblGia.Text = "Giá";
            lblGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ucTheBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGia);
            Controls.Add(lblThoiGian);
            Controls.Add(lblTenBan);
            Name = "ucTheBan";
            Size = new Size(179, 228);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTenBan;
        private Label lblThoiGian;
        private Label lblGia;
    }
}
