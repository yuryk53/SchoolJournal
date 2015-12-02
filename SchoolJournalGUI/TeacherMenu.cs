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
        int TeacherID { get; set; }
        public TeacherMenu(int teacherID)
        {
            this.TeacherID = teacherID;
            InitializeComponent();
        }

        private void btnViewJournal_Click(object sender, EventArgs e)
        {
            //open viewJournal window
            JournalViewWindow jvWindow = new JournalViewWindow(TeacherID);
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
            NewLessonDialogWindow nlWindow = new NewLessonDialogWindow(TeacherID);
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
            StudentListWindow wnd = new StudentListWindow(TeacherID);
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
            TeacherStudyGroups wnd = new TeacherStudyGroups(TeacherID);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            TeacherInfo info = TeacherDAL.GetTeacher(TeacherID);
            ProfileWindow wnd = new ProfileWindow(info, "Category", info.Category, "Specialization", info.Specialization);
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
