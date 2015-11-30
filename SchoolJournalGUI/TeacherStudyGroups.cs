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
    public partial class TeacherStudyGroups : Form
    {
        int TeacherID { get; set; }
        public TeacherStudyGroups(int teacherID)
        {
            InitializeComponent();
            TeacherID = teacherID;
        }

        private void TeacherStudyGroups_Load(object sender, EventArgs e)
        {
            DataTable dtGroups = TeacherDAL.GetTeacherGroups(TeacherID);//TeacherDAL.GetTeacherStudents(TeacherID);
            this.dataGridViewGroups.DataSource = dtGroups;
            this.dataGridViewGroups.Update();

            //bind binging navigator to data grid
            var bs = new BindingSource();
            bs.DataSource = dtGroups.DefaultView;
            bindingNavigator1.BindingSource = bs;
            dataGridViewGroups.DataSource = bs;


            DataTable dtGroupStudents = GroupDAL.GetGroupStudents((int)dataGridViewGroups.Rows[dataGridViewGroups.SelectedCells[0].RowIndex].Cells["Group ID"].Value);
            this.dataGridViewGroupStudents.DataSource = dtGroupStudents;

            toolStripTeacherID.Text = "Teacher ID: " + TeacherID.ToString();
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dtGroupStudents = GroupDAL.GetGroupStudents(
                (int)dataGridViewGroups.Rows[dataGridViewGroups.SelectedCells[0].RowIndex].Cells["Group ID"].Value);
            this.dataGridViewGroupStudents.DataSource = dtGroupStudents;
        }
    }
}
