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
    public partial class RegistrationsForm : Form
    {
        private List<RegistrationTime> registrations;
        private List<string> AttenderIds;
        private readonly int _id;

        public RegistrationsForm(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void RegistrationsForm_Load(object sender, EventArgs e)
        {
            LoadData(_id);
            dateFilterTimePicker.Checked = false;
            LoadListBox();
        }

        private void LoadData(int id)
        {
            using (var context = new AttendanceListContext())
            {
                registrations = context.RegistrationTimes.Where(x => x.CourseId == id)
                                       .Select(x => x)
                                       .ToList();
            }

            AttenderIds = registrations.Select(x => x.AttenderId.ToString()).Distinct().ToList();
            attenderIdComboBox.Items.AddRange(AttenderIds.ToArray());
            attenderIdComboBox.SelectedIndex = 0;
        }

        private void LoadListBox()
        {
            IEnumerable<RegistrationTime> filteredItems = registrations;

            if (dateFilterTimePicker.Checked)
                filteredItems = registrations.Where(x => x.DateTime.Value.Date == dateFilterTimePicker.Value.Date);

            if (attenderIdComboBox.SelectedItem.ToString() != "All")
                filteredItems = filteredItems.Where(x => x.AttenderId.ToString() == attenderIdComboBox.SelectedItem.ToString());

            registrationsListBox.Items.Clear();
            registrationsListBox.Items.AddRange(filteredItems.ToArray());
        }

        private void registrationsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.registrationsListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var r = new RegistrationInfoForm(((RegistrationTime)registrationsListBox.SelectedItem).Id);
                r.Show();
            }
        }

        private void dateFilterTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBox();
        }
    }
}
