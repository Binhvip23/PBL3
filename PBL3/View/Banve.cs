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
        LichChieuController controller;
        public Banve()
        {
            controller = LichChieuController.Instance;
            InitializeComponent();
            refreshDGV(Phimcbb.Text,DTChieu.Text);
            SetCBBLC();
        }
        private void refreshDGV(string name,string ngaychieu )
        {
            List<PBL3.Model.LichChieu> lc=new List<PBL3.Model.LichChieu>();
            foreach(PBL3.Model.LichChieu lich in controller.GetAllLichChieu(name))
            {
                if(lich.TenPhim.Contains(name))
                {
                    if (ngaychieu.ToString() == "" || Convert.ToDateTime(ngaychieu).Equals(lich.NgayChieu))
                        lc.Add(lich);
                }
            }
            dataGridView1.DataSource = lc;
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
            openChildForm(new GheNgoics());
            if(DTSearch.Checked)
                refreshDGV(Phimcbb.Text, DTChieu.Text);
            else
            {
                 refreshDGV(Phimcbb.Text, "");
            }
        }
    }
}
