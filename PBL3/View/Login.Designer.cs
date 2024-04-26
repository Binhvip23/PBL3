namespace PBL3.View
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DNhap = new System.Windows.Forms.TextBox();
            this.MKhau = new System.Windows.Forms.TextBox();
            this.Dang_Nhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnrorDangNhap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tai khoan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mat khau:";
            // 
            // DNhap
            // 
            this.DNhap.Location = new System.Drawing.Point(220, 104);
            this.DNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNhap.Name = "DNhap";
            this.DNhap.Size = new System.Drawing.Size(183, 22);
            this.DNhap.TabIndex = 2;
            // 
            // MKhau
            // 
            this.MKhau.Location = new System.Drawing.Point(220, 156);
            this.MKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MKhau.Name = "MKhau";
            this.MKhau.Size = new System.Drawing.Size(183, 22);
            this.MKhau.TabIndex = 3;
            // 
            // Dang_Nhap
            // 
            this.Dang_Nhap.Location = new System.Drawing.Point(161, 223);
            this.Dang_Nhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dang_Nhap.Name = "Dang_Nhap";
            this.Dang_Nhap.Size = new System.Drawing.Size(159, 38);
            this.Dang_Nhap.TabIndex = 4;
            this.Dang_Nhap.Text = "Dang Nhap";
            this.Dang_Nhap.UseVisualStyleBackColor = true;
            this.Dang_Nhap.Click += new System.EventHandler(this.Dang_Nhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dang Nhap De Tiep Tuc";
            // 
            // EnrorDangNhap
            // 
            this.EnrorDangNhap.Location = new System.Drawing.Point(0, 0);
            this.EnrorDangNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnrorDangNhap.Name = "EnrorDangNhap";
            this.EnrorDangNhap.Size = new System.Drawing.Size(67, 15);
            this.EnrorDangNhap.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 299);
            this.Controls.Add(this.EnrorDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Dang_Nhap);
            this.Controls.Add(this.MKhau);
            this.Controls.Add(this.DNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DNhap;
        private System.Windows.Forms.TextBox MKhau;
        private System.Windows.Forms.Button Dang_Nhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EnrorDangNhap;
    }
}

