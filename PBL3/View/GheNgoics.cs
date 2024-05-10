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
    public partial class GheNgoics : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int intTongTien = 0;

        private string Pheptoan;
        public GheNgoics()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if(bt.BackColor != Color.Yellow)
            {
                if(bt.BackColor == Color.White)
                {
                    bt.BackColor = Color.Blue;
                    DanhSachChon.Add(bt);
                }
                else
                {
                    bt.BackColor = Color.White;
                    DanhSachChon.Remove(bt);
                }
            }
            else
            {
                MessageBox.Show("Co nguoi chon ");
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            foreach(Button b in DanhSachChon)
            {
                int a = int.Parse(b.Text);
                if(a <= 20)
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 1000;
                }
            }
            textBox1.Text = intTongTien.ToString();
            intTongTien = 0;
            DanhSachChon = new List<Button>();
        }
    }
}
