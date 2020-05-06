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
                button.Name = $"Id{item.Id}Button";
                button.Text = "Badge In";
                button.Location = new Point(box.Width / 2 - button.Width / 2, box.Height - button.Height - 5);
                button.Anchor = AnchorStyles.None;
                button.Click += BadgeInClick;
                var label = new Label() {
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
                int id = Int32.Parse(button.Name[2].ToString());
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
