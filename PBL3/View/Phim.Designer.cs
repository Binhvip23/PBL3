namespace PBL3.View
{
    partial class Phim
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtthoiluong = new System.Windows.Forms.TextBox();
            this.ThoiLuong = new System.Windows.Forms.Label();
            this.cbbtheloai = new System.Windows.Forms.ComboBox();
            this.TheLoai = new System.Windows.Forms.Label();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.MaPhim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(557, 1);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(757, 630);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(38, 495);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(170, 47);
            this.btThoat.TabIndex = 13;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(38, 410);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(170, 47);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(38, 326);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(170, 47);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sua";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(38, 239);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(170, 47);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(120, 146);
            this.txtmota.Margin = new System.Windows.Forms.Padding(2);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(210, 22);
            this.txtmota.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "phút";
            // 
            // txtthoiluong
            // 
            this.txtthoiluong.Location = new System.Drawing.Point(123, 120);
            this.txtthoiluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtthoiluong.Name = "txtthoiluong";
            this.txtthoiluong.Size = new System.Drawing.Size(130, 22);
            this.txtthoiluong.TabIndex = 8;
            // 
            // ThoiLuong
            // 
            this.ThoiLuong.AutoSize = true;
            this.ThoiLuong.Location = new System.Drawing.Point(38, 118);
            this.ThoiLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThoiLuong.Name = "ThoiLuong";
            this.ThoiLuong.Size = new System.Drawing.Size(70, 16);
            this.ThoiLuong.TabIndex = 5;
            this.ThoiLuong.Text = "Thời lượng";
            // 
            // cbbtheloai
            // 
            this.cbbtheloai.FormattingEnabled = true;
            this.cbbtheloai.Items.AddRange(new object[] {
            "Lãng mạn",
            "Kinh dị",
            "Hài",
            "Viễn tưởng",
            "Hành động"});
            this.cbbtheloai.Location = new System.Drawing.Point(120, 91);
            this.cbbtheloai.Name = "cbbtheloai";
            this.cbbtheloai.Size = new System.Drawing.Size(195, 24);
            this.cbbtheloai.TabIndex = 12;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSize = true;
            this.TheLoai.Location = new System.Drawing.Point(38, 88);
            this.TheLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(56, 16);
            this.TheLoai.TabIndex = 4;
            this.TheLoai.Text = "Thể loại";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(120, 64);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(210, 22);
            this.txtTenPhim.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phim";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(120, 38);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(210, 22);
            this.txtMaPhim.TabIndex = 6;
            // 
            // MaPhim
            // 
            this.MaPhim.AutoSize = true;
            this.MaPhim.Location = new System.Drawing.Point(38, 36);
            this.MaPhim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.Size = new System.Drawing.Size(61, 16);
            this.MaPhim.TabIndex = 2;
            this.MaPhim.Text = "Mã phim:";
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 629);
            this.Controls.Add(this.MaPhim);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.cbbtheloai);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ThoiLuong);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtthoiluong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Phim";
            this.Text = "Phim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtthoiluong;
        private System.Windows.Forms.Label ThoiLuong;
        private System.Windows.Forms.ComboBox cbbtheloai;
        private System.Windows.Forms.Label TheLoai;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.Label MaPhim;
    }
}