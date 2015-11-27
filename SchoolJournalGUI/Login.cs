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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            User user = UsersDAL.GetUserByCredentials(email, password);

            if (user == null)
            {
                MessageBox.Show("Email or password is invalid!", "No such user!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserCategory category = UsersDAL.GetUserCategory(user.UserID);
            switch (category)
            {
                case UserCategory.ADMIN: //open admin window
                    MessageBox.Show("Admin");
                    break;
                case UserCategory.PARENT: //open parent window
                    MessageBox.Show("Parent");
                    break;
                case UserCategory.STUDENT: //open student window
                    MessageBox.Show("Student");
                    break;
                case UserCategory.TEACHER: //open teacher window
                    TeacherMenu menu = new TeacherMenu(user);
                    menu.FormClosed += (o, s) =>
                    {
                        Application.Exit();
                    };
                    menu.Owner = this;
                    menu.Show();
                    this.Hide();
                    break;
                case UserCategory.NONE: //show error
                    goto default;
                default: MessageBox.Show("Internal error occured in resolving user category!");
                    return;
            }
        }
    }
}
