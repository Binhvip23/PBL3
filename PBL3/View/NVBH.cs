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
    public partial class NVBH : Form
    {
        private NhanVienBanHangController nhanVienBanHangController;
        public NVBH()
        {
            NhanVienBanHangController nhanVienBanHangController = NhanVienBanHangController.Instance;
            InitializeComponent();
            refresh();
        }
        /*create refresh data grid view*/
        private void refresh()
        {
            dataGridView1.DataSource = nhanVienBanHangController.GetAllNhanVien();
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
