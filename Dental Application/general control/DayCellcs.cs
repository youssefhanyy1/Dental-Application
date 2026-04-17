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
        // ضيف الدالة دي جوه كلاس DayCellcs
        public void MarkAsToday()
        {
            // تغيير لون خلفية المربع الأساسي
            this.BackColor = Color.FromArgb(228, 241, 254); // أزرق فاتح جداً

            // اختياري: لو حابب تخلي رقم اليوم نفسه (Label) لونه مميز (مثلاً أزرق غامق بدل الأسود)
            lblDayNumber.ForeColor = Color.FromArgb(41, 128, 185);

            // اختياري: لو حابب تخلي رقم اليوم Bold عشان يبرز أكتر
            lblDayNumber.Font = new Font(lblDayNumber.Font, FontStyle.Bold);
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
