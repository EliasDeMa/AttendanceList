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

namespace Maintenance
{
    public partial class EditAttenderForm : Form, IReturn<Attender>
    {
        private readonly Attender currAttender;

        public EditAttenderForm(Attender attender)
        {
            InitializeComponent();
            currAttender = attender;
        }

        public Attender Result => currAttender;

        private void EditAttenderForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = currAttender.Name;
            AddressTextBox.Text = currAttender.Address;
            birthdateTextBox.Text = currAttender.Birthdate.GetValueOrDefault().ToShortDateString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != currAttender.Name ||
                AddressTextBox.Text != currAttender.Address ||
                birthdateTextBox.Text != currAttender.Birthdate.GetValueOrDefault().ToShortDateString())
            {
                currAttender.Birthdate = DateTime.Parse(birthdateTextBox.Text);
                currAttender.Address = AddressTextBox.Text;
                currAttender.Name = nameTextBox.Text;
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
