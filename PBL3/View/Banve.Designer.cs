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
            this.ccbChonPhong = new System.Windows.Forms.ComboBox();
            this.btTimPhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 376);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(958, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chon Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chon ngay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chon Phong";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(302, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 371);
            this.panel1.TabIndex = 7;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(119, 146);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(92, 34);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tim kiem Phim";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // Phimcbb
            // 
            this.Phimcbb.FormattingEnabled = true;
            this.Phimcbb.Location = new System.Drawing.Point(119, 28);
            this.Phimcbb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Phimcbb.Name = "Phimcbb";
            this.Phimcbb.Size = new System.Drawing.Size(92, 21);
            this.Phimcbb.TabIndex = 13;
            // 
            // DTChieu
            // 
            this.DTChieu.Location = new System.Drawing.Point(119, 66);
            this.DTChieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTChieu.Name = "DTChieu";
            this.DTChieu.Size = new System.Drawing.Size(151, 20);
            this.DTChieu.TabIndex = 14;
            // 
            // DTSearch
            // 
            this.DTSearch.AutoSize = true;
            this.DTSearch.Location = new System.Drawing.Point(283, 68);
            this.DTSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTSearch.Name = "DTSearch";
            this.DTSearch.Size = new System.Drawing.Size(15, 14);
            this.DTSearch.TabIndex = 15;
            this.DTSearch.UseVisualStyleBackColor = true;
            // 
            // ccbChonPhong
            // 
            this.ccbChonPhong.FormattingEnabled = true;
            this.ccbChonPhong.Location = new System.Drawing.Point(119, 110);
            this.ccbChonPhong.Name = "ccbChonPhong";
            this.ccbChonPhong.Size = new System.Drawing.Size(121, 21);
            this.ccbChonPhong.TabIndex = 0;
            // 
            // btTimPhong
            // 
            this.btTimPhong.Location = new System.Drawing.Point(119, 202);
            this.btTimPhong.Name = "btTimPhong";
            this.btTimPhong.Size = new System.Drawing.Size(92, 29);
            this.btTimPhong.TabIndex = 16;
            this.btTimPhong.Text = "Tim Phong";
            this.btTimPhong.UseVisualStyleBackColor = true;
            this.btTimPhong.Click += new System.EventHandler(this.btTimPhong_Click);
            // 
            // Banve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 607);
            this.Controls.Add(this.btTimPhong);
            this.Controls.Add(this.ccbChonPhong);
            this.Controls.Add(this.DTSearch);
            this.Controls.Add(this.DTChieu);
            this.Controls.Add(this.Phimcbb);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox ccbChonPhong;
        private System.Windows.Forms.Button btTimPhong;
    }
}