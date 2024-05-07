using PBL3.Controller;
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
    public partial class ThongTinNhanVienBanHang : Form
    {
        NhanVienController controller;
        public ThongTinNhanVienBanHang()
        {
            InitializeComponent();
        }

        string[] header = { "Tên đăng nhập", "Trạng thái", "ID", "Tên", "Số điện thoại", "Email", "Vai trò" };
        private void ThongtinNhanVien_Load(object sender, EventArgs e)
        {
            controller = new NhanVienController();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = controller.GetAllNhanVien();
            for (int i = 0; i < header.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = header[i];
            }
            dataGridView1.Columns[0].DisplayIndex = 5;
            dataGridView1.Columns[1].DisplayIndex = 6;
        }
    }
}
