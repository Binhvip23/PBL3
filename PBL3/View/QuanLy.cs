using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class QuanLy : Form
    {

        private Form currentChildForm;
        public QuanLy()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void Quan_Ly_Phong_Chieu_Click(object sender, EventArgs e)
        {
            openChildForm(new PhongChieu());
            //anhdep trai vai lz con ket
        }

        private void Quan_Ly_Phim_Click(object sender, EventArgs e)
        {
            openChildForm(new Phim());
        }

        private void Quan_Ly_Lich_Chieu_Click(object sender, EventArgs e)
        {
            openChildForm(new LichChieu());
        }

        private void Quan_Ly_Nhan_Vien_Click(object sender, EventArgs e)
        {

            openChildForm(new ThongtinNhanVienQuanLy());
        }

        private void Doanh_Thu_Click(object sender, EventArgs e)
        {
            openChildForm(new DoanhThu());
        }

        private void btNVBH_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinNhanVienBanHang());
        }

    }
}
