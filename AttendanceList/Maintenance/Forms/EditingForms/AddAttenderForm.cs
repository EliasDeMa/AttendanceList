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
    public partial class AddAttenderForm : Form, IReturn<Attender>
    {
        private readonly Attender attender = new Attender();
        public AddAttenderForm()
        {
            InitializeComponent();
        }

        public Attender Result => attender;

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
                attender.Name = nameTextBox.Text;

            if (AddressTextBox.Text.Length > 0)
                attender.Address = AddressTextBox.Text;

            if (birthdateTextBox.Text.Length > 0)
                attender.Birthdate = DateTime.Parse(birthdateTextBox.Text);

            if (attender == default)
            {
                addAttenderErrorProvider.SetError(addButton, "At least one field must be filled in");
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
