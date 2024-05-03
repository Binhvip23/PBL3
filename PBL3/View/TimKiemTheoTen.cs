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
    public partial class TimKiemTheoTen : Form
    {
        public delegate void MyDel(string name);
        public MyDel d { get; set; }
        public TimKiemTheoTen()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(Tentxt.Text != null)
            {
                d(Tentxt.Text);
                MessageBox.Show("Tìm kiếm thành công! ");
            }
            this.Close();
        }
    }
}
