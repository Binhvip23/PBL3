using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using PBL3.Controller;
using PBL3.Model;
using PBL3.Model.DAO;

namespace PBL3.View
{
    public partial class PhongChieu : Form
    {
        private PhongChieuController controller;
        private int idLichChieu;
        private int idPhongChieu;
        public PhongChieu(int id = 0)
        {
            InitializeComponent();
            controller = PhongChieuController.Instance;
            idLichChieu = id;
            RefreshDGV();
            if(idLichChieu!=0)
            {
                cbchange.Visible = true;
                btSua.Enabled = false;
                btSua.BackColor = Color.Gray;
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                dataGridView1.CellDoubleClick-= dataGridView1_CellContentDoubleClick;
            }

        }
        public void RefreshDGV(string search="")
        {
            List<PBL3.Model.PhongChieu> list =new List<PBL3.Model.PhongChieu>();
            if (idLichChieu == 0 || cbchange.Checked)
            {
                foreach (PBL3.Model.PhongChieu pc in controller.GetAllPhongChieu())
                {
                    if (pc.Name.Contains(search))  list.Add(pc);
                }
            }
            else
            {
                foreach(PBL3.Model.PhongChieu pc in controller.GetAllPhongChieuPhim(idLichChieu))
                {
                    if (pc.Name.Contains(search))  list.Add(pc);
                }
            }
            if (!list.IsNullOrEmpty())
            {
                dataGridView1.DataSource= list;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Tên phòng chiếu";
                dataGridView1.Columns[2].HeaderText = "Sức chứa";
                dataGridView1.Columns[3].HeaderText = "Mô tả";
            }
            else MessageBox.Show("Hiện không có lịch chiếu trong phòng này!");
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(idLichChieu==0)
            {
                ThongTinPhongChieu form = new ThongTinPhongChieu();
                form.function = new ThongTinPhongChieu.MyDel(AddInformation);
                form.Show();
            }
            else if(idLichChieu!=0)
            {
                if(idPhongChieu!=0)
                {
                    controller.ThemPhongChieuPhim(idLichChieu, idPhongChieu);
                    MessageBox.Show("Thêm thành công!");
                }
                else MessageBox.Show("Chọn phòng chiếu muốn thêm");
            }
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
                if(idLichChieu==0)
                {
                    controller.DeletePhongChieu(id);
                    RefreshDGV();
                }
                else if(idLichChieu!=0)
                {
                    controller.XoaPhongChieuPhim(idLichChieu, id);
                    RefreshDGV();
                }
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
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow select = dataGridView1.Rows[e.RowIndex];
                select.Selected = true;
                int id = Convert.ToInt32(select.Cells[0].Value.ToString());
                MessageBox.Show("Danh sách lịch chiếu của phòng chiếu " + id + " :");
                LichChieu lc = new LichChieu(id);
                lc.Show();
            }
        }
        

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            bool trangthai=true ;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Id")
            {
                dataGridView1.DataSource=  controller.sortByID(); // Gọi phương thức sortByID() của controller
                // Refresh DataGridView sau khi sắp xếp
                MessageBox.Show("Cập nhật thành công");
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Name")
            {
                dataGridView1.DataSource = controller.sortByName(trangthai);
                MessageBox.Show("Cập nhật thành công");
            }    
        }

        private bool sucChuaTangDan = true;

        private void dataGridView1_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "SucChua")
            {
                sucChuaTangDan = !sucChuaTangDan; // Đảo ngược trạng thái sắp xếp
                dataGridView1.DataSource = controller.sortBysucchua(sucChuaTangDan);
                // Refresh DataGridView sau khi sắp xếp
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void cbchange_CheckedChanged(object sender, EventArgs e)
        {
            if(cbchange.Checked)
            {
                btThem.Enabled = true;
                btThem.BackColor = Color.DarkRed;
                btXoa.Enabled = false;
                btXoa.BackColor = Color.Gray;
                RefreshDGV();
                MessageBox.Show("Hãy chọn phòng chiếu muốn thêm lịch chiếu");
            }
            else
            {
                btXoa.Enabled = true;
                btXoa.BackColor = Color.DarkRed;
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                RefreshDGV();
                MessageBox.Show("Đã tắt chế độ thêm phòng vào lịch");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow selectedrow= dataGridView1.Rows[e.RowIndex];
                selectedrow.Selected = true;
                idPhongChieu= Convert.ToInt32(selectedrow.Cells[0].Value.ToString());
            }
        }
    }
}
