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
    public partial class AttendersForm : Form
    {
        private List<Attender> attenders;
        private readonly int _id;

        public AttendersForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void AttendersForm_Load(object sender, EventArgs e)
        {
            LoadData(_id);
        }

        private void addAttenderButton_Click(object sender, EventArgs e)
        {
            using (var addAttender = new AddAttenderForm())
            {
                var result = addAttender.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int badge = 1;
                    var attender = addAttender.Result;

                    while (attenders.Where(x => x.BadgeNumber == badge).Any())
                        badge++;

                    using (var context = new AttendanceListContext())
                    {
                        context.Attenders.Add(new Attender()
                        {
                            Name = attender.Name,
                            Address = attender.Address,
                            Birthdate = attender.Birthdate,
                            BadgeNumber = badge
                        });

                        context.SaveChanges();
                    }

                    using (var context = new AttendanceListContext())
                    {
                        int attId = context.Attenders.Where(x => x.BadgeNumber == badge)
                            .Select(x => x.Id)
                            .First();
                        context.CourseAttenders.Add(new CourseAttender()
                        {
                            AttenderId = attId,
                            CourseId = _id,
                        });

                        context.SaveChanges();
                    }

                    LoadData(_id);
                }
            }
        }

        void LoadData(int id)
        {

            using (var context = new AttendanceListContext())
            {
                attenders = context.CourseAttenders.Where(x => x.CourseId == id)
                                       .Select(x => x.Attender)
                                       .ToList();
            }

            attendersListBox.Items.Clear();
            attendersListBox.Items.AddRange(attenders.ToArray());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (attendersListBox.SelectedIndex == -1)
            {
                attendersErrorProvider.SetError(deleteButton, "Must select item to delete");
            }
            else
            {
                var attender = (Attender)attendersListBox.SelectedItem;

                var result = MessageBox.Show("Are you sure you want to delete this item", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var context = new AttendanceListContext())
                    {
                        var toDeleteCourseConnection = context.CourseAttenders.First(x => x.AttenderId == attender.Id);
                        context.CourseAttenders.Remove(toDeleteCourseConnection);

                        var registrationToDelete = context.RegistrationTimes.Where(x => x.AttenderId == attender.Id).ToList();
                        foreach (var item in registrationToDelete)
                            context.RegistrationTimes.Remove(item);

                        var toDelete = context.Attenders.FirstOrDefault(a => a.Id == attender.Id);
                        context.Attenders.Remove(toDelete);

                        context.SaveChanges();
                    }
                }

                LoadData(_id);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (attendersListBox.SelectedIndex == -1)
            {
                attendersErrorProvider.SetError(editButton, "Must select item to edit");
            }
            else
            {
                using (var dialog = new EditAttenderForm((Attender)attendersListBox.SelectedItem))
                {
                    var result = dialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        var attenderToEdit = dialog.Result;

                        using (var context = new AttendanceListContext())
                        {
                            var a = context.Attenders.Where(c => c.Id == attenderToEdit.Id).First();

                            a.Name = attenderToEdit.Name;
                            a.Address = attenderToEdit.Address;
                            a.Birthdate = attenderToEdit.Birthdate;

                            context.SaveChanges();
                        }
                    }
                }

                LoadData(_id);
            }
        }
    }
}
