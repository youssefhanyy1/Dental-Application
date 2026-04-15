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

            guna2Button1.BackColor = Color.FromArgb(18, 83, 251);
            guna2Button1.ForeColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ResetAllButtons(); 

            label3.Text = "Dashboard";
            guna2PictureBox3.Image = Properties.Resources.dashboard__1_;

            guna2Button1.BackColor = Color.FromArgb(18, 83, 251);
            guna2Button1.ForeColor = Color.White; 

            container(new Dashboard());
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ResetAllButtons();

            label3.Text = "Patient";
            guna2PictureBox3.Image = Properties.Resources.medical_record__1_;

            guna2Button3.BackColor = Color.FromArgb(18, 83, 251);
            guna2Button3.ForeColor = Color.White;

            container(new Patient());
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

        private void ResetAllButtons()
        {
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.ForeColor = Color.Black;

            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.ForeColor = Color.Black;

            guna2Button3.BackColor = Color.Transparent;
            guna2Button3.ForeColor = Color.Black;

            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.ForeColor = Color.Black;
        }

        private void guna2Panel2_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ResetAllButtons();

            label3.Text = "Calendar";
            guna2PictureBox3.Image = Properties.Resources.calendar__1_;

            guna2Button2.BackColor = Color.FromArgb(18, 83, 251);
            guna2Button2.ForeColor = Color.White;

            container(new Calendar());

        }

  
    }
}