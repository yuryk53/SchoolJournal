using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SJournalEFDAL;

namespace SchoolJournalGUI
{
    public partial class AddStudentToGroupDialog : Form
    {
        public string GradeSection { get; set; }
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public AddStudentToGroupDialog(string gradeSection)
        {
            InitializeComponent();
            GradeSection = gradeSection;
        }

        private void AddStudentToGroupDialog_Load(object sender, EventArgs e)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var studentsInGroup = from grp in context.Groups
                                      from student in context.Students
                                      where grp.students.Contains(student) &&
                                      (grp.grade.GradeNo + grp.grade.Section).Equals(GradeSection)
                                      select student.StudentID;

                var studentNames = from student in context.Students
                                   where !studentsInGroup.Contains(student.StudentID)
                                   && (student.grade.GradeNo + student.grade.Section).Equals(GradeSection)
                                   select student.user.UserID + " " + student.user.LastName + " " + student.user.FirstName;
                foreach (var sName in studentNames)
                {
                    this.comboBoxNames.Items.Add(sName.ToString());
                }
            }

            if (comboBoxNames.Items.Count > 0)
                comboBoxNames.SelectedItem = comboBoxNames.Items[0];
            else
            {
                comboBoxNames.Visible = false;
                lblError.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] compositeName = this.comboBoxNames.SelectedItem.ToString().Split(' ');
                if (compositeName.Length > 0)
                {
                    this.StudentID = int.Parse(compositeName[0]);
                    this.LastName = compositeName[1];
                    this.FirstName = compositeName[2];
                }
            }
            catch { }
            this.Close();
        }
    }
}
