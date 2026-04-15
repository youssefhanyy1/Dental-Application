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
    public partial class DayCellcs : UserControl
    {
        public DayCellcs()
        {
            InitializeComponent();
          //  this.Size = new Size(120, 100);
        }
        public void SetDayNumber(int num)
        {
            lblDayNumber.Text = num.ToString();
        }

        // دالة لإضافة ميعاد جوه اليوم
        public void AddEvent(string eventName, Color eventColor)
        {
            Guna.UI2.WinForms.Guna2Button btnEvent = new Guna.UI2.WinForms.Guna2Button();
            btnEvent.Text = eventName;
            btnEvent.FillColor = eventColor;
            btnEvent.ForeColor = Color.White;

            // التعديل هنا: عرض الزرار بياخد عرض مساحة الأحداث ناقص مسافة صغيرة عشان الـ Margins
            btnEvent.Width = flpEvents.Width - 8;
            btnEvent.Height = 25;

            btnEvent.BorderRadius = 8; // حواف دائرية
            btnEvent.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            btnEvent.Margin = new Padding(2);

            // لو النص طويل، نخليه ينتهي بنقاط بدل ما يتقص بشكل عشوائي
            btnEvent.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            flpEvents.Controls.Add(btnEvent);
        }
        private void DayCellcs_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDayNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
