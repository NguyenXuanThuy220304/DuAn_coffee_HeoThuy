namespace QL_coffee_HeoThuy
{
    partial class Trang_chu
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
            components = new System.ComponentModel.Container();
            piclogo = new PictureBox();
            header = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label18 = new Label();
            label3 = new Label();
            label17 = new Label();
            label4 = new Label();
            panel = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            picSlider = new PictureBox();
            sliderTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            header.SuspendLayout();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSlider).BeginInit();
            SuspendLayout();
            // 
            // piclogo
            // 
            piclogo.BackgroundImageLayout = ImageLayout.Center;
            piclogo.BorderStyle = BorderStyle.Fixed3D;
            piclogo.Image = Properties.Resources.logo;
            piclogo.Location = new Point(11, 11);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(112, 104);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 2;
            piclogo.TabStop = false;
            // 
            // header
            // 
            header.AccessibleRole = AccessibleRole.Window;
            header.BackColor = Color.FromArgb(32, 42, 100);
            header.Controls.Add(button1);
            header.Controls.Add(label2);
            header.Controls.Add(label1);
            header.Location = new Point(2, 1);
            header.Name = "header";
            header.Size = new Size(1225, 72);
            header.TabIndex = 3;
            header.Paint += header_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1097, 18);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 1;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(130, 42);
            label2.Name = "label2";
            label2.Size = new Size(211, 22);
            label2.TabIndex = 0;
            label2.Text = "COFFEE ROASTERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 7);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 0;
            label1.Text = "KAAVAN";
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.Window;
            panel1.BackColor = Color.FromArgb(32, 42, 100);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(2, 616);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 72);
            panel1.TabIndex = 4;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(5, 26);
            label18.Name = "label18";
            label18.Size = new Size(163, 19);
            label18.TabIndex = 0;
            label18.Text = "Phone: 085 33 50 333";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(8, 49);
            label3.Name = "label3";
            label3.Size = new Size(242, 19);
            label3.TabIndex = 0;
            label3.Text = "Email: Kaavan.coffee@gmail.com";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(904, 46);
            label17.Name = "label17";
            label17.Size = new Size(316, 19);
            label17.TabIndex = 0;
            label17.Text = "Đ/C: Số 18, đường 2.2, khu đô thị GAMUDA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1072, 4);
            label4.Name = "label4";
            label4.Size = new Size(150, 35);
            label4.TabIndex = 0;
            label4.Text = "KAAVAN";
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(224, 224, 224);
            panel.Controls.Add(label11);
            panel.Controls.Add(label12);
            panel.Controls.Add(label13);
            panel.Controls.Add(label14);
            panel.Controls.Add(label15);
            panel.Controls.Add(label16);
            panel.Controls.Add(label10);
            panel.Controls.Add(label9);
            panel.Controls.Add(label8);
            panel.Controls.Add(label7);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(picSlider);
            panel.Location = new Point(2, 79);
            panel.Name = "panel";
            panel.Size = new Size(1225, 531);
            panel.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(224, 224, 224);
            label11.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(32, 42, 100);
            label11.Location = new Point(1120, 429);
            label11.Name = "label11";
            label11.Size = new Size(91, 90);
            label11.TabIndex = 2;
            label11.Text = "E";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(224, 224, 224);
            label12.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(32, 42, 100);
            label12.Location = new Point(1120, 348);
            label12.Name = "label12";
            label12.Size = new Size(91, 90);
            label12.TabIndex = 3;
            label12.Text = "E";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(224, 224, 224);
            label13.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(32, 42, 100);
            label13.Location = new Point(1120, 267);
            label13.Name = "label13";
            label13.Size = new Size(86, 90);
            label13.TabIndex = 4;
            label13.Text = "F";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(224, 224, 224);
            label14.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(32, 42, 100);
            label14.Location = new Point(1120, 186);
            label14.Name = "label14";
            label14.Size = new Size(86, 90);
            label14.TabIndex = 5;
            label14.Text = "F";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(224, 224, 224);
            label15.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(32, 42, 100);
            label15.Location = new Point(1120, 105);
            label15.Name = "label15";
            label15.Size = new Size(100, 90);
            label15.TabIndex = 6;
            label15.Text = "O";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(224, 224, 224);
            label16.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(32, 42, 100);
            label16.Location = new Point(1120, 24);
            label16.Name = "label16";
            label16.Size = new Size(96, 90);
            label16.TabIndex = 7;
            label16.Text = "C";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(224, 224, 224);
            label10.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(32, 42, 100);
            label10.Location = new Point(16, 438);
            label10.Name = "label10";
            label10.Size = new Size(96, 90);
            label10.TabIndex = 1;
            label10.Text = "N";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(224, 224, 224);
            label9.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(32, 42, 100);
            label9.Location = new Point(16, 357);
            label9.Name = "label9";
            label9.Size = new Size(96, 90);
            label9.TabIndex = 1;
            label9.Text = "A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(224, 224, 224);
            label8.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(32, 42, 100);
            label8.Location = new Point(16, 276);
            label8.Name = "label8";
            label8.Size = new Size(96, 90);
            label8.TabIndex = 1;
            label8.Text = "V";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(32, 42, 100);
            label7.Location = new Point(16, 195);
            label7.Name = "label7";
            label7.Size = new Size(96, 90);
            label7.TabIndex = 1;
            label7.Text = "A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(32, 42, 100);
            label6.Location = new Point(16, 114);
            label6.Name = "label6";
            label6.Size = new Size(96, 90);
            label6.TabIndex = 1;
            label6.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(224, 224, 224);
            label5.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(32, 42, 100);
            label5.Location = new Point(16, 33);
            label5.Name = "label5";
            label5.Size = new Size(100, 90);
            label5.TabIndex = 1;
            label5.Text = "K";
            // 
            // picSlider
            // 
            picSlider.BackColor = Color.White;
            picSlider.BorderStyle = BorderStyle.FixedSingle;
            picSlider.Location = new Point(266, 0);
            picSlider.Name = "picSlider";
            picSlider.Size = new Size(711, 531);
            picSlider.TabIndex = 0;
            picSlider.TabStop = false;
            picSlider.Click += picSlider_Click;
            // 
            // sliderTimer
            // 
            sliderTimer.Enabled = true;
            sliderTimer.Interval = 3000;
            sliderTimer.Tick += sliderTimer_Tick_1;
            // 
            // Trang_chu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 690);
            Controls.Add(piclogo);
            Controls.Add(header);
            Controls.Add(panel1);
            Controls.Add(panel);
            Name = "Trang_chu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang_chu";
            Load += Trang_chu_Load;
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSlider).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox piclogo;
        private Panel header;
        private Button button1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Panel panel;
        private PictureBox picSlider;
        private System.Windows.Forms.Timer sliderTimer;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label3;
    }
}