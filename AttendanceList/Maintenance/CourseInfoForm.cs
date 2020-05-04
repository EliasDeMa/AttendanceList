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

namespace Maintenance
{
    public partial class CourseInfoForm : Form
    {
        private CourseInfo _course;

        public CourseInfoForm(int id)
        {
            InitializeComponent();
            using (var context = new AttendanceListContext())
            {
                _course = context.CourseInfoes.First(x => x.Id == id);
            }
        }

        private void CourseInfoForm_Load(object sender, EventArgs e)
        {
            trainingInstitutionTextBox.Text = _course.TrainingInstitution;
            courseTextBox.Text = _course.Course;
            contactTextBox.Text = _course.ContactPerson;
            addressTextBox.Text = _course.Address;
            refAddressTextBox.Text = _course.ReferenceAddress;
            oeNumberTextBox.Text = _course.OeNumber.ToString();
            courseCodeTextBox.Text = _course.CourseCode.ToString();
        }
    }
}
