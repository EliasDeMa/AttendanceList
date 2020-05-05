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
    public partial class DaysOffForm : Form
    {
        private List<NonCourseDay> nonCourseDays;
        private readonly int _id;
        public DaysOffForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void DaysOffForm_Load(object sender, EventArgs e)
        {
            LoadData(_id);
        }

        void LoadData(int id)
        {

            using (var context = new AttendanceListContext())
            {
                nonCourseDays = context.NonCourseDays.Where(x => x.CourseId == id)
                                       .Select(x => x)
                                       .ToList();
            }

            daysOffListBox.Items.Clear();
            daysOffListBox.Items.AddRange(nonCourseDays.ToArray());
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (daysOffListBox.SelectedIndex == -1)
            {
                nonCourseDayErrorProvider.SetError(deleteButton, "Must select item to delete");
            }
            else
            {
                nonCourseDayErrorProvider.SetError(deleteButton, "");
                var nonCourseDay = (NonCourseDay)daysOffListBox.SelectedItem;

                var result = MessageBox.Show("Are you sure you want to delete this item", "Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (var context = new AttendanceListContext())
                    {
                        var toDelete = context.NonCourseDays.FirstOrDefault(a => a.Id == nonCourseDay.Id);
                        context.NonCourseDays.Remove(toDelete);

                        context.SaveChanges();
                    }
                }

                LoadData(_id);
            }
        }

        private void addDayOffButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddNonCourseDayForm())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var (range, morning, afternoon) = dialog.Result;

                    var startDate = range.Start;
                    var endDate = range.End;

                    while (startDate <= endDate)
                    {
                        using (var context = new AttendanceListContext())
                        {
                            if (!nonCourseDays.Where(x => x.Date == startDate).Any())
                            {
                                context.NonCourseDays.Add(new NonCourseDay()
                                {
                                    Date = startDate,
                                    Morning = morning,
                                    Afternoon = afternoon,
                                    CourseId = _id,
                                });
                                context.SaveChanges();
                            }       
                        }
                        startDate = startDate.AddDays(1);
                    }

                    LoadData(_id);
                }
            }
        }
    }
}
