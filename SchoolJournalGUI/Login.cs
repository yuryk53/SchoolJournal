﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SJournalEFDAL;
using System.Threading;

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

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            User user = null;

            WaitWindow wait = new WaitWindow();
            wait.Owner = this;
            wait.StartPosition = FormStartPosition.CenterParent;
            wait.Show();

            user = await Task.Factory.StartNew<User>(
                new Func<User>(()=>UsersDAL.GetUserByCredentials(email, password))
            );
            
            //user = UsersDAL.GetUserByCredentials(email, password);
            
            wait.Close();
            AuthenticateUser(user);
        }

        private void AuthenticateUser(User user)
        {
            if (user == null)
            {
                MessageBox.Show("Email or password is invalid!", "No such user!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserCategory category = UsersDAL.GetUserCategory(user.UserID);
            switch (category)
            {
                case UserCategory.ADMIN: //open admin window
                    AdminMenu a_menu = new AdminMenu(user.UserID);
                    a_menu.FormClosed += (o, s) =>
                    {
                        Application.Exit();
                    };
                    a_menu.Owner = this;
                    a_menu.Show();
                    this.Hide();
                    break;
                case UserCategory.PARENT: //open parent window
                    ParentMenu p_menu = new ParentMenu(user.UserID);
                    p_menu.FormClosed += (o, s) =>
                    {
                        Application.Exit();
                    };
                    p_menu.Owner = this;
                    p_menu.Show();
                    this.Hide();
                    break;
                case UserCategory.STUDENT: //open student window
                    StudentMenu s_menu = new StudentMenu(user.UserID);
                    s_menu.FormClosed += (o, s) =>
                    {
                        Application.Exit();
                    };
                    s_menu.Owner = this;
                    s_menu.Show();
                    this.Hide();
                    break;
                case UserCategory.TEACHER: //open teacher window
                    TeacherMenu t_menu = new TeacherMenu(user.UserID);
                    t_menu.FormClosed += (o, s) =>
                    {
                        Application.Exit();
                    };
                    t_menu.Owner = this;
                    t_menu.Show();
                    this.Hide();
                    break;
                case UserCategory.NONE: //show error
                    goto default;
                default: MessageBox.Show("Internal error occured in resolving user category!");
                    return;
            }
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btnSubmit.PerformClick();
                e.Handled = true;
            }
        }
    }
}
