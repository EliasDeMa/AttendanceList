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

namespace Maintenance.Forms.MenuForms
{
    public partial class RegistrationInfoForm : Form
    {
        private int _id;

        public RegistrationInfoForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void RegistrationInfoForm_Load(object sender, EventArgs e)
        {
            using (var context = new AttendanceListContext())
            {
                var dbRegistration = context.RegistrationTimes.Include("Attender")
                    .Include("CourseInfo")
                    .Where(x => x.Id == _id)
                    .First();

                nameTextBox.Text = dbRegistration.Attender.Name;
                timeTextBox.Text = dbRegistration.DateTime.Value.ToString();
                courseTextBox.Text = dbRegistration.CourseInfo.Course;
            }
        }
    }
}
