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
    public partial class Phim : Form
    {
        private PhimController controller;
        public Phim()
        {
            InitializeComponent();
            controller = new PhimController();
            refreshDGV();
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtMaPhim.Text);
                string name = txtTenPhim.Text;
                string theloai = cbbtheloai.Text;
                int thoiluong = Convert.ToInt32(txtthoiluong.Text);
                string mota = txtmota.Text;
                controller.AddPhim(id, name, theloai, thoiluong, mota);
                refreshDGV();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView2.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells["id"].Value.ToString());
                    string name = txtTenPhim.Text;
                    string theloai = cbbtheloai.Text;
                    int thoiluong = Convert.ToInt32(txtthoiluong.Text);
                    string mota = txtmota.Text;
                    controller.UpdatePhim(id, name, theloai, thoiluong, mota);
                    refreshDGV();
                    MessageBox.Show("Sửa thành công");
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("Error " + fex.Message);
                }
            }
            else MessageBox.Show("Chọn dòng muốn cập nhật");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                controller.DeletePhim(id);
                refreshDGV();
                MessageBox.Show("Xóa thành công!");
            }
            else MessageBox.Show("Chọn dòng muốn xóa");

        }
        public void refreshDGV()
        {
            dataGridView2.DataSource = controller.GetAllPhim();
            dataGridView2.Columns[0].HeaderText = "Mã phim";
            dataGridView2.Columns[1].HeaderText = "Tên phim";
            dataGridView2.Columns[2].HeaderText = "Thể loại";
            dataGridView2.Columns[3].HeaderText = "Thời lượng";
            dataGridView2.Columns[4].HeaderText = "Mô tả";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dataGridView2.Rows[e.RowIndex];
                selectedrow.Selected = true;
                txtMaPhim.Text = selectedrow.Cells[0].Value.ToString();
                txtTenPhim.Text = selectedrow.Cells[1].Value.ToString();
                cbbtheloai.Text = selectedrow.Cells[2].Value.ToString();
                txtthoiluong.Text = selectedrow.Cells[3].Value.ToString();
                txtmota.Text = selectedrow.Cells[4].Value.ToString();
            }
        }

        public void Search(String name)
        {
            dataGridView2.DataSource = controller.GetAllPhim(name);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            TimKiemTheoTen timkiem = new TimKiemTheoTen();
            timkiem.d = new TimKiemTheoTen.MyDel(Search);
            timkiem.ShowDialog();
        }


    }
}
