﻿using Microsoft.IdentityModel.Tokens;
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
        private int idPhongChieu;
        public LichChieu(int id=0)
        {
            InitializeComponent();
            controller = LichChieuController.Instance;
            idPhongChieu = id;
            RefreshDGV();
            setCbbNVQL();
            setCbbTen();
            if(id!=0)
            {
                //không cho sửa xóa phim.
                IDtxt.Enabled = false;
                cbbTenPhim.Enabled = false;
                Dtchieu.Enabled = false;
                Timetxt.Enabled = false;
                cbbNVQL.Enabled = false;
                //đổi màu các nút không dùng.
                addcb.Visible = true;
                btThem.Enabled = false;
                btThem.BackColor=Color.Gray;
                btSua.Enabled = false;
                btSua.BackColor = Color.Gray;
                dataGridView1.CellDoubleClick-= dataGridView1_CellDoubleClick;
            }
        }
        public void RefreshDGV(string search="")
        {
            List<Model.LichChieu> list = new List<Model.LichChieu>();
            if(idPhongChieu==0 || addcb.Checked)
            {
                foreach (Model.LichChieu ch in controller.GetAllLichChieu())
                {
                    if (ch.TenPhim.Contains(search))
                        list.Add(ch);
                }
            }
            else
            {
                foreach(Model.LichChieu ch in controller.GetPhimDangChieu(idPhongChieu))
                {
                    if (ch.TenPhim.Contains(search))
                        list.Add(ch);
                }
            }
            if (!list.IsNullOrEmpty())
            {
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Tên phim";
                dataGridView1.Columns[2].HeaderText = "Ngày chiếu";
                dataGridView1.Columns[3].HeaderText = "Giờ chiếu";
                dataGridView1.Columns[4].HeaderText = "Nhân viên quản lý";
            }
            else MessageBox.Show("Hiện không có phòng chứa lịch chiếu này!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if(idPhongChieu==0)
            {
                try
                {
                    int id = Convert.ToInt32(IDtxt.Text);
                    string name = cbbTenPhim.Text;
                    DateTime date = Convert.ToDateTime(Dtchieu.Text);
                    int time = Convert.ToInt32(Timetxt.Text);
                    string NVQL = cbbNVQL.Text;
                    controller.AddLichChieu(id, name, date, time, NVQL);
                    MessageBox.Show("Thêm thành công!");
                    RefreshDGV();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nhập sai định dạng dữ liệu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
            else if(addcb.Checked)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedrow.Cells["ID"].Value.ToString());
                    try
                    {
                        controller.ThemPhimDangChieu(id, idPhongChieu);
                        MessageBox.Show("Thêm thành công!");
                        RefreshDGV();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else MessageBox.Show("Chọn dòng muốn thêm");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedrow.Cells["ID"].Value.ToString());
                if (idPhongChieu==0)
                {
                    controller.DeleteLichChieu(id);
                }
                else if(idPhongChieu!=0 && !addcb.Checked)
                {
                    controller.XoaPhimDangChieu(id,idPhongChieu);
                }
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
                    DateTime date = Convert.ToDateTime(Dtchieu.Text);
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
                selectedrow.Selected = true;
                IDtxt.Text = selectedrow.Cells[0].Value.ToString();
                cbbTenPhim.Text = selectedrow.Cells[1].Value.ToString();
                Dtchieu.Text = selectedrow.Cells[2].Value.ToString();
                Timetxt.Text = selectedrow.Cells[3].Value.ToString();
                cbbNVQL.Text = selectedrow.Cells[4].Value.ToString();
            }
        }
        private void setCbbTen()
        {
            List<string> list = new List<string>();
            foreach (Model.LichChieu lich in controller.GetAllLichChieu())
            {
                list.Add(lich.TenPhim);
            }
            cbbTenPhim.Items.AddRange(list.Distinct().ToArray());
        }
        private void setCbbNVQL()
        {
            List<string> list = new List<string>();
            foreach (Model.LichChieu lich in controller.GetAllLichChieu())
            {
                list.Add(lich.TenNVQL);
            }
            cbbNVQL.Items.AddRange(list.Distinct().ToArray());
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedrow = dataGridView1.Rows[e.RowIndex];
                selectedrow.Selected = true;
                int id = Convert.ToInt32(selectedrow.Cells["ID"].Value.ToString());
                View.PhongChieu pc = new View.PhongChieu(id);
                pc.Show();
            }
        }

        private void addcb_CheckedChanged(object sender, EventArgs e)
        {
            if(addcb.Checked)
            {
                RefreshDGV();
                btThem.Enabled = true;
                btThem.BackColor = Color.DarkRed;
                btXoa.Enabled = false;
                btXoa.BackColor = Color.Gray;
                MessageBox.Show("Hãy chọn lịch chiếu muốn thêm vào phòng");
            }
            else
            {
                btThem.Enabled = false;
                btThem.BackColor = Color.Gray;
                btXoa.Enabled = true;
                btXoa.BackColor = Color.DarkRed;
                RefreshDGV();
                MessageBox.Show("Đã tắt chế độ thêm");
            }
        }
    }
}
