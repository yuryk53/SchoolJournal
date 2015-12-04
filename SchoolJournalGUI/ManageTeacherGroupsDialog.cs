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
    public partial class ManageTeacherGroupsDialog : Form
    {
        public int TeacherID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        
        public ManageTeacherGroupsDialog()
        {
            InitializeComponent();
        }

        private void ManageTeacherGroupsDialog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schooljournalDataSet.getTeacherNames' table. You can move, or remove it, as needed.
            this.getTeacherNamesTableAdapter.Fill(this.schooljournalDataSet.getTeacherNames);

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string compositeName = this.comboBoxTeachers.SelectedValue.ToString();
            while(compositeName.Contains("  "))
                compositeName = compositeName.Replace("  ", "");
            string[] separatedName = compositeName.Split(' ');
            this.TeacherID = int.Parse(separatedName[0]);
            this.LastName = separatedName[1];
            this.FirstName = separatedName[2];
            this.Patronymic = separatedName[3];

            this.Close();
        }

    }
}
