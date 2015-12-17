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
    public partial class ManageTeachersGroups : Form
    {
        string[] states = new string[] { "Changes saved", "Changes not saved!" };
        bool _isSaved = true;
        bool IsSaved
        {
            get
            {
                return _isSaved;
            }
            set
            {
                _isSaved = value;
                if (_isSaved)
                {
                    this.toolStripIsSaved.Text = states[0];
                }
                else
                {
                    this.toolStripIsSaved.Text = states[1];
                }
            }
        }
        bool HasDeleteRights { get; set; }
        public ManageTeachersGroups(bool hasDeleteRights)
        {
            InitializeComponent();
            this.HasDeleteRights = hasDeleteRights;
        }

        private void ManageTeachersGroups_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schooljournalDataSet.getDistinctGrades' table. You can move, or remove it, as needed.
            this.getDistinctGradesTableAdapter.Fill(this.schooljournalDataSet.getDistinctGrades);
            // TODO: This line of code loads data into the 'schooljournalDataSet.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.schooljournalDataSet.subject);
            // TODO: This line of code loads data into the 'schooljournalDataSet.teachers_groups' table. You can move, or remove it, as needed.
            this.teachers_groupsTableAdapter.Fill(this.schooljournalDataSet.teachers_groups);
            GroupsDataGridView.SelectionChanged += GroupsDataGridView_SelectionChanged;
            GroupsDataGridView.Rows[0].Selected = true;

            if (!HasDeleteRights) //disable all delete buttons
            {
                btnRemoveStudentFromGroup.Enabled = false;
            }
        }

        void GroupsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int rowIndex = GroupsDataGridView.SelectedCells[0].RowIndex;
            if (GroupsDataGridView.Rows[rowIndex].IsNewRow)
                rowIndex--;
            int groupID;
            GroupsDataGridView.Rows[rowIndex].Cells["Grade"].ReadOnly = false;
            try
            {
                groupID = int.Parse(GroupsDataGridView["GroupID", rowIndex].Value.ToString());
            }
            catch
            {
                return;
            }
            
            try
            {
                this.getGroupStudentsTableAdapter.Fill(this.schooljournalDataSet.getGroupStudents, groupID);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void GroupsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.IsSaved = false;
        }

        private void GroupsDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

            int rowIndex = e.Row.Index-1;
            try
            {
                GroupsDataGridView["GroupID", rowIndex].Value =
                    int.Parse(GroupsDataGridView["GroupID", rowIndex - 1].Value.ToString()) + 1;
            }
            catch
            {
                GroupsDataGridView["GroupID", rowIndex].Value = (new Random()).Next();
            }
            this.IsSaved = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            saveGroups();
            this.IsSaved = true;
        }

        private void saveGroups()
        {
            SchoolJournalEntities context = new SchoolJournalEntities();
            var groupIDs = from g in context.Groups select g.GroupID;

            try
            {
                foreach (DataGridViewRow r in GroupsDataGridView.Rows)
                {
                    if (r.IsNewRow)
                        continue;
                    int groupID = int.Parse(GroupsDataGridView["GroupID", r.Index].Value.ToString());
                    if (groupIDs.Contains(groupID)) //update
                    {
                        GroupDAL.UpdateGroup(groupID,
                            int.Parse(GroupsDataGridView["TeacherID", r.Index].Value.ToString()),
                            GroupsDataGridView["Subject", r.Index].EditedFormattedValue.ToString(),
                            GroupsDataGridView["Grade", r.Index].EditedFormattedValue.ToString(),
                            GroupsDataGridView["Description", r.Index].Value.ToString());

                    }
                    else //add new
                    {
                        GroupsDataGridView["GroupID", r.Index].Value =
                                GroupDAL.NewGroup(int.Parse(GroupsDataGridView["TeacherID", r.Index].Value.ToString()),
                                    GroupsDataGridView["Subject", r.Index].EditedFormattedValue.ToString(),
                                    GroupsDataGridView["Grade", r.Index].EditedFormattedValue.ToString(),
                                    GroupsDataGridView["Description", r.Index].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                context.Dispose();
            }
        }

        private void studentsDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
            this.IsSaved = false;
        }

        private void studentsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.IsSaved = false;
        }

        private void studentsDataGridView_Enter(object sender, EventArgs e)
        {
            if (!IsSaved) //save
            {
                //save datagrid1
                saveGroups();
                IsSaved = true;
                studentsDataGridView.Update();
            }
        }

        private void GroupsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == GroupsDataGridView.Rows[e.RowIndex].Cells["FirstName"].ColumnIndex ||
                e.ColumnIndex == GroupsDataGridView.Rows[e.RowIndex].Cells["LastName"].ColumnIndex ||
                e.ColumnIndex == GroupsDataGridView.Rows[e.RowIndex].Cells["Patronymic"].ColumnIndex)
            {
                ManageTeacherGroupsDialog dialog = new ManageTeacherGroupsDialog();
                dialog.Owner = this;
                dialog.FormClosing += (o, s) =>
                    {
                        try
                        {
                            if ((o as ManageTeacherGroupsDialog).TeacherID != 0)
                            {
                                GroupsDataGridView["TeacherID", e.RowIndex].Value = (o as ManageTeacherGroupsDialog).TeacherID;
                                GroupsDataGridView["LastName", e.RowIndex].Value = (o as ManageTeacherGroupsDialog).LastName;
                                GroupsDataGridView["FirstName", e.RowIndex].Value = (o as ManageTeacherGroupsDialog).FirstName;
                                GroupsDataGridView["Patronymic", e.RowIndex].Value = (o as ManageTeacherGroupsDialog).Patronymic;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                dialog.ShowDialog();
            }
        }

        private void btnAddStudentToGroup_Click(object sender, EventArgs e)
        {
            int rowIndex = GroupsDataGridView.SelectedCells[0].RowIndex;
            AddStudentToGroupDialog dialog = new AddStudentToGroupDialog(GroupsDataGridView["Grade", rowIndex].EditedFormattedValue.ToString());
            //dialog.Owner = this;
            dialog.FormClosed += (o, s) =>
                {
                    if (dialog.StudentID != 0)
                    {
                        //studentsDataGridView.Rows.Add(dialog.GradeSection, dialog.LastName, dialog.FirstName, dialog.StudentID);
                        //add new student
                        try
                        {
                            GroupDAL.AddStudentToGroup(
                                int.Parse(GroupsDataGridView["GroupID", rowIndex].Value.ToString()),
                                dialog.StudentID);

                            this.getGroupStudentsTableAdapter.Fill(this.schooljournalDataSet.getGroupStudents, int.Parse(GroupsDataGridView["GroupID", rowIndex].Value.ToString()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                        }
                    }
                };
            dialog.ShowDialog();
        }

        private void btnRemoveStudentFromGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = studentsDataGridView.SelectedCells[0].RowIndex;
                int studentID = int.Parse(studentsDataGridView["Student_ID", rowIndex].EditedFormattedValue.ToString());
                int groupID = int.Parse(studentsDataGridView["Group_ID", rowIndex].EditedFormattedValue.ToString());

                if (MessageBox.Show(string.Format("Do you really want to delete student {0} {1} from group #{2}?",
                    studentsDataGridView["Last_name", rowIndex].EditedFormattedValue.ToString(),
                    studentsDataGridView["First_name", rowIndex].EditedFormattedValue.ToString(),
                    groupID), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    GroupDAL.RemoveStudentFromGroup(groupID, studentID);
                    studentsDataGridView.Rows.RemoveAt(rowIndex);

                    MessageBox.Show("Student successfully removed from the group!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
