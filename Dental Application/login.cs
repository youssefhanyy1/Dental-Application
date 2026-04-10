using Dental_Application.loadingFloder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Application
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void ExitPIC_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form _loading = new Loading();
            _loading.Show();


        }
    }
}
