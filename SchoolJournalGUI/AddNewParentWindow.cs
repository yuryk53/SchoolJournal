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
    public partial class AddNewParentWindow : Form
    {
        int StudentID { get; set; }
        public AddNewParentWindow(int studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void AddNewParentWindow_Load(object sender, EventArgs e)
        {
            this.lblStudentID.Text = this.lblStudentID.Text.Replace("#", StudentID.ToString());
            this.lblStudentID1.Text = this.lblStudentID.Text;

            List<string> parentNames = ParentDAL.GetParentNames();
            foreach (string name in parentNames)
                this.comboParents.Items.Add(name);
            if(comboParents.Items.Count>0)
                this.comboParents.SelectedItem = comboParents.Items[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewParent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLastName.Text.Length == 0 || txtFirstName.Text.Length == 0 || txtPatronymic.Text.Length == 0)
                    throw new ArgumentException("FIO fields can't be null!");
                if (txtEmail.Text.Length == 0)
                    throw new ArgumentException("Email is required!");
                if (txtPassword.Text.Length == 0)
                    throw new ArgumentException("Password is required!");
                if (!Util.IsValidEmail(txtEmail.Text))
                    throw new ArgumentException("Email is not valid!");
                User basicUserInfo = new User
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Patronymic = txtPatronymic.Text,
                    DateOfBirth = dateTimePickerBirth.Value.Year == 9998 ? null : new DateTime?(dateTimePickerBirth.Value),
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text
                };

                Parent p = new Parent
                {
                    user = basicUserInfo,
                    Job = txtJob.Text
                };

                ParentDAL.AddNewParent(p);
                StudentDAL.AddParent(this.StudentID, p.ParentID);
                MessageBox.Show("Parent successfully added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAddParent_Click(object sender, EventArgs e)
        {
            int parentID = int.Parse(comboParents.SelectedItem.ToString().Split(' ')[0]);
            try
            {
                StudentDAL.AddParent(this.StudentID, parentID);
                MessageBox.Show("Parent successfully added!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
