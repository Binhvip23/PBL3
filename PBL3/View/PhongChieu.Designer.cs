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
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.cbchange = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(515, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(761, 689);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.DarkRed;
            this.btThoat.BackgroundImage = global::PBL3.Properties.Resources._783641;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.Location = new System.Drawing.Point(55, 472);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(205, 74);
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
            this.btXoa.Location = new System.Drawing.Point(55, 379);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(205, 79);
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
            this.btSua.Location = new System.Drawing.Point(55, 288);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(205, 74);
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
            this.btThem.Location = new System.Drawing.Point(55, 198);
            this.btThem.Margin = new System.Windows.Forms.Padding(2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(205, 73);
            this.btThem.TabIndex = 5;
            this.btThem.Text = "Them";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // cbchange
            // 
            this.cbchange.AutoSize = true;
            this.cbchange.Location = new System.Drawing.Point(61, 161);
            this.cbchange.Name = "cbchange";
            this.cbchange.Size = new System.Drawing.Size(199, 20);
            this.cbchange.TabIndex = 10;
            this.cbchange.Text = "Thay đổi phòng có lịch chiếu";
            this.cbchange.UseVisualStyleBackColor = true;
            this.cbchange.Visible = false;
            this.cbchange.CheckedChanged += new System.EventHandler(this.cbchange_CheckedChanged);
            // 
            // PhongChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PBL3.Properties.Resources.rap_chieu_phim_hien_dai_nhat_tai_ha_noi_ban_nen_di_thu_2611151;
            this.ClientSize = new System.Drawing.Size(1275, 680);
            this.Controls.Add(this.cbchange);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.CheckBox cbchange;
    }
}