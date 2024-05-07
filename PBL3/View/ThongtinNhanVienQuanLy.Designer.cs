namespace PBL3.View
{
    partial class ThongtinNhanVienQuanLy
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
            this.Idlabel = new System.Windows.Forms.Label();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Numbertxt = new System.Windows.Forms.TextBox();
            this.Numberlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rolecbb = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.TenTklabel = new System.Windows.Forms.Label();
            this.ActiveRdbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(65, 19);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(89, 16);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "Mã nhân viên:";
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(162, 13);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(100, 22);
            this.Idtxt.TabIndex = 1;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(162, 41);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(147, 22);
            this.Nametxt.TabIndex = 3;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(65, 47);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(94, 16);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Tên nhân viên:";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(521, 41);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(178, 22);
            this.Emailtxt.TabIndex = 7;
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(424, 47);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(44, 16);
            this.Emaillabel.TabIndex = 6;
            this.Emaillabel.Text = "Email:";
            // 
            // Numbertxt
            // 
            this.Numbertxt.Location = new System.Drawing.Point(521, 13);
            this.Numbertxt.Name = "Numbertxt";
            this.Numbertxt.Size = new System.Drawing.Size(178, 22);
            this.Numbertxt.TabIndex = 5;
            // 
            // Numberlabel
            // 
            this.Numberlabel.AutoSize = true;
            this.Numberlabel.Location = new System.Drawing.Point(424, 19);
            this.Numberlabel.Name = "Numberlabel";
            this.Numberlabel.Size = new System.Drawing.Size(89, 16);
            this.Numberlabel.TabIndex = 4;
            this.Numberlabel.Text = "Số Điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vai trò:";
            // 
            // Rolecbb
            // 
            this.Rolecbb.FormattingEnabled = true;
            this.Rolecbb.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên quản lý",
            "Nhân viên bán hàng"});
            this.Rolecbb.Location = new System.Drawing.Point(162, 69);
            this.Rolecbb.Name = "Rolecbb";
            this.Rolecbb.Size = new System.Drawing.Size(121, 24);
            this.Rolecbb.TabIndex = 9;
            this.Rolecbb.Text = "Admin";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(173, 111);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 39);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Thêm";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(293, 111);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 39);
            this.EditButton.TabIndex = 11;
            this.EditButton.Text = "Sửa";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(526, 111);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 39);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(406, 111);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 39);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 276);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(521, 72);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(118, 22);
            this.Usernametxt.TabIndex = 16;
            // 
            // TenTklabel
            // 
            this.TenTklabel.AutoSize = true;
            this.TenTklabel.Location = new System.Drawing.Point(424, 78);
            this.TenTklabel.Name = "TenTklabel";
            this.TenTklabel.Size = new System.Drawing.Size(91, 16);
            this.TenTklabel.TabIndex = 15;
            this.TenTklabel.Text = "Tên tài khoản:";
            // 
            // ActiveRdbtn
            // 
            this.ActiveRdbtn.AutoSize = true;
            this.ActiveRdbtn.Location = new System.Drawing.Point(667, 78);
            this.ActiveRdbtn.Name = "ActiveRdbtn";
            this.ActiveRdbtn.Size = new System.Drawing.Size(94, 20);
            this.ActiveRdbtn.TabIndex = 18;
            this.ActiveRdbtn.TabStop = true;
            this.ActiveRdbtn.Text = "Trạng Thái";
            this.ActiveRdbtn.UseVisualStyleBackColor = true;
            // 
            // ThongtinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActiveRdbtn);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.TenTklabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Rolecbb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Numbertxt);
            this.Controls.Add(this.Numberlabel);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.Idlabel);
            this.Name = "ThongtinNhanVien";
            this.Text = "ThongtinNhanVien";
            this.Load += new System.EventHandler(this.ThongtinNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.TextBox Numbertxt;
        private System.Windows.Forms.Label Numberlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Rolecbb;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label TenTklabel;
        private System.Windows.Forms.RadioButton ActiveRdbtn;
    }
}