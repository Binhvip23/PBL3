namespace PBL3.View
{
    partial class TimKiemTheoTen
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
            this.Tentxt = new System.Windows.Forms.TextBox();
            this.TenLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tentxt
            // 
            this.Tentxt.Location = new System.Drawing.Point(55, 46);
            this.Tentxt.Name = "Tentxt";
            this.Tentxt.Size = new System.Drawing.Size(170, 22);
            this.Tentxt.TabIndex = 0;
            // 
            // TenLabel
            // 
            this.TenLabel.AutoSize = true;
            this.TenLabel.Location = new System.Drawing.Point(52, 27);
            this.TenLabel.Name = "TenLabel";
            this.TenLabel.Size = new System.Drawing.Size(64, 16);
            this.TenLabel.TabIndex = 1;
            this.TenLabel.Text = "Nhập tên:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(320, 44);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TimKiemTheoTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 116);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TenLabel);
            this.Controls.Add(this.Tentxt);
            this.Name = "TimKiemTheoTen";
            this.Text = "TimKiemTheoTen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tentxt;
        private System.Windows.Forms.Label TenLabel;
        private System.Windows.Forms.Button SearchButton;
    }
}