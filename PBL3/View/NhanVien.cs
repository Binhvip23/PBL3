using PBL3.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class NhanVien : Form
    {
        PhongChieuController controller;

        public NhanVien()
        {
            controller = new PhongChieuController();
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }
        public void RefreshDGV()
        {
            dataGridView1.DataSource = controller.getAllPhongChieu();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow select = dataGridView1.Rows[e.RowIndex];
                select.Selected = true;
                string name = select.Cells[1].Value.ToString();
                Banve bv = new Banve();
                bv.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banve bv = new Banve();
            bv.Show();
        }
    }
}