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
    public partial class ParentMenu : Form
    {
        int ParentID { get; set; }
        public ParentMenu(int parentID)
        {
            InitializeComponent();
            this.ParentID = parentID;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            ParentInfo info = null;
            try
            {
                info = ParentDAL.GetParentInfo(this.ParentID);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileWindow wnd = new ProfileWindow(info, "Job", info.Job);
            wnd.FormClosed += ((o, s) =>
            {
                this.Show();
            });
            wnd.Owner = this;
            wnd.Show();
            this.Hide();
        }

        private void btnViewMyChildren_Click(object sender, EventArgs e)
        {
            //open view window
            ParentStudentsWindow wnd = new ParentStudentsWindow(this.ParentID);
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
            //open child progress window
            ChildProgressWindow wnd = new ChildProgressWindow(this.ParentID);
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
            ChildOverallProgress wnd = new ChildOverallProgress(this.ParentID);
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
