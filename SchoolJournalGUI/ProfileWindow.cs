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
    public partial class ProfileWindow : Form
    {
        UserInfo info;
        bool AllowEdit
        {
            get
            {
                return !txtEmail.ReadOnly;
            }
            set
            {
                txtEmail.ReadOnly = !value;
                txtLastName.ReadOnly = !value;
                txtPhone.ReadOnly = !value;
                if (AllowEdit)
                {
                    btnChangeInfo.Text = "Save";
                }
                else btnChangeInfo.Text = "Change personal info";
            }
        }
        string add1Title, add1Value, add2Title, add2Value;
        public ProfileWindow(UserInfo generalInfo, string add1Title, string add1Value, string add2Title=null, string add2Value=null)
        {
            InitializeComponent();
            this.info = generalInfo;
            this.add1Title = add1Title + ":";
            this.add1Value = add1Value;
            this.add2Title = add2Title;
            this.add2Value = add2Value;
            info = generalInfo;
            lblStatus.Text = info.GetType().Name.Replace("Info", string.Empty);
        }

        private void ProfileWindow_Load(object sender, EventArgs e)
        {
            UpdateFields();
        }

        private void UpdateFields()
        {
            lblUserID.Text = info.UserID.ToString();
            lblFirstName.Text = info.FirstName.ToString();
            txtLastName.Text = info.LastName.ToString();
            lblPatronymic.Text = info.Patronymic;
            lblDob.Text = info.DoB.HasValue ? info.DoB.ToString() : "not specified";
            txtEmail.Text = info.Email;
            txtPhone.Text = info.Phone;

            lblAddInfo1Title.Text = add1Title;
            lblAddInfo1.Text = add1Value;

            if (add2Title != null && add2Value != null)
            {
                lblAddInfo2Title.Text = add2Title + ":";
                lblAddInfo2.Text = add2Value;
                lblAddInfo2.Visible = lblAddInfo2Title.Visible = true;
            }
        }

        private void GatherInfoFromFields()
        {
            User u = new User();
            u.UserID = int.Parse(lblUserID.Text);
            u.FirstName = lblFirstName.Text;
            u.LastName = txtLastName.Text;
            u.Patronymic = lblPatronymic.Text;
            try
            {
                u.DateOfBirth = DateTime.Parse(lblDob.Text);
            }
            catch
            { u.DateOfBirth = null; }
            u.Password = this.info.Password;

            if (!Util.IsValidEmail(txtEmail.Text))
                throw new ArgumentException("Email string is not a valid email!");
            u.Email = txtEmail.Text;
            u.Phone = txtPhone.Text;
            UserInfo newInfo = new UserInfo(u);
            this.info = newInfo;
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if (AllowEdit) //we were in edit mode -> save changes
            {
                try
                {
                    GatherInfoFromFields();
                    UsersDAL.UpdateUserInfo(this.info);
                    UpdateFields();
                    AllowEdit = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else AllowEdit = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordWindow wnd = new ChangePasswordWindow(info.UserID);
            wnd.ShowDialog();
        }
    }
}
