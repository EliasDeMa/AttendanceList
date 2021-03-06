﻿using Maintenance.Interfaces;
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
    public partial class AddNonCourseDayForm : Form, IReturn<(SelectionRange, bool, bool)>
    {
        public AddNonCourseDayForm()
        {
            InitializeComponent();
        }

        public (SelectionRange, bool, bool) Result
            => (dayOffMonthCalendar.SelectionRange, morningCheckBox.Checked, afternoonCheckBox.Checked);

        private void button1_Click(object sender, EventArgs e)
        {
            if (morningCheckBox.Checked || afternoonCheckBox.Checked)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                dayOffErrorProvider.SetError(button1, "At least one of the cheboxes must checked");
            }
        }
    }
}
