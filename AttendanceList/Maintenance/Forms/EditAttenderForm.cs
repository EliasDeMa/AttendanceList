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

namespace Maintenance.Forms
{
    public partial class EditAttenderForm : Form, IReturn<Attender>
    {
        private Attender currAttender;

        public EditAttenderForm(Attender attender)
        {
            InitializeComponent();
            currAttender = attender;
        }

        public Attender Result => throw new NotImplementedException();

        private void EditAttenderForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = currAttender.Name;
            AddressTextBox.Text = currAttender.Address;
            birthdateTextBox.Text = currAttender.Birthdate.GetValueOrDefault().ToShortDateString();
        }
    }
}
