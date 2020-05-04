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
    public partial class AttendersForm : Form
    {
        private readonly List<Attender> attenders;
        private readonly int _id;

        public AttendersForm(int id)
        {
            InitializeComponent();
            using (var context = new AttendanceListContext())
            {
                attenders = context.CourseAttenders.Where(x => x.CourseId == id)
                                       .Select(x => x.Attender)
                                       .ToList();
            }
        }

        private void AttendersForm_Load(object sender, EventArgs e)
        {
            foreach (var item in attenders)
            {
                attendersListBox.Items.Add(item);
            }
        }

        private void addAttenderButton_Click(object sender, EventArgs e)
        {
            using (var addAttender = new AddAttenderForm())
            {

            }
        }
    }
}
