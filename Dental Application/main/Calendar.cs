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
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            // إعدادات الحاوية لضمان عدم وجود مسافات داخلية تعطل الترتيب
            pnlCalendarGrid.Padding = new Padding(0);
            pnlCalendarGrid.Margin = new Padding(0);

            LoadCalendar();
        }

        private void LoadCalendar()
        {
            // 1. تنظيف الشبكة والقائمة الجانبية من أي بيانات قديمة
            pnlCalendarGrid.Controls.Clear();
            flpSidebarEvents.Controls.Clear();

            // 2. الحصول على الشهر والسنة الحاليين
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // 3. تحديث عناوين الشهر والسنة بره اللوب عشان الأداء
            label8.Text = DateTime.Now.ToString("MMMM");
            label9.Text = currentYear.ToString();

            // 4. حساب أول يوم في الشهر (عشان الفراغات)
            DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
            int startDayOfWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek);

            // 5. عدد أيام الشهر الحالي
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            // 6. هنجيب مقاس الـ DayCellcs الفعلي من التصميم بتاعك
            DayCellcs dummyCell = new DayCellcs();
            int actualCellWidth = dummyCell.Width;
            int actualCellHeight = dummyCell.Height;

            // إجبار الحاوية إنها تاخد مساحة 7 مربعات بالظبط بناءً على مقاس المربع بتاعك
            pnlCalendarGrid.Width = actualCellWidth * 7;

            // 7. إضافة المربعات الشفافة للأيام اللي قبل بداية الشهر
            for (int i = 0; i < startDayOfWeek; i++)
            {
                Panel emptyBox = new Panel();

                emptyBox.Size = new Size(actualCellWidth, actualCellHeight);
                emptyBox.BackColor = Color.Transparent;
                emptyBox.Margin = new Padding(0);
                emptyBox.Padding = new Padding(0);

                pnlCalendarGrid.Controls.Add(emptyBox);
            }

            // 8. إضافة مربعات الأيام الفعلية
            for (int i = 1; i <= daysInMonth; i++)
            {
                DayCellcs dayCell = new DayCellcs();
                dayCell.SetDayNumber(i);
                dayCell.Margin = new Padding(0);

                // 💡 [التعديل الجديد: استدعاء دالة التلوين لليوم الحالي] 💡
                if (currentYear == DateTime.Now.Year && currentMonth == DateTime.Now.Month && i == DateTime.Now.Day)
                {
                    // استدعاء الدالة الموجودة داخل الـ DayCellcs
                    dayCell.MarkAsToday();
                }

                // بيانات تجريبية مؤقتة 
                if (i == 9)
                {
                    dayCell.AddEvent("Corporate", Color.MediumPurple);
                    AddSidebarEvent("09", "EVENT ONE", "Tuesday, 9 April, 2026\n9:00 AM", "Corporate Meeting", Color.MediumPurple);
                }
                else if (i == 11)
                {
                    dayCell.AddEvent("Business", Color.MediumTurquoise);
                    AddSidebarEvent("11", "EVENT TWO", "Thursday, 11 April, 2026\n10:00 AM", "Business Meeting", Color.MediumTurquoise);
                }
                else if (i == 17)
                {
                    dayCell.AddEvent("Project Mtg", Color.DeepPink);
                    AddSidebarEvent("17", "EVENT THREE", "Wednesday, 17 April, 2026\n11:00 AM", "Project Meeting", Color.DeepPink);
                }

                pnlCalendarGrid.Controls.Add(dayCell);
            }
        }

        private void AddSidebarEvent(string dayNumber, string eventTitle, string eventTime, string eventType, Color eventColor)
        {
            // 1. إنشاء الحاوية الأساسية (الكارت)
            Guna.UI2.WinForms.Guna2Panel pnlEventCard = new Guna.UI2.WinForms.Guna2Panel();
            pnlEventCard.Width = flpSidebarEvents.Width - 15;
            pnlEventCard.Height = 85;
            pnlEventCard.BorderRadius = 12;
            pnlEventCard.FillColor = eventColor;
            pnlEventCard.Margin = new Padding(5, 5, 5, 10);

            // 2. إنشاء رقم اليوم
            Label lblDay = new Label();
            lblDay.Text = dayNumber;
            lblDay.Font = new Font("Segoe UI Black", 26, FontStyle.Bold);
            lblDay.ForeColor = Color.White;
            lblDay.BackColor = Color.Transparent;
            lblDay.AutoSize = true;
            lblDay.Location = new Point(10, 15);

            // 3. إنشاء تفاصيل الميعاد
            Label lblDetails = new Label();
            lblDetails.Text = $"{eventTitle}\n{eventTime}\n{eventType}";
            lblDetails.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            lblDetails.ForeColor = Color.WhiteSmoke;
            lblDetails.BackColor = Color.Transparent;
            lblDetails.AutoSize = false;
            lblDetails.Location = new Point(75, 15);
            lblDetails.Width = pnlEventCard.Width - 75 - 10;
            lblDetails.Height = 65;

            // 4. إضافة النصوص جوه الكارت
            pnlEventCard.Controls.Add(lblDay);
            pnlEventCard.Controls.Add(lblDetails);

            // 5. إضافة الكارت بالكامل للقائمة الجانبية
            flpSidebarEvents.Controls.Add(pnlEventCard);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }
}