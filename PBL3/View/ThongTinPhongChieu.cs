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
    public partial class ThongTinPhongChieu : Form
    {
        public delegate void MyDel(int i1, string s1, int i2, string s2);
        public MyDel function { get; set; }
        public ThongTinPhongChieu()
        {
            InitializeComponent();
        }
        public ThongTinPhongChieu(string s)
        {
            InitializeComponent();
            txtid.Text = s;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtten.Text;
                int size = Convert.ToInt32(txtsize.Text);
                string mota = txtdisc.Text;
                function(id, name, size, mota);
                Close();
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Error " + fex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
