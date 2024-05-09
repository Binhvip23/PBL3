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

        public Banve()
        {
            InitializeComponent();
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

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            openChildForm(new GheNgoics());
        }
    }
}
