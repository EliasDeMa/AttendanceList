using DatabaseModel;
using Maintenance.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance.Forms.EditingForms
{
    public partial class EditTutorForm : Form, IReturn<Tutor>
    {
        private readonly Tutor currTutor;

        public EditTutorForm(Tutor t)
        {
            InitializeComponent();
            currTutor = t;
        }

        public Tutor Result => currTutor;

        private void EditTutorForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = currTutor.Name;
            companyTextBox.Text = currTutor.Company;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != currTutor.Name ||
                companyTextBox.Text != currTutor.Company)
            {
                currTutor.Company = companyTextBox.Text;
                currTutor.Name = nameTextBox.Text;
            }

            var r = MessageBox.Show("Are you sure want to save these changes", "Save", MessageBoxButtons.OKCancel);

            if (r == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
