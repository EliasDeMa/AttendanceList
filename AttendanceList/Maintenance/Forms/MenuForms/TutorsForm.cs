using DatabaseModel;
using Maintenance.Forms.EditingForms;
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
    public partial class TutorsForm : Form
    {
        private List<Tutor> tutors;
        private readonly int _id;
        public TutorsForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void TutorsForm_Load(object sender, EventArgs e)
        {
            LoadData(_id);
        }

        private void LoadData(int id)
        {
            using (var context = new AttendanceListContext())
            {
                tutors = context.CourseTutors.Where(x => x.CourseId == id)
                                       .Select(x => x.Tutor)
                                       .ToList();
            }

            tutorsListBox.Items.Clear();
            tutorsListBox.Items.AddRange(tutors.ToArray());
        }

        private void addTutorButton_Click(object sender, EventArgs e)
        {
            using (var addTutor = new AddTutorForm())
            {
                var result = addTutor.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var tutor = addTutor.Result;

                    using (var context = new AttendanceListContext())
                    {
                        tutor = context.Tutors.Add(new Tutor()
                        {
                            Name = tutor.Name,
                            Company = tutor.Company,
                        });

                        context.SaveChanges();
                    }

                    using (var context = new AttendanceListContext())
                    {
                        int attId = context.Tutors.Where(x => x.Id == tutor.Id)
                            .Select(x => x.Id)
                            .First();

                        context.CourseTutors.Add(new CourseTutor()
                        {
                            TutorId = attId,
                            CourseId = _id,
                        });

                        context.SaveChanges();
                    }

                    LoadData(_id);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tutorsListBox.SelectedIndex == -1)
            {
                tutorErrorProvider.SetError(deleteButton, "Must select item to delete");
            }
            else
            {
                var tutor = (Tutor)tutorsListBox.SelectedItem;

                var result = MessageBox.Show("Are you sure you want to delete this item", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var context = new AttendanceListContext())
                    {
                        var toDeleteCourseConnection = context.CourseTutors.First(x => x.TutorId == tutor.Id);
                        context.CourseTutors.Remove(toDeleteCourseConnection);

                        var toDelete = context.Tutors.FirstOrDefault(a => a.Id == tutor.Id);
                        context.Tutors.Remove(toDelete);

                        context.SaveChanges();
                    }
                }

                LoadData(_id);
            }
        }
    }
}
