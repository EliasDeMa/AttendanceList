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
    public partial class EditFieldForm : Form, IReturn<string>
    {
        public EditFieldForm(string text)
        {
            InitializeComponent();
            editTextBox.Text = text;
        }

        public string Result => editTextBox.Text;

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
