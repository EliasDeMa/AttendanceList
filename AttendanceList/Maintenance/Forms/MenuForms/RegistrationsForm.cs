﻿using DatabaseModel;
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
        private readonly int _id;

        public RegistrationsForm(int id)
        {
            InitializeComponent();
            _id = id;
        }
    }
}