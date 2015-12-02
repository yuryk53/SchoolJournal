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
    }
}
