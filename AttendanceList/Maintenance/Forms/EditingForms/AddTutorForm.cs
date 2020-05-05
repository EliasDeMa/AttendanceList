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
    public partial class AddTutorForm : Form, IReturn<Tutor>
    {
        private readonly Tutor tutor = new Tutor();
        public AddTutorForm()
        {
            InitializeComponent();
        }

        public Tutor Result => tutor;

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
                tutor.Name = nameTextBox.Text;

            if (companyTextBox.Text.Length > 0)
                tutor.Company = companyTextBox.Text;


            if (tutor == default)
            {
                addTutorErrorProvider.SetError(addButton, "At least one field must be filled in");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
