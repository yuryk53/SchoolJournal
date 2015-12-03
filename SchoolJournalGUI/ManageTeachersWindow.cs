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
    public partial class ManageTeachersWindow : Form
    {
        public ManageTeachersWindow()
        {
            InitializeComponent();
        }

        private void ManageTeachersWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schooljournalDataSet.teachersList' table. You can move, or remove it, as needed.
            this.teachersListTableAdapter.Fill(this.schooljournalDataSet.teachersList);
            this.toolStripSavedStatus.Text = "Changes saved!";
        }

        private void teachersListDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.toolStripSavedStatus.Text = "Changes not saved!";
        }

        private void toolStripButtonSaveChanges_Click(object sender, EventArgs e)
        {
            SchoolJournalEntities context = null;
            try
            {
                context = new SchoolJournalEntities();
                var teacherIDs = from teacher in context.Teachers select teacher.TeacherID;


                foreach (DataGridViewRow r in teachersListDataGridView.Rows)
                {
                    if (r.IsNewRow)
                        continue;
                    int teacherID = int.Parse(teachersListDataGridView["teacherID", r.Index].Value.ToString());
                    if (teacherIDs.Contains(teacherID)) //update record
                    {
                        DateTime? dateOfBirth;
                        try
                        {
                            dateOfBirth = DateTime.Parse(teachersListDataGridView["dateOfBirth", r.Index].Value.ToString());
                        }
                        catch
                        {
                            dateOfBirth = null;
                        }
                        TeacherDAL.UpdateTeacher(new TeacherInfo(
                            teacherID,
                            teachersListDataGridView["firstName", r.Index].Value.ToString(),
                            teachersListDataGridView["lastName", r.Index].Value.ToString(),
                            teachersListDataGridView["patronymic", r.Index].Value.ToString(),
                            dateOfBirth,
                            teachersListDataGridView["email", r.Index].Value.ToString(),
                            teachersListDataGridView["password", r.Index].Value.ToString(),
                            teachersListDataGridView["phone", r.Index].Value.ToString(),
                            teachersListDataGridView["specialization", r.Index].Value.ToString(),
                            teachersListDataGridView["category", r.Index].Value.ToString())
                            );
                    }
                    else //add new record
                    {
                        DateTime? dateOfBirth;
                        try
                        {
                            dateOfBirth = DateTime.Parse(teachersListDataGridView["dateOfBirth", r.Index].Value.ToString());
                        }
                        catch
                        {
                            dateOfBirth = null;
                        }
                        teachersListDataGridView["teacherID", r.Index].Value =
                                TeacherDAL.AddNewTeacher(new TeacherInfo(
                                    -1, //заглушка
                                    teachersListDataGridView["firstName", r.Index].Value.ToString(),
                                    teachersListDataGridView["lastName", r.Index].Value.ToString(),
                                    teachersListDataGridView["patronymic", r.Index].Value.ToString(),
                                    dateOfBirth,
                                    teachersListDataGridView["email", r.Index].Value.ToString(),
                                    teachersListDataGridView["password", r.Index].Value.ToString(),
                                    teachersListDataGridView["phone", r.Index].Value.ToString(),
                                    teachersListDataGridView["specialization", r.Index].Value.ToString(),
                                    teachersListDataGridView["category", r.Index].Value.ToString())
                                    );
                    }
                }

                this.toolStripSavedStatus.Text = "Changes saved!";
            }
            catch (Exception ex)
            {
                string innerException = string.Empty;
                if (ex.InnerException != null)
                    innerException = ex.InnerException.Message;
                MessageBox.Show(ex.Message+"\n"+innerException, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(context!=null)
                    context.Dispose();
            }
        }

        private void toolStripButtonDeleteRecord_Click(object sender, EventArgs e)
        {
            int rowIndex = teachersListDataGridView.SelectedCells[0].RowIndex;
            try
            {
                if (MessageBox.Show(string.Format("Do you really want to delete teacher {0} {1}?",
                    teachersListDataGridView["lastName", rowIndex].Value, teachersListDataGridView["firstName", rowIndex].Value),
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if(toolStripSavedStatus.Text.Equals("Changes saved"))
                        UsersDAL.DeleteUser(int.Parse(teachersListDataGridView["teacherID", rowIndex].Value.ToString()));
                    teachersListDataGridView.Rows.RemoveAt(rowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teachersListDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            int rowIndex = e.Row.Index;
            try
            {
                int prevTeacherID = int.Parse(teachersListDataGridView["teacherID", rowIndex - 2].Value.ToString());
                teachersListDataGridView["teacherID", rowIndex - 1].Value = prevTeacherID + 1;
            }
            catch
            {
                teachersListDataGridView["teacherID", rowIndex - 1].Value = 0;
            }
            this.toolStripSavedStatus.Text = "Changes not saved!";
        }
    }
}
