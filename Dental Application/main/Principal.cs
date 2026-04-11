using Dental_Application.loadingFloder;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Application.main
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            container(new Dashboard());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Dashboard";
            guna2PictureBox3.Image = Properties.Resources.dashboard__1_;
            container(new Dashboard());
        }
        private void container(object _form)
        {

            if (guna2Panel2_control.Controls.Count > 0)
            {
                guna2Panel2_control.Controls.Clear();
            }

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel2_control.Controls.Add(fm);
            guna2Panel2_control.Tag = fm;
            fm.Show();

        }
        private void guna2Panel2_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_control_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
