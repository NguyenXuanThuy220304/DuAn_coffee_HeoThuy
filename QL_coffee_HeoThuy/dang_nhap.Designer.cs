namespace QL_coffee_HeoThuy
{
    partial class dang_nhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelLogin = new Panel();
            button1 = new Button();
            txtmk = new TextBox();
            txttk = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(152, 24);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(262, 45);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 137);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(112, 25);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 205);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(111, 25);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Tan;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(txtmk);
            panelLogin.Controls.Add(txttk);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.ImeMode = ImeMode.NoControl;
            panelLogin.Location = new Point(123, 98);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(558, 348);
            panelLogin.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(207, 296);
            button1.Name = "button1";
            button1.Size = new Size(154, 35);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(162, 206);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(346, 27);
            txtmk.TabIndex = 1;
            // 
            // txttk
            // 
            txttk.Location = new Point(162, 138);
            txttk.Name = "txttk";
            txttk.Size = new Size(346, 27);
            txttk.TabIndex = 1;
            // 
            // dang_nhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(783, 554);
            Controls.Add(panelLogin);
            Name = "dang_nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dang_nhap";
            Load += dang_nhap_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelLogin;
        private TextBox txttk;
        private TextBox txtmk;
        private Button button1;
    }
}