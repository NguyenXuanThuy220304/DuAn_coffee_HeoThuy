namespace QL_coffee_HeoThuy
{
    partial class Kaavan
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
            panel1 = new Panel();
            panbtnql = new Panel();
            label3 = new Label();
            panbtnkhuvuc = new Panel();
            label2 = new Label();
            panbtnbanhang = new Panel();
            label1 = new Label();
            panuc = new Panel();
            panel1.SuspendLayout();
            panbtnql.SuspendLayout();
            panbtnkhuvuc.SuspendLayout();
            panbtnbanhang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panbtnql);
            panel1.Controls.Add(panbtnkhuvuc);
            panel1.Controls.Add(panbtnbanhang);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 833);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 80);
            panel1.TabIndex = 0;
            // 
            // panbtnql
            // 
            panbtnql.BackColor = SystemColors.Control;
            panbtnql.Controls.Add(label3);
            panbtnql.Location = new Point(852, 5);
            panbtnql.Name = "panbtnql";
            panbtnql.Size = new Size(407, 71);
            panbtnql.TabIndex = 0;
            panbtnql.Click += panbtnql_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(141, 20);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 0;
            label3.Text = "Thuộc tính";
            label3.Click += panbtnql_Click;
            // 
            // panbtnkhuvuc
            // 
            panbtnkhuvuc.BackColor = SystemColors.Control;
            panbtnkhuvuc.Controls.Add(label2);
            panbtnkhuvuc.Location = new Point(413, 5);
            panbtnkhuvuc.Name = "panbtnkhuvuc";
            panbtnkhuvuc.Size = new Size(433, 71);
            panbtnkhuvuc.TabIndex = 0;
            panbtnkhuvuc.Click += panbtnkhuvuc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(154, 20);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 0;
            label2.Text = "Khu Vực";
            // 
            // panbtnbanhang
            // 
            panbtnbanhang.BackColor = SystemColors.Control;
            panbtnbanhang.Controls.Add(label1);
            panbtnbanhang.Location = new Point(3, 5);
            panbtnbanhang.Name = "panbtnbanhang";
            panbtnbanhang.Size = new Size(404, 71);
            panbtnbanhang.TabIndex = 0;
            panbtnbanhang.Click += panbtnbanhang_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "Bán hàng";
            // 
            // panuc
            // 
            panuc.Dock = DockStyle.Fill;
            panuc.Location = new Point(0, 0);
            panuc.Name = "panuc";
            panuc.Size = new Size(1262, 833);
            panuc.TabIndex = 1;
            // 
            // Kaavan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 913);
            Controls.Add(panuc);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Kaavan";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Kaavan_Load;
            panel1.ResumeLayout(false);
            panbtnql.ResumeLayout(false);
            panbtnql.PerformLayout();
            panbtnkhuvuc.ResumeLayout(false);
            panbtnkhuvuc.PerformLayout();
            panbtnbanhang.ResumeLayout(false);
            panbtnbanhang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panbtnql;
        private Panel panbtnkhuvuc;
        private Panel panbtnbanhang;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label17;
        private Panel panuc;
    }
}