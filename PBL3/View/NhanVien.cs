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
        public NhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
/*            PhongChieu pc = new PhongChieu();
            pc.del = new PhongChieu.Mydel(RefreshDGV);
            pc.Show();
            pc.Dispose();*/

            LichChieu lc = new LichChieu();
            lc.del = new LichChieu.Mydel(RefreshDGV);
            lc.Show();
            lc.Dispose();
        }
        public void RefreshDGV(DataGridView dataGridView)
        {
            dataGridView1.DataSource = dataGridView.DataSource;
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
    }
}