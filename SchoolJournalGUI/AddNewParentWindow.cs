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
