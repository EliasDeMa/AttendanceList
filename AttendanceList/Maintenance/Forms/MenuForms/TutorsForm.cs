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
    }
}
