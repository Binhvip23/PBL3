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
    public partial class ThongtinNhanVienQuanLy : Form
    {

        NhanVienQuanLyController controller;
        public ThongtinNhanVienQuanLy()
        {
            InitializeComponent();
        }
        /*set the header of the DataGridView to vietnamese*/
        string[] header = { "Tên đăng nhập", "Trạng thái", "ID", "Tên", "Số điện thoại", "Email", "Vai trò" };
        private void ThongtinNhanVien_Load(object sender, EventArgs e)
        {
            controller = NhanVienQuanLyController.Instance;

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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            /*delte selected row in the DataTable*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                controller.DeleteNhanVien(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString()));
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            /*Edit the selected row in the DataTable and add a new row with the content of the textboxes*/
            if (dataGridView1.SelectedRows.Count > 0)
            {
                controller.UpdateNhanVien(Convert.ToInt32(Idtxt.Text), Nametxt.Text, Numbertxt.Text, Emailtxt.Text, Rolecbb.Text, Usernametxt.Text, ActiveRdbtn.Checked);
                LoadData();
                MessageBox.Show("Sửa thành công!");
            }

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            /*add a new row to the DataTable*/
            controller.AddNhanVien(Convert.ToInt32(Idtxt.Text), Nametxt.Text, Numbertxt.Text, Emailtxt.Text, Rolecbb.Text, Usernametxt.Text, ActiveRdbtn.Checked);
            LoadData();
            MessageBox.Show("Thêm thành công!");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Idtxt.Text = row.Cells["Id"].Value.ToString();
                Nametxt.Text = row.Cells["FullName"].Value.ToString();
                Numbertxt.Text = row.Cells["SoDT"].Value.ToString();
                Emailtxt.Text = row.Cells["Email"].Value.ToString();
                Rolecbb.Text = row.Cells["Vaitro"].Value.ToString();
                Usernametxt.Text = row.Cells["TaiKhoan"].Value.ToString();
                if (row.Cells["Active"].Value.ToString() == "True")
                {
                    ActiveRdbtn.Checked = true;
                }
                else
                {
                    ActiveRdbtn.Checked = false;
                }
            }
        }
    }

