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
    public partial class GheNgoi1 : Form
    {
        List<Button> DanhSachChon = new List<Button>();
        int intTongTien = 0;
        public GheNgoi1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.BackColor != Color.Yellow)
            {
                if (bt.BackColor == Color.White)
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
            string[] DayGheA = { "A1", "A2", "A3", "A4", "A5", "A6" };
            string[] DayGheB = { "B1", "B2", "B3", "B4", "B5", "B6" };
            string[] DayGheC = { "C1", "C2", "C3", "C4", "C5", "C6" };
            string[] DayGheD = { "D1", "D2", "D3", "D4", "D5", "D6" };
            string[] DayGheE = { "E1", "E2", "E3", "E4", "E5", "E6" };

            foreach (Button b in DanhSachChon)
            {
                string seat = b.Text;
                if (DayGheA.Contains(seat))
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 100000;
                }
                else if (DayGheB.Contains(seat))
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 150000;
                }
                else if (DayGheC.Contains(seat))
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 200000;
                }
                else if (DayGheD.Contains(seat))
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 110000;
                }
                else if (DayGheE.Contains(seat))
                {
                    b.BackColor = Color.Yellow;
                    intTongTien += 90000;
                }
                else
                {
                    MessageBox.Show("Chua co ghe nao duoc chon de thanh toan");
                }
            }
            textBox1.Text = intTongTien.ToString();
            DanhSachChon.Clear();
            intTongTien = 0;
            DanhSachChon = new List<Button>();
        }
    }
}
