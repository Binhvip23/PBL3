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
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.Ma_PhongChieu = new System.Windows.Forms.Label();
            this.Ten_PhongChieu = new System.Windows.Forms.Label();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.txtTenPhongChieu = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(831, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 975);
            this.dataGridView1.TabIndex = 0;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(82, 297);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(309, 116);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(82, 450);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(309, 116);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sua";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(82, 592);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(309, 116);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(82, 736);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(309, 116);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Ma_PhongChieu
            // 
            this.Ma_PhongChieu.AutoSize = true;
            this.Ma_PhongChieu.Location = new System.Drawing.Point(76, 112);
            this.Ma_PhongChieu.Name = "Ma_PhongChieu";
            this.Ma_PhongChieu.Size = new System.Drawing.Size(178, 25);
            this.Ma_PhongChieu.TabIndex = 1;
            this.Ma_PhongChieu.Text = "Ma Phong Chieu:";
            // 
            // Ten_PhongChieu
            // 
            this.Ten_PhongChieu.AutoSize = true;
            this.Ten_PhongChieu.Location = new System.Drawing.Point(76, 197);
            this.Ten_PhongChieu.Name = "Ten_PhongChieu";
            this.Ten_PhongChieu.Size = new System.Drawing.Size(179, 25);
            this.Ten_PhongChieu.TabIndex = 2;
            this.Ten_PhongChieu.Text = "Ten Phong Chieu";
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.Location = new System.Drawing.Point(334, 109);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.Size = new System.Drawing.Size(276, 31);
            this.txtMaPhongChieu.TabIndex = 3;
            // 
            // txtTenPhongChieu
            // 
            this.txtTenPhongChieu.Location = new System.Drawing.Point(334, 197);
            this.txtTenPhongChieu.Name = "txtTenPhongChieu";
            this.txtTenPhongChieu.Size = new System.Drawing.Size(276, 31);
            this.txtTenPhongChieu.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(638, 112);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(192, 116);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // PhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 969);
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