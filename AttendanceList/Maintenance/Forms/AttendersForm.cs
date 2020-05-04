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

namespace Maintenance
{
    public partial class AttendersForm : Form
    {
        private List<Attender> attenders;
        private readonly int _id;

        public AttendersForm(int id)
        {
            InitializeComponent();
            _id = id;
            using (var context = new AttendanceListContext())
            {
                attenders = context.CourseAttenders.Where(x => x.CourseId == id)
                                       .Select(x => x.Attender)
                                       .ToList();
            }

            attendersListBox.DataSource = attenders;
        }

        private void AttendersForm_Load(object sender, EventArgs e)
        {
            //foreach (var item in attenders)
            //{
            //    attendersListBox.Items.Add(item);
            //}
        }

        private void addAttenderButton_Click(object sender, EventArgs e)
        {
            using (var addAttender = new AddAttenderForm())
            {
                var result = addAttender.ShowDialog();

                if (result == DialogResult.OK)
                {
                    int badge = 1;
                    var attender = addAttender.Result;

                    while (attenders.Where(x => x.BadgeNumber == badge).Any())
                        badge++;

                    using (var context = new AttendanceListContext())
                    {
                        context.Attenders.Add(new Attender()
                        {
                            Name = attender.Name,
                            Address = attender.Address,
                            Birthdate = attender.Birthdate,
                            BadgeNumber = badge
                        });

                        

                        context.SaveChanges();
                    }

                    using (var context = new AttendanceListContext())
                    {
                        int attId = context.Attenders.Where(x => x.BadgeNumber == badge)
                            .Select(x => x.Id)
                            .First();
                        context.CourseAttenders.Add(new CourseAttender()
                        {
                            AttenderId = attId,
                            CourseId = _id,
                        });

                        context.SaveChanges();
                    }

                    attendersListBox.DisplayMember = "";
                    attendersListBox.DisplayMember = "Name";
                    //BindData();
                    //UpdateListBox();
                }

            }
        }

        void BindData()
        {
            attendersListBox.DataSource = null;
            attendersListBox.DataSource = attenders;
        }

        //private void UpdateListBox()
        //{
        //    using (var context = new AttendanceListContext())
        //    {
        //        attenders = context.CourseAttenders.Where(x => x.CourseId == _id)
        //                               .Select(x => x.Attender)
        //                               .ToList();
        //    }

        //    foreach (var item in attenders)
        //    {
        //        attendersListBox.Items.Add(item);
        //    }
        //}
    }
}
