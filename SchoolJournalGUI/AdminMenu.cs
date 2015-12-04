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
    public partial class AdminMenu : Form
    {
        int AdminID { get; set; }
        public AdminMenu(int adminID)
        {
            InitializeComponent();
            AdminID = adminID;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            AdminInfo info = AdminDAL.GetAdmin(this.AdminID);
            ProfileWindow wnd = new ProfileWindow(info, "Has delete rights", info.HasDeleteRights.ToString());
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            //open manage stuents windows
            ManageStudentsWindow wnd = new ManageStudentsWindow();
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnManageTeachers_Click(object sender, EventArgs e)
        {
            //manage teachers window
            ManageTeachersWindow wnd = new ManageTeachersWindow();
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnShiftStudents_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All students will be shifted to the next grade!\n" +
                "Students, who are graduates will be deleted from the database! Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                try
                {
                    StudentDAL.ShiftAllStudentsToNextGrade();
                    MessageBox.Show("Transaction succeeded!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnManageTeacherGroups_Click(object sender, EventArgs e)
        {
            //open manage teacher groups window
            //ManageTeacherGroupsDialog wnd = new ManageTeacherGroupsDialog();
            //wnd.ShowDialog();
            ManageTeachersGroups wnd = new ManageTeachersGroups();
            wnd.Show();
        }
    }
}
