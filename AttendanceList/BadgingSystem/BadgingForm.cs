using DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadgingSystem
{
    public partial class BadgingForm : Form
    {
        private readonly List<CourseInfo> courses;
        private CourseInfo selectedCourse;
        private List<Attender> attenders;
        private DateTime beforeAfternoon = new DateTime(
            DateTime.Now.Year,
            DateTime.Now.Month,
            DateTime.Now.Day,
            13,
            0,
            0
        );
        private DateTime afterMorning = new DateTime(
            DateTime.Now.Year,
            DateTime.Now.Month,
            DateTime.Now.Day,
            12,
            0,
            0
        );

        public BadgingForm()
        {
            InitializeComponent();
            using (var context = new AttendanceListContext())
            {
                courses = context.CourseInfoes.ToList();
            }
        }

        private void timeShowTimer_Tick(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString();
            coursesComboBox.Items.AddRange(courses.ToArray());
        }

        private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCourse = (CourseInfo)coursesComboBox.SelectedItem;
            List<NonCourseDay> daysOff;
            using (var context = new AttendanceListContext())
            {
                daysOff = context.NonCourseDays
                    .Where(x => x.CourseId == selectedCourse.Id).ToList();
            }

            var dayOff = daysOff.Where(x => x.Date.Value.Date == DateTime.Now.Date).FirstOrDefault();


            if (dayOff == default)
                LoadItems(selectedCourse);
            else if (dayOff.Morning.Value && dayOff.Afternoon.Value)
                MessageBox.Show("This course has no class today", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (dayOff.Morning.Value && DateTime.Now < beforeAfternoon)
                MessageBox.Show("This course has no class in the morning today", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (dayOff.Afternoon.Value && DateTime.Now > afterMorning)
                MessageBox.Show("This course has no class in the afternoon today", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                LoadItems(selectedCourse);   
        }

        private void LoadItems(CourseInfo selectedCourse)
        {

            using (var context = new AttendanceListContext())
            {
                attenders = context.CourseAttenders.Where(c => c.CourseId == selectedCourse.Id)
                    .Select(ca => ca.Attender)
                    .ToList();
            }

            trainingInstitutionTextBox.Text = selectedCourse.TrainingInstitution;
            courseTextBox.Text = selectedCourse.Course;
            contactTextBox.Text = selectedCourse.ContactPerson;
            addressTextBox.Text = selectedCourse.Address;
            addressRefTextBox.Text = selectedCourse.ReferenceAddress;
            oeNumberTextBox.Text = selectedCourse.OeNumber.ToString();
            ccTextBox.Text = selectedCourse.CourseCode.ToString();


            foreach (var item in attenders)
            {
                var box = new GroupBox();
                var button = new Button();
                button.Name = $"IdButton{item.Id}";
                button.Text = "Badge In";
                button.Location = new Point(box.Width / 2 - button.Width / 2, box.Height - button.Height - 5);
                button.Anchor = AnchorStyles.None;
                button.Click += BadgeInClick;
                var label = new Label()
                {
                    Text = item.Name,
                    Anchor = AnchorStyles.None,
                    Font = new Font(FontFamily.GenericSansSerif, 9),
                    TextAlign = ContentAlignment.TopCenter,
                    Size = new Size(box.Width - 2, 18),
                };
                label.Location = new Point(1, 20);
                box.Controls.Add(label);
                box.Controls.Add(button);

                attendersLayoutPanel.Controls.Add(box);
            }
        }

        private void BadgeInClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "Badge In")
            {
                int id = Int32.Parse(button.Name.Replace("IdButton", ""));
                Console.WriteLine(id);
                using (var context = new AttendanceListContext())
                {
                    context.RegistrationTimes.Add(new RegistrationTime()
                    {
                        AttenderId = id,
                        CourseId = selectedCourse.Id,
                        DateTime = DateTime.Now
                    });

                    context.SaveChanges();
                }

                button.Text = "Badge Out";
            }
            else
            {
                button.Text = "Badge In";
            }
        }
    }
}
