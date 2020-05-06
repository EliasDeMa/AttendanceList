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
        private List<Attender> attenders;
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
            using (var context = new AttendanceListContext())
            {
                attenders = context.CourseAttenders.Where(c => c.CourseId == ((CourseInfo)coursesComboBox.SelectedItem).Id)
                    .Select(ca => ca.Attender)
                    .ToList();
            }

            var boxSize = (Width / 4, Height / 3);

            foreach (var item in attenders)
            {
                var box = new GroupBox();
                var button = new Button();
                button.Name = $"Id{item.Id}Button";
                button.Text = "Badge In";
                button.Location = new Point(box.Width / 2, box.Height / 2);
                button.Anchor = AnchorStyles.None;
                button.Click += BadgeInClick;
                box.Controls.Add(new Label() { Text = item.Name, Location = new Point(10, 10), AutoSize = true });
                box.Controls.Add(button);

                attendersLayoutPanel.Controls.Add(box);
            }
        }

        private void BadgeInClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button.Text == "Badge In")
            {
                int id = Int32.Parse(button.Name[2].ToString());
                Console.WriteLine(id);
            }


        }
    }
}
