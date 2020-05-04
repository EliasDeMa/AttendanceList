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
        private readonly CourseInfo _course;
        private readonly int _id;
        private bool changed;

        public CourseInfoForm(int id)
        {
            InitializeComponent();
            this._id = id;
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

        #region Button Clicks

        private void editTrainingInstButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new EditFieldForm(trainingInstitutionTextBox.Text))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK && _course.TrainingInstitution != dialog.Result)
                {
                    trainingInstitutionTextBox.Text = dialog.Result;
                    _course.TrainingInstitution = dialog.Result;
                    changed = true;
                }
            }
        }

        private void courseEditButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new EditFieldForm(courseTextBox.Text))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK && _course.Course != dialog.Result)
                {
                    courseTextBox.Text = dialog.Result;
                    _course.Course = dialog.Result;
                    changed = true;
                }
            }
        }

        private void contactEditButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new EditFieldForm(contactTextBox.Text))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK && _course.ContactPerson != dialog.Result)
                {
                    contactTextBox.Text = dialog.Result;
                    _course.ContactPerson = dialog.Result;
                    changed = true;
                }
            }
        }

        #endregion

        private void CourseInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                // Show messagebox to be sure user wants save changes
                var result = MessageBox.Show("Do you want to save changes", 
                                             "Save", 
                                             MessageBoxButtons.YesNoCancel);
                
                if (result == DialogResult.Yes)
                {
                    using (var context = new AttendanceListContext())
                    {
                        var info = context.CourseInfoes.First(x => x.Id == _id);

                        context.Entry(info).CurrentValues.SetValues(_course);
                        context.SaveChanges();
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        
    }
}
