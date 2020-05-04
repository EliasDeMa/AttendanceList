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
    public partial class AddAttenderForm : Form, IReturn<Attender>
    {
        private Attender attender = new Attender();
        public AddAttenderForm()
        {
            InitializeComponent();
        }

        public Attender Result => attender;
    }
}
