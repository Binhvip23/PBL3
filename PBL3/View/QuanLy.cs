using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void Quan_Ly_Phong_Chieu_Click(object sender, EventArgs e)
        {
            PhongChieu pc = new PhongChieu();
            pc.Show();
        }

        private void Quan_Ly_Phim_Click(object sender, EventArgs e)
        {
            Phim phim = new Phim();
            phim.Show();

        }

        private void Quan_Ly_Lich_Chieu_Click(object sender, EventArgs e)
        {
            LichChieu lc = new LichChieu();
            lc.Show();
        }

        private void Quan_Ly_Nhan_Vien_Click(object sender, EventArgs e)
        {
            ThongtinNhanVienQuanLy thongtinNhanVien = new ThongtinNhanVienQuanLy();
            thongtinNhanVien.Show();
        }

        private void Doanh_Thu_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.Show();
        }

        private void btNVBH_Click(object sender, EventArgs e)
        {
            ThongTinNhanVienBanHang nvbh = new ThongTinNhanVienBanHang();
            nvbh.Show();
        }
    }
}
