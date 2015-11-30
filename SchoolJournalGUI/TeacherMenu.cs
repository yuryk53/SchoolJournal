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
    public partial class TeacherMenu : Form
    {
        User teacher;
        public TeacherMenu(User teacher)
        {
            this.teacher = teacher;
            InitializeComponent();
        }

        private void btnViewJournal_Click(object sender, EventArgs e)
        {
            //open viewJournal window
            JournalViewWindow jvWindow = new JournalViewWindow(teacher.UserID);
            jvWindow.FormClosed+=((o,s) =>
            {
                this.Show();
            });
            jvWindow.Owner = this;
            jvWindow.Show();
            this.Hide();
        }

        private void btnStartNewLesson_Click(object sender, EventArgs e)
        {
            //open StartLessonWindow
            NewLessonDialogWindow nlWindow = new NewLessonDialogWindow(teacher.UserID);
            nlWindow.FormClosed += ((o,s) =>
                {
                    this.Show();
                });
            nlWindow.Owner = this;
            nlWindow.ShowDialog();
        }

        private void btnListOfStudents_Click(object sender, EventArgs e)
        {
            //LIst of students window
            StudentListWindow wnd = new StudentListWindow(teacher.UserID);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnMyStudyGroups_Click(object sender, EventArgs e)
        {
            TeacherStudyGroups wnd = new TeacherStudyGroups(teacher.UserID);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }
    }
}
