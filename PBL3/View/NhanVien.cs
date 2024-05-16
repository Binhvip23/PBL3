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
        LichChieuController controller;
        private readonly PhimController controllerPhim;

        public NhanVien()
        {
            controllerPhim = PhimController.Instance;
            controller =LichChieuController.Instance;
            InitializeComponent();
            setButton();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Banve bv = new Banve(button2.Text);
            bv.Show();
        }

        private void setButton()
        {
            List<String> list = new List<String>();
            foreach(PBL3.Model.Phim phim in controllerPhim.GetAllPhim())
            {
                list.Add(phim.Tenphim);
            }

            button2.Text = list[0];
            button3.Text = list[1];
            button4.Text = list[2];
            button5.Text = list[3];
            button6.Text = list[4];
            button7.Text = list[5];
            button1.Text = list[6];
            button8.Text = list[7];

        }

    }
}