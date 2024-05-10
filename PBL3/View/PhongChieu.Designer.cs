namespace PBL3.View
{
    partial class PhongChieu
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
            this.Ma_PhongChieu = new System.Windows.Forms.Label();
            this.Ten_PhongChieu = new System.Windows.Forms.Label();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.txtTenPhongChieu = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(772, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 1077);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Ma_PhongChieu
            // 
            this.Ma_PhongChieu.AutoSize = true;
            this.Ma_PhongChieu.BackColor = System.Drawing.Color.Transparent;
            this.Ma_PhongChieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ma_PhongChieu.Location = new System.Drawing.Point(150, 110);
            this.Ma_PhongChieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ma_PhongChieu.Name = "Ma_PhongChieu";
            this.Ma_PhongChieu.Size = new System.Drawing.Size(178, 25);
            this.Ma_PhongChieu.TabIndex = 1;
            this.Ma_PhongChieu.Text = "Ma Phong Chieu:";
            // 
            // Ten_PhongChieu
            // 
            this.Ten_PhongChieu.AutoSize = true;
            this.Ten_PhongChieu.BackColor = System.Drawing.Color.Transparent;
            this.Ten_PhongChieu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ten_PhongChieu.Location = new System.Drawing.Point(148, 196);
            this.Ten_PhongChieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ten_PhongChieu.Name = "Ten_PhongChieu";
            this.Ten_PhongChieu.Size = new System.Drawing.Size(179, 25);
            this.Ten_PhongChieu.TabIndex = 2;
            this.Ten_PhongChieu.Text = "Ten Phong Chieu";
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.Location = new System.Drawing.Point(334, 110);
            this.txtMaPhongChieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.Size = new System.Drawing.Size(276, 31);
            this.txtMaPhongChieu.TabIndex = 3;
            // 
            // txtTenPhongChieu
            // 
            this.txtTenPhongChieu.Location = new System.Drawing.Point(334, 196);
            this.txtTenPhongChieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhongChieu.Name = "txtTenPhongChieu";
            this.txtTenPhongChieu.Size = new System.Drawing.Size(276, 31);
            this.txtTenPhongChieu.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btSearch.BackgroundImage = global::PBL3.Properties.Resources.OIP__1_;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Location = new System.Drawing.Point(648, 112);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(116, 115);
            this.btSearch.TabIndex = 9;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkRed;
            this.btThoat.BackgroundImage = global::PBL3.Properties.Resources._783641;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.Location = new System.Drawing.Point(82, 737);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(308, 115);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoat";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.DarkRed;
            this.btXoa.BackgroundImage = global::PBL3.Properties.Resources._698410_trash_512x5121;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Location = new System.Drawing.Point(82, 592);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(308, 123);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xoa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.DarkRed;
            this.btSua.BackgroundImage = global::PBL3.Properties.Resources.R;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.Location = new System.Drawing.Point(82, 450);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(308, 115);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sua";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Maroon;
            this.btThem.BackgroundImage = global::PBL3.Properties.Resources.add_icon_png_0;
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btThem.Location = new System.Drawing.Point(82, 296);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(308, 115);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Them";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // PhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PBL3.Properties.Resources.rap_chieu_phim_hien_dai_nhat_tai_ha_noi_ban_nen_di_thu_2611151;
            this.ClientSize = new System.Drawing.Size(1912, 1063);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTenPhongChieu);
            this.Controls.Add(this.txtMaPhongChieu);
            this.Controls.Add(this.Ten_PhongChieu);
            this.Controls.Add(this.Ma_PhongChieu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhongChieu";
            this.Text = "PhongChieu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label Ma_PhongChieu;
        private System.Windows.Forms.Label Ten_PhongChieu;
        private System.Windows.Forms.TextBox txtMaPhongChieu;
        private System.Windows.Forms.TextBox txtTenPhongChieu;
        private System.Windows.Forms.Button btSearch;
    }
}