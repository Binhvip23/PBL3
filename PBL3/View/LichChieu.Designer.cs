namespace PBL3.View
{
    partial class LichChieu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.ngaychieu = new System.Windows.Forms.Label();
            this.Timetxt = new System.Windows.Forms.TextBox();
            this.giochieu = new System.Windows.Forms.Label();
            this.NVQL = new System.Windows.Forms.Label();
            this.cbbTenPhim = new System.Windows.Forms.ComboBox();
            this.cbbNVQL = new System.Windows.Forms.ComboBox();
            this.cbbDate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(545, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TenPhim
            // 
            this.TenPhim.AutoSize = true;
            this.TenPhim.BackColor = System.Drawing.Color.Transparent;
            this.TenPhim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TenPhim.Location = new System.Drawing.Point(46, 51);
            this.TenPhim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Size = new System.Drawing.Size(52, 13);
            this.TenPhim.TabIndex = 1;
            this.TenPhim.Text = "Tên Phim";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ID.Location = new System.Drawing.Point(46, 32);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(158, 30);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(168, 20);
            this.IDtxt.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.DarkRed;
            this.btThem.BackgroundImage = global::PBL3.Properties.Resources.add_icon_png_02;
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.Location = new System.Drawing.Point(49, 154);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(124, 51);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Them";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.DarkRed;
            this.btSua.BackgroundImage = global::PBL3.Properties.Resources.R1;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Location = new System.Drawing.Point(200, 154);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(124, 51);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sua";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btXoa.BackgroundImage = global::PBL3.Properties.Resources._698410_trash_512x5122;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Location = new System.Drawing.Point(48, 220);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(124, 51);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xoa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkRed;
            this.btThoat.BackgroundImage = global::PBL3.Properties.Resources._7836411;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.Location = new System.Drawing.Point(200, 220);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(124, 51);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // ngaychieu
            // 
            this.ngaychieu.AutoSize = true;
            this.ngaychieu.BackColor = System.Drawing.Color.Transparent;
            this.ngaychieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ngaychieu.Location = new System.Drawing.Point(46, 72);
            this.ngaychieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngaychieu.Name = "ngaychieu";
            this.ngaychieu.Size = new System.Drawing.Size(61, 13);
            this.ngaychieu.TabIndex = 10;
            this.ngaychieu.Text = "Ngày chiếu";
            // 
            // Timetxt
            // 
            this.Timetxt.Location = new System.Drawing.Point(158, 94);
            this.Timetxt.Margin = new System.Windows.Forms.Padding(2);
            this.Timetxt.MaxLength = 2;
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.Size = new System.Drawing.Size(38, 20);
            this.Timetxt.TabIndex = 13;
            // 
            // giochieu
            // 
            this.giochieu.AutoSize = true;
            this.giochieu.BackColor = System.Drawing.Color.Transparent;
            this.giochieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.giochieu.Location = new System.Drawing.Point(46, 94);
            this.giochieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.giochieu.Name = "giochieu";
            this.giochieu.Size = new System.Drawing.Size(53, 13);
            this.giochieu.TabIndex = 12;
            this.giochieu.Text = "Giờ Chiếu";
            // 
            // NVQL
            // 
            this.NVQL.AutoSize = true;
            this.NVQL.BackColor = System.Drawing.Color.Transparent;
            this.NVQL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NVQL.Location = new System.Drawing.Point(46, 114);
            this.NVQL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NVQL.Name = "NVQL";
            this.NVQL.Size = new System.Drawing.Size(93, 13);
            this.NVQL.TabIndex = 14;
            this.NVQL.Text = "Nhân viên quản lý";
            // 
            // cbbTenPhim
            // 
            this.cbbTenPhim.FormattingEnabled = true;
            this.cbbTenPhim.Location = new System.Drawing.Point(158, 51);
            this.cbbTenPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbTenPhim.Name = "cbbTenPhim";
            this.cbbTenPhim.Size = new System.Drawing.Size(168, 21);
            this.cbbTenPhim.TabIndex = 17;
            // 
            // cbbNVQL
            // 
            this.cbbNVQL.FormattingEnabled = true;
            this.cbbNVQL.Location = new System.Drawing.Point(156, 114);
            this.cbbNVQL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbNVQL.Name = "cbbNVQL";
            this.cbbNVQL.Size = new System.Drawing.Size(168, 21);
            this.cbbNVQL.TabIndex = 18;
            // 
            // cbbDate
            // 
            this.cbbDate.FormattingEnabled = true;
            this.cbbDate.Location = new System.Drawing.Point(158, 72);
            this.cbbDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.Size = new System.Drawing.Size(168, 21);
            this.cbbDate.TabIndex = 19;
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PBL3.Properties.Resources.mat_bang_rap_chieu_phim1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 553);
            this.Controls.Add(this.cbbDate);
            this.Controls.Add(this.cbbNVQL);
            this.Controls.Add(this.cbbTenPhim);
            this.Controls.Add(this.NVQL);
            this.Controls.Add(this.Timetxt);
            this.Controls.Add(this.giochieu);
            this.Controls.Add(this.ngaychieu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.TenPhim);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LichChieu";
            this.Text = "LichChieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TenPhim;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label ngaychieu;
        private System.Windows.Forms.TextBox Timetxt;
        private System.Windows.Forms.Label giochieu;
        private System.Windows.Forms.Label NVQL;
        private System.Windows.Forms.ComboBox cbbTenPhim;
        private System.Windows.Forms.ComboBox cbbNVQL;
        private System.Windows.Forms.ComboBox cbbDate;
    }
}