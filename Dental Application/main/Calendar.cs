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
            // تنظيف الشبكة من أي أيام قديمة
            pnlCalendarGrid.Controls.Clear();

            // الحصول على الشهر والسنة الحاليين
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            // حساب أول يوم في الشهر (عشان الفراغات)
            DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
            int startDayOfWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek);

            // عدد أيام الشهر الحالي
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            // 💡 [الحل السحري المضمون] 💡
            // هنجيب مقاس الـ DayCellcs الفعلي من التصميم بتاعك عشان منضطرش نخمن الرقم
            DayCellcs dummyCell = new DayCellcs();
            int actualCellWidth = dummyCell.Width;
            int actualCellHeight = dummyCell.Height;

            // إجبار الحاوية إنها تاخد مساحة 7 مربعات بالظبط بناءً على مقاس المربع بتاعك
            pnlCalendarGrid.Width = actualCellWidth * 7;

            // 1. إضافة المربعات الشفافة للأيام اللي قبل بداية الشهر
            for (int i = 0; i < startDayOfWeek; i++)
            {
                Panel emptyBox = new Panel();

                // خلينا مقاس المربع الفاضي يطابق مقاس المربع بتاعك بالمللي أوتوماتيكياً
                emptyBox.Size = new Size(actualCellWidth, actualCellHeight);
                emptyBox.BackColor = Color.Transparent; // لضمان إنها مجرد فراغ
                emptyBox.Margin = new Padding(0); // إزالة المسافة الخارجية
                emptyBox.Padding = new Padding(0); // إزالة المسافة الداخلية

                pnlCalendarGrid.Controls.Add(emptyBox);
            }

            // 2. إضافة مربعات الأيام الفعلية
            for (int i = 1; i <= daysInMonth; i++)
            {
                DayCellcs dayCell = new DayCellcs();
                dayCell.SetDayNumber(i);

                // تصفير الـ Margin تماماً عشان المربعات تلزق في بعضها وتكفي السطر
                dayCell.Margin = new Padding(0);

                // بيانات تجريبية مؤقتة 
                if (i == 9)
                {
                    dayCell.AddEvent("Corporate", Color.MediumPurple);
                }
                else if (i == 11)
                {
                    dayCell.AddEvent("Business", Color.MediumTurquoise);
                }
                else if (i == 17)
                {
                    dayCell.AddEvent("Project Mtg", Color.DeepPink);
                }

                pnlCalendarGrid.Controls.Add(dayCell);

                label8.Text = DateTime.Now.ToString("MMMM");
                label9.Text= Convert.ToString(currentYear);
            }
        }

        


    }
}