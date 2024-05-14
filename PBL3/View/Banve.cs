using Microsoft.IdentityModel.Tokens;
using PBL3.Controller;
using PBL3.Model;
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
    public partial class Banve : Form
    {
        public Form currentChildForm;
        private readonly LichChieuController controller;
        private readonly PhongChieuController controllerPC;
        public Banve(string search)
        {
            controller = LichChieuController.Instance;
            controllerPC = PhongChieuController.Instance;
            InitializeComponent();
            Phimcbb.Text = search;
            Phimcbb.Enabled = false;
            refreshDGV(cbbChonPhong.Text,DTChieu.Text);
            SetCBBLC();
            SetccbTimPhong();
        }
        public void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void refreshDGV(string tenPhong ,string ngaychieu )
        {
            int idPhong = controllerPC.GetPhongChieuid(tenPhong);
            List<PBL3.Model.LichChieu> lc=new List<PBL3.Model.LichChieu>();
            foreach(PBL3.Model.LichChieu lich in controller.GetAllLichChieu(Phimcbb.Text))
            {
                if (tenPhong == "")
                {
                    if (!DTSearch.Checked) lc.Add(lich);
                    else if (lich.NgayChieu.ToString()==ngaychieu) lc.Add(lich);
                }
                else 
                {
                    if(!DTSearch.Checked)
                    {
                        if (controller.CheckPhimDangChieu(lich.Id, idPhong)) lc.Add(lich);
                    }
                    else
                    {
                        if (controller.CheckPhimDangChieu(lich.Id, idPhong) && lich.NgayChieu.ToString()==ngaychieu) lc.Add(lich);
                    }
                }
            }
            dataGridView1.DataSource = lc;
        }
        private void SetCBBLC()
        {
            List<string> list=new List<string>();
            Phimcbb.Items.Clear();
            foreach (PBL3.Model.LichChieu lc in controller.GetAllLichChieu())
            {
                list.Add(lc.TenPhim);
            }
            Phimcbb.Items.AddRange(list.Distinct().ToArray());
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if(DTSearch.Checked)
                refreshDGV(cbbChonPhong.Text, DTChieu.Text);
            else
            {
                 refreshDGV(cbbChonPhong.Text, "");
            }
        }

        private void SetccbTimPhong()
        {
            List<string> list = new List<string>();
            cbbChonPhong.Items.Clear();
            foreach (PBL3.Model.PhongChieu pc in controllerPC.GetAllPhongChieu())
            {
                list.Add(pc.Name);
            }
            cbbChonPhong.Items.AddRange(list.Distinct().ToArray());
        }

        private void btTimPhong_Click(object sender, EventArgs e)
        {
            if(cbbChonPhong.Text == "Room1")
            {
                openChildForm(new GheNgoics());
            }
            else if(cbbChonPhong.Text == "Room2")
            {
                openChildForm(new GheNgoi1());
            }
            else
            {
                MessageBox.Show("Khong co phong nao de chon");
            }
            
        }
    }
}
