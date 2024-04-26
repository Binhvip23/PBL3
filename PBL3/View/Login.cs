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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string tkql = "admin";
        private string mkql = "admin";

        private string tknv = "nv";
        private string mknv = "nv";

        private void Dang_Nhap_Click(object sender, EventArgs e)
        {
            if (DNhap.Text == tkql && MKhau.Text == mkql)
            {
                QuanLy ql = new QuanLy();
                ql.Show();
                this.Close();
            }
            else if (DNhap.Text == tknv && MKhau.Text == mknv)
            {
                NhanVien nv = new NhanVien();
                nv.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ban can nhap lai");
            }

        }
    }


}
