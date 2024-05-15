namespace PBL3.View
{
    partial class Banve
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.Phimcbb = new System.Windows.Forms.ComboBox();
            this.DTChieu = new System.Windows.Forms.DateTimePicker();
            this.DTSearch = new System.Windows.Forms.CheckBox();
            this.cbbChonPhong = new System.Windows.Forms.ComboBox();
            this.btTimPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 463);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn Phòng";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(403, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 457);
            this.panel1.TabIndex = 7;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(159, 180);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(123, 42);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tim kiem Phim";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // Phimcbb
            // 
            this.Phimcbb.FormattingEnabled = true;
            this.Phimcbb.Location = new System.Drawing.Point(159, 34);
            this.Phimcbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phimcbb.Name = "Phimcbb";
            this.Phimcbb.Size = new System.Drawing.Size(121, 24);
            this.Phimcbb.TabIndex = 13;
            // 
            // DTChieu
            // 
            this.DTChieu.Location = new System.Drawing.Point(159, 81);
            this.DTChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTChieu.Name = "DTChieu";
            this.DTChieu.Size = new System.Drawing.Size(200, 22);
            this.DTChieu.TabIndex = 14;
            // 
            // DTSearch
            // 
            this.DTSearch.AutoSize = true;
            this.DTSearch.Location = new System.Drawing.Point(377, 84);
            this.DTSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTSearch.Name = "DTSearch";
            this.DTSearch.Size = new System.Drawing.Size(18, 17);
            this.DTSearch.TabIndex = 15;
            this.DTSearch.UseVisualStyleBackColor = true;
            // 
            // cbbChonPhong
            // 
            this.cbbChonPhong.FormattingEnabled = true;
            this.cbbChonPhong.Location = new System.Drawing.Point(159, 135);
            this.cbbChonPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChonPhong.Name = "cbbChonPhong";
            this.cbbChonPhong.Size = new System.Drawing.Size(160, 24);
            this.cbbChonPhong.TabIndex = 0;
            // 
            // btTimPhong
            // 
            this.btTimPhong.Location = new System.Drawing.Point(159, 249);
            this.btTimPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btTimPhong.Name = "btTimPhong";
            this.btTimPhong.Size = new System.Drawing.Size(123, 36);
            this.btTimPhong.TabIndex = 16;
            this.btTimPhong.Text = "Tim Phong";
            this.btTimPhong.UseVisualStyleBackColor = true;
            this.btTimPhong.Click += new System.EventHandler(this.btTimPhong_Click);
            // 
            // Banve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 747);
            this.Controls.Add(this.btTimPhong);
            this.Controls.Add(this.cbbChonPhong);
            this.Controls.Add(this.DTSearch);
            this.Controls.Add(this.DTChieu);
            this.Controls.Add(this.Phimcbb);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Banve";
            this.Text = "Banve";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.ComboBox Phimcbb;
        private System.Windows.Forms.DateTimePicker DTChieu;
        private System.Windows.Forms.CheckBox DTSearch;
        private System.Windows.Forms.ComboBox cbbChonPhong;
        private System.Windows.Forms.Button btTimPhong;
    }
}