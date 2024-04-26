namespace PBL3.View
{
    partial class QuanLy
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
            this.Quan_Ly_Phong_Chieu = new System.Windows.Forms.Button();
            this.Quan_Ly_Phim = new System.Windows.Forms.Button();
            this.Quan_Ly_Lich_Chieu = new System.Windows.Forms.Button();
            this.Quan_Ly_Nhan_Vien = new System.Windows.Forms.Button();
            this.Doanh_Thu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quan_Ly_Phong_Chieu
            // 
            this.Quan_Ly_Phong_Chieu.Location = new System.Drawing.Point(51, 56);
            this.Quan_Ly_Phong_Chieu.Name = "Quan_Ly_Phong_Chieu";
            this.Quan_Ly_Phong_Chieu.Size = new System.Drawing.Size(438, 152);
            this.Quan_Ly_Phong_Chieu.TabIndex = 0;
            this.Quan_Ly_Phong_Chieu.Text = "Quan Ly Phong Chieu";
            this.Quan_Ly_Phong_Chieu.UseVisualStyleBackColor = true;
            this.Quan_Ly_Phong_Chieu.Click += new System.EventHandler(this.Quan_Ly_Phong_Chieu_Click);
            // 
            // Quan_Ly_Phim
            // 
            this.Quan_Ly_Phim.Location = new System.Drawing.Point(51, 252);
            this.Quan_Ly_Phim.Name = "Quan_Ly_Phim";
            this.Quan_Ly_Phim.Size = new System.Drawing.Size(438, 152);
            this.Quan_Ly_Phim.TabIndex = 1;
            this.Quan_Ly_Phim.Text = "Quan Ly Phim";
            this.Quan_Ly_Phim.UseVisualStyleBackColor = true;
            this.Quan_Ly_Phim.Click += new System.EventHandler(this.Quan_Ly_Phim_Click);
            // 
            // Quan_Ly_Lich_Chieu
            // 
            this.Quan_Ly_Lich_Chieu.Location = new System.Drawing.Point(51, 441);
            this.Quan_Ly_Lich_Chieu.Name = "Quan_Ly_Lich_Chieu";
            this.Quan_Ly_Lich_Chieu.Size = new System.Drawing.Size(438, 152);
            this.Quan_Ly_Lich_Chieu.TabIndex = 2;
            this.Quan_Ly_Lich_Chieu.Text = "Quan Ly Lich Chieu";
            this.Quan_Ly_Lich_Chieu.UseVisualStyleBackColor = true;
            this.Quan_Ly_Lich_Chieu.Click += new System.EventHandler(this.Quan_Ly_Lich_Chieu_Click);
            // 
            // Quan_Ly_Nhan_Vien
            // 
            this.Quan_Ly_Nhan_Vien.Location = new System.Drawing.Point(51, 627);
            this.Quan_Ly_Nhan_Vien.Name = "Quan_Ly_Nhan_Vien";
            this.Quan_Ly_Nhan_Vien.Size = new System.Drawing.Size(438, 152);
            this.Quan_Ly_Nhan_Vien.TabIndex = 3;
            this.Quan_Ly_Nhan_Vien.Text = "Quan Ly Nhan Vien";
            this.Quan_Ly_Nhan_Vien.UseVisualStyleBackColor = true;
            this.Quan_Ly_Nhan_Vien.Click += new System.EventHandler(this.Quan_Ly_Nhan_Vien_Click);
            // 
            // Doanh_Thu
            // 
            this.Doanh_Thu.Location = new System.Drawing.Point(51, 816);
            this.Doanh_Thu.Name = "Doanh_Thu";
            this.Doanh_Thu.Size = new System.Drawing.Size(438, 152);
            this.Doanh_Thu.TabIndex = 4;
            this.Doanh_Thu.Text = "Doanh Thu";
            this.Doanh_Thu.UseVisualStyleBackColor = true;
            this.Doanh_Thu.Click += new System.EventHandler(this.Doanh_Thu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(771, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 141);
            this.button2.TabIndex = 5;
            this.button2.Text = "anhdeptrai";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Doanh_Thu);
            this.Controls.Add(this.Quan_Ly_Nhan_Vien);
            this.Controls.Add(this.Quan_Ly_Lich_Chieu);
            this.Controls.Add(this.Quan_Ly_Phim);
            this.Controls.Add(this.Quan_Ly_Phong_Chieu);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Quan_Ly_Phong_Chieu;
        private System.Windows.Forms.Button Quan_Ly_Phim;
        private System.Windows.Forms.Button Quan_Ly_Lich_Chieu;
        private System.Windows.Forms.Button Quan_Ly_Nhan_Vien;
        private System.Windows.Forms.Button Doanh_Thu;
        private System.Windows.Forms.Button button2;
    }
}