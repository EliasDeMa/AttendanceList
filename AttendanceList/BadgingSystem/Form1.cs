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

namespace BadgingSystem
{
    public partial class Form1 : Form
    {
        private readonly List<CourseInfo> courses;
        public Form1()
        {
            InitializeComponent();
            using (var context = new AttendanceListContext())
            {
                courses = context.CourseInfoes.ToList();
            }
        }

        private void timeShowTimer_Tick(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString();
            coursesComboBox.Items.AddRange(courses.ToArray());
        }

        private void coursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
