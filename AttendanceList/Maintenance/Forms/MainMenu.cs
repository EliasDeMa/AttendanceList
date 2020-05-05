using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModel;

namespace Maintenance
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AttendanceListContext())
            {
                var courseInfo = context.CourseInfoes;
                foreach (var item in courseInfo)
                {
                    coursesListBox.Items.Add(item);
                }
            }
        }

        private void courseInfoButton_Click(object sender, EventArgs e)
        {
            if (coursesListBox.SelectedIndex == -1)
            {
                mainErrorProvider.SetError(courseInfoButton, "Must have item selected before clicking button");
            }
            else
            {
                mainErrorProvider.SetError(attendersButton, "");
                var currentSelectedCourse = ((CourseInfo)coursesListBox.SelectedItem).Id;
                var courseInfoForm = new CourseInfoForm(currentSelectedCourse);

                courseInfoForm.Show();
            }

        }

        private void attendersButton_Click(object sender, EventArgs e)
        {
            if (coursesListBox.SelectedIndex == -1)
            {
                mainErrorProvider.SetError(attendersButton, "Must have item selected before clicking button");
            }
            else
            {
                mainErrorProvider.SetError(attendersButton, "");
                var currentSelectedCourse = ((CourseInfo)coursesListBox.SelectedItem).Id;
                using (var courseInfoForm = new AttendersForm(currentSelectedCourse))
                {
                    courseInfoForm.ShowDialog();

                }

            }
        }
    }
}
