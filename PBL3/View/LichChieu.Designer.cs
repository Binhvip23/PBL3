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
            this.dataGridView1.Location = new System.Drawing.Point(552, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(719, 621);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TenPhim
            // 
            this.TenPhim.AutoSize = true;
            this.TenPhim.Location = new System.Drawing.Point(61, 63);
            this.TenPhim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Size = new System.Drawing.Size(64, 16);
            this.TenPhim.TabIndex = 1;
            this.TenPhim.Text = "Tên Phim";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(61, 37);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(23, 16);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(211, 37);
            this.IDtxt.Margin = new System.Windows.Forms.Padding(2);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(222, 22);
            this.IDtxt.TabIndex = 5;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(65, 190);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(155, 63);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(65, 292);
            this.btSua.Margin = new System.Windows.Forms.Padding(2);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(155, 63);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sua";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(65, 387);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(155, 63);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(65, 485);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(155, 63);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // ngaychieu
            // 
            this.ngaychieu.AutoSize = true;
            this.ngaychieu.Location = new System.Drawing.Point(61, 89);
            this.ngaychieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ngaychieu.Name = "ngaychieu";
            this.ngaychieu.Size = new System.Drawing.Size(75, 16);
            this.ngaychieu.TabIndex = 10;
            this.ngaychieu.Text = "Ngày chiếu";
            // 
            // Timetxt
            // 
            this.Timetxt.Location = new System.Drawing.Point(211, 115);
            this.Timetxt.Margin = new System.Windows.Forms.Padding(2);
            this.Timetxt.MaxLength = 2;
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.Size = new System.Drawing.Size(50, 22);
            this.Timetxt.TabIndex = 13;
            // 
            // giochieu
            // 
            this.giochieu.AutoSize = true;
            this.giochieu.Location = new System.Drawing.Point(61, 115);
            this.giochieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.giochieu.Name = "giochieu";
            this.giochieu.Size = new System.Drawing.Size(65, 16);
            this.giochieu.TabIndex = 12;
            this.giochieu.Text = "Giờ Chiếu";
            // 
            // NVQL
            // 
            this.NVQL.AutoSize = true;
            this.NVQL.Location = new System.Drawing.Point(61, 141);
            this.NVQL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NVQL.Name = "NVQL";
            this.NVQL.Size = new System.Drawing.Size(113, 16);
            this.NVQL.TabIndex = 14;
            this.NVQL.Text = "Nhân viên quản lý";
            // 
            // cbbTenPhim
            // 
            this.cbbTenPhim.FormattingEnabled = true;
            this.cbbTenPhim.Location = new System.Drawing.Point(211, 63);
            this.cbbTenPhim.Name = "cbbTenPhim";
            this.cbbTenPhim.Size = new System.Drawing.Size(222, 24);
            this.cbbTenPhim.TabIndex = 17;
            // 
            // cbbNVQL
            // 
            this.cbbNVQL.FormattingEnabled = true;
            this.cbbNVQL.Location = new System.Drawing.Point(211, 138);
            this.cbbNVQL.Name = "cbbNVQL";
            this.cbbNVQL.Size = new System.Drawing.Size(222, 24);
            this.cbbNVQL.TabIndex = 18;
            // 
            // cbbDate
            // 
            this.cbbDate.FormattingEnabled = true;
            this.cbbDate.Location = new System.Drawing.Point(211, 89);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.Size = new System.Drawing.Size(222, 24);
            this.cbbDate.TabIndex = 19;
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1271, 618);
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