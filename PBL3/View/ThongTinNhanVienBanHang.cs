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
        NhanVienBanHangController controller;
        public ThongTinNhanVienBanHang()
        {
            controller = NhanVienBanHangController.Instance;
            InitializeComponent();
            LoadData();
        }

        readonly string[] header = { "KPI", "Tên đăng nhập","Trạng thái", "ID", "Tên", "Số điện thoại", "Email", "Vai trò" };
        private void ThongtinNhanVien_Load(object sender, EventArgs e)
        {
            controller = NhanVienBanHangController.Instance;
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = controller.GetAllNhanVien();
            for (int i = 0; i < header.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = header[i];
            }
            dataGridView1.Columns[0].DisplayIndex = 6;
            dataGridView1.Columns[1].DisplayIndex = 5;
            dataGridView1.Columns[2].DisplayIndex = 4;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaNV.Text);
            string ten = txtTenNV.Text;
            string sdt = txtSDT.Text;
            string email = txtGmail.Text;
            string vaitro = txtVaiTro.Text;
            string tendangnhap = txtTaiKhoan.Text;
            bool trangthai =radioButton1.Checked;
            controller.Add(id, ten, sdt, email, vaitro, tendangnhap, trangthai);
            LoadData();
            MessageBox.Show("Thêm thành công!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string ten = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string sdt = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string vaitro = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string trangthai = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string tendangnhap = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                controller.Update(Convert.ToInt32(id), ten, sdt, email, vaitro, tendangnhap,Convert.ToBoolean(trangthai));
                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                controller.Delete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Selected = true;
                txtMaNV.Text = row.Cells["Id"].Value.ToString();
                txtTenNV.Text = row.Cells["FullName"].Value.ToString();
                txtSDT.Text = row.Cells["SoDT"].Value.ToString();
                txtGmail.Text = row.Cells["Email"].Value.ToString();
                txtVaiTro.Text = row.Cells["VaiTro"].Value.ToString();
                txtTaiKhoan.Text = row.Cells["Taikhoan"].Value.ToString();
                radioButton1.Checked = Convert.ToBoolean(row.Cells["Active"].Value);
            }
        }

        private void ThongTinNhanVienBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
