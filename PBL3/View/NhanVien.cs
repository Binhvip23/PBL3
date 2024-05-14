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

        public NhanVien()
        {
            controller =LichChieuController.Instance;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Banve bv = new Banve(button2.Text);
            bv.Show();
        }

    }
}