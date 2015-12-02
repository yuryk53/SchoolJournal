using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolJournalGUI
{
    public partial class ChangePasswordWindow : Form
    {
        int UserID { get; set; }
        public ChangePasswordWindow(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (!txtNewPass.Text.Equals(txtRepeatPass.Text))
            {
                txtNewPass.BackColor = Color.Red;
                txtRepeatPass.BackColor = Color.Red;
            }
            else
            {
                txtNewPass.BackColor = Color.Green;
                txtRepeatPass.BackColor = Color.Green;

                //invoke change pass function
                try
                {
                    SJournalEFDAL.UsersDAL.ChangeUserPassword(this.UserID, txtOldPass.Text, txtNewPass.Text);
                    MessageBox.Show("Password was successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNewPass.Text = string.Empty;
                    txtOldPass.Text = string.Empty;
                    txtRepeatPass.Text = string.Empty;

                    txtNewPass.BackColor = Color.White;
                    txtRepeatPass.BackColor = Color.White;
                }
            }
        }
    }
}
