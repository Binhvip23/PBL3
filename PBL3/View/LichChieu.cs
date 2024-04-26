using PBL3.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class LichChieu : Form
    {
        private LichChieuController controller;
        public LichChieu()
        {
            InitializeComponent();
            controller = new LichChieuController();
            RefreshDGV();
            setCbbTen();
            setCbbNVQL();
        }
        public void RefreshDGV()
        {
            dataGridView1.DataSource = controller.GetAllLichChieu();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên phim";
            dataGridView1.Columns[2].HeaderText = "Ngày chiếu";
            dataGridView1.Columns[3].HeaderText = "Giờ chiếu";
            dataGridView1.Columns[4].HeaderText = "Nhân viên quản lý";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(IDtxt.Text);
                string name = cbbTenPhim.Text;
                DateTime date = Convert.ToDateTime(cbbDate.Text);
                int time = Convert.ToInt32(Timetxt.Text);
                string NVQL = cbbNVQL.Text;
                controller.AddLichChieu(id, name, date, time, NVQL);
                MessageBox.Show("Thêm thành công!");
                RefreshDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error form" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedrow.Cells["ID"].Value.ToString());
                controller.DeleteLichChieu(id);
                MessageBox.Show("Xóa thành công!");
                RefreshDGV();
            }
            else MessageBox.Show("Chọn dòng muốn xóa");
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString());
                    string name = cbbTenPhim.Text;
                    DateTime date = Convert.ToDateTime(cbbDate.Text);
                    int time = Convert.ToInt32(Timetxt.Text);
                    string NVQL = cbbNVQL.Text;
                    controller.UpdateLichChieu(id, name, date, time, NVQL);
                    MessageBox.Show("Sửa thành công!");
                    RefreshDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error form" + ex.Message);
                }
            }
            else MessageBox.Show("Chọn dòng muốn cập nhật");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dataGridView1.Rows[e.RowIndex];
                IDtxt.Text = selectedrow.Cells[0].Value.ToString();
                cbbTenPhim.Text = selectedrow.Cells[1].Value.ToString();
                cbbDate.Text = selectedrow.Cells[2].Value.ToString();
                Timetxt.Text = selectedrow.Cells[3].Value.ToString();
                cbbNVQL.Text = selectedrow.Cells[4].Value.ToString();
            }
        }
        private void setCbbTen()
        {
            List<string> list = new List<string>();
            foreach (Model.LichChieu lich in controller.GetAllLichChieu())
            {
                list.Add(lich.Phim.ToString());
            }
            cbbTenPhim.Items.AddRange(list.Distinct().ToArray());
        }
        public void setCbbNVQL()
        {
            List<string> list = new List<string>();
            foreach (Model.LichChieu lich in controller.GetAllLichChieu())
            {
                list.Add(lich.NVQL.ToString());
            }
            cbbNVQL.Items.AddRange(list.Distinct().ToArray());
        }
    }
}
