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
            this.Dang_Nhap = new System.Windows.Forms.Button();
            this.btOut = new System.Windows.Forms.Button();
            this.DNhap = new System.Windows.Forms.TextBox();
            this.MKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Dang_Nhap
            // 
            this.Dang_Nhap.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dang_Nhap.ForeColor = System.Drawing.Color.Black;
            this.Dang_Nhap.Location = new System.Drawing.Point(214, 218);
            this.Dang_Nhap.Margin = new System.Windows.Forms.Padding(2);
            this.Dang_Nhap.Name = "Dang_Nhap";
            this.Dang_Nhap.Size = new System.Drawing.Size(144, 31);
            this.Dang_Nhap.TabIndex = 4;
            this.Dang_Nhap.Text = "Login";
            this.Dang_Nhap.UseVisualStyleBackColor = false;
            this.Dang_Nhap.Click += new System.EventHandler(this.Dang_Nhap_Click);
            // 
            // btOut
            // 
            this.btOut.BackColor = System.Drawing.Color.Brown;
            this.btOut.BackgroundImage = global::PBL3.Properties.Resources.logout_icon_png_181;
            this.btOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btOut.ForeColor = System.Drawing.Color.IndianRed;
            this.btOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOut.Location = new System.Drawing.Point(490, 11);
            this.btOut.Margin = new System.Windows.Forms.Padding(2);
            this.btOut.Name = "btOut";
            this.btOut.Size = new System.Drawing.Size(41, 35);
            this.btOut.TabIndex = 7;
            this.btOut.UseVisualStyleBackColor = false;
            this.btOut.Click += new System.EventHandler(this.btOut_Click);
            // 
            // DNhap
            // 
            this.DNhap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DNhap.Location = new System.Drawing.Point(214, 112);
            this.DNhap.Margin = new System.Windows.Forms.Padding(2);
            this.DNhap.Name = "DNhap";
            this.DNhap.Size = new System.Drawing.Size(144, 20);
            this.DNhap.TabIndex = 8;
            this.DNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DNhap_KeyDown);
            this.DNhap.MouseEnter += new System.EventHandler(this.DNhap_Enter);
            this.DNhap.MouseLeave += new System.EventHandler(this.DNhap_Leave);
            // 
            // MKhau
            // 
            this.MKhau.BackColor = System.Drawing.SystemColors.Menu;
            this.MKhau.Location = new System.Drawing.Point(214, 169);
            this.MKhau.Margin = new System.Windows.Forms.Padding(2);
            this.MKhau.Name = "MKhau";
            this.MKhau.PasswordChar = '*';
            this.MKhau.Size = new System.Drawing.Size(144, 20);
            this.MKhau.TabIndex = 9;
            this.MKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mkhau_KeyDown);
            this.MKhau.MouseEnter += new System.EventHandler(this.MKhau_Enter);
            this.MKhau.MouseLeave += new System.EventHandler(this.MKhau_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(128, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "He Thong Quan Ly Ban Ve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PBL3.Properties.Resources.user_icon_png_transparent_213;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(144, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 43);
            this.panel3.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PBL3.Properties.Resources.password_icon_png_41;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(144, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 43);
            this.panel1.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PBL3.Properties.Resources._71Sh20FA64L__AC_SX679_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MKhau);
            this.Controls.Add(this.DNhap);
            this.Controls.Add(this.btOut);
            this.Controls.Add(this.Dang_Nhap);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Dang_Nhap;
        private System.Windows.Forms.Button btOut;
        private System.Windows.Forms.TextBox DNhap;
        private System.Windows.Forms.TextBox MKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}

