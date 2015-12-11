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
    public partial class StudentMenu : Form
    {
        int StudentID { get; set; }
        public StudentMenu(int studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            StudentInfo info = null;
            try
            {
                info = StudentDAL.GetStudentInfo(this.StudentID);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileWindow wnd = null;
            if(info.DateOfJoin.HasValue)
                wnd = new ProfileWindow(info, "Grade", info.GradeName, "Date of join", info.DateOfJoin.Value.ToString());
            else wnd = new ProfileWindow(info, "Grade", info.GradeName);

            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnMyHomeTasks_Click(object sender, EventArgs e)
        {
            //my home tasks window
            StudentHomeTasks wnd = new StudentHomeTasks(this.StudentID);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnChildProgress_Click(object sender, EventArgs e)
        {
            //student progress window
            StudentProgressOnSubjWindow wnd = new StudentProgressOnSubjWindow(this.StudentID);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnChildOverallProgress_Click(object sender, EventArgs e)
        {
            //student progress window
            StudentOverallProgressWindow wnd = new StudentOverallProgressWindow(this.StudentID);
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
