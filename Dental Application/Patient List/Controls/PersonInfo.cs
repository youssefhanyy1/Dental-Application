using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Application.Patient_List.Controls
{
    public partial class PersonInfo : UserControl
    {
        public PersonInfo()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PersonInfo_Load(object sender, EventArgs e)
        {
            label15.Text = Convert.ToString(guna2CircleProgressBar1.Value+"%");
            label18.Text = Convert.ToString(guna2ProgressBar2.Value+"%");
            label19.Text = Convert.ToString(guna2ProgressBar1.Value+"%");
            label21.Text = Convert.ToString(guna2ProgressBar3.Value + "%");
            label23.Text = Convert.ToString(guna2ProgressBar4.Value + "%");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
