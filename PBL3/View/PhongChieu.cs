using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Controller;
using PBL3.Model;
using PBL3.Model.DAO;

namespace PBL3.View
{
    public partial class PhongChieu : Form
    {
        private PhongChieuController controller;
        public PhongChieu()
        {
            InitializeComponent();
            controller = PhongChieuController.Instance;
            RefreshDGV();

        }
        public PhongChieu(int id)
        {
            InitializeComponent();
            controller = PhongChieuController.Instance;
            dataGridView1.DataSource = controller.GetAllPhongChieuPhim(id);

        }
        public void RefreshDGV()
        {
            dataGridView1.DataSource = controller.GetAllPhongChieu();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên phòng chiếu";
            dataGridView1.Columns[2].HeaderText = "Sức chứa";
            dataGridView1.Columns[3].HeaderText = "Mô tả";

        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThongTinPhongChieu form = new ThongTinPhongChieu();
            form.function = new ThongTinPhongChieu.MyDel(AddInformation);
            form.Show();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string s = row.Cells[0].Value.ToString();
                ThongTinPhongChieu form = new ThongTinPhongChieu(s);
                form.function = new ThongTinPhongChieu.MyDel(UpdateInfomation);
                form.Show();
            }
            else MessageBox.Show("Chọn dòng muốn cập nhật");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());
                controller.DeletePhongChieu(id);
                RefreshDGV();
                MessageBox.Show("Xóa thành công!");
            }
            else MessageBox.Show("Chọn dòng muốn xóa");
        }
        public void AddInformation(int id, string name, int succhua, string mota)
        {
            controller.AddPhongChieu(id, name, succhua, mota);
            RefreshDGV();
            MessageBox.Show("Thêm thành công!");
        }
        public void UpdateInfomation(int id, string name, int succhua, string mota)
        {
            controller.UpdatePhongChieu(id, name, succhua, mota);
            RefreshDGV();
            MessageBox.Show("Cập nhật thành công");
        }

        public void SearchInformation(int id, String name )
        {
            dataGridView1.DataSource = controller.Search(id,name);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if(txtMaPhongChieu.Text.Length>0)
            {
                int a = Convert.ToInt32(txtMaPhongChieu.Text);
                String b = txtTenPhongChieu.Text;
                SearchInformation(a, b);
            }
            else
            {
                RefreshDGV();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow select = dataGridView1.Rows[e.RowIndex];
                select.Selected = true;
                int id = Convert.ToInt32(select.Cells["Id"].Value.ToString());
                LichChieu lc = new LichChieu(id);
                lc.Show();
            }
            MessageBox.Show("Hien thi Lich chieu");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow select = dataGridView1.Rows[e.RowIndex];
                select.Selected = true;
            }
        }
    }
}
