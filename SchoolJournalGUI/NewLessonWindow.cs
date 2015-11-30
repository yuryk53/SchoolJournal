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
    public partial class NewLessonWindow : Form
    {
        private int TeacherID { get; set; }
        string Subj_title { get; set; }
        string Theme { get; set; }
        int NumberOfHours { get; set; }
        string GradeName { get; set; }
        string HomeTask { get; set; }
        ILessonInfo newLesson;
        List<StudentInfo> studentsOnTheLesson;

        public NewLessonWindow(int teacherID, ILessonInfo newLesson)
        {
            InitializeComponent();
            this.TeacherID = teacherID;
            this.newLesson = newLesson;
        }

        private void NewLessonWindow_Load(object sender, EventArgs e)
        {
            this.lblTeacher.Text = TeacherID.ToString();
            this.lblGrade.Text = newLesson.GradeNo.ToString() + newLesson.GradeSection;
            this.lblSubject.Text = newLesson.Subject;
            this.lblDate.Text = newLesson.Date.ToShortDateString();

            BuildGridJournalNewLesson();
            this.toolStripIsSaved.Text = "Saved.";
        }

        private void BuildGridJournalNewLesson()
        {
            studentsOnTheLesson = StudentDAL.GetAllStudentsOnTheLesson(newLesson.LessonID);

            gridJournal.Columns.AddRange(new DataGridViewTextBoxColumn { Name = "Name", HeaderText="Last name, First name" },
                                         new DataGridViewTextBoxColumn { Name = "Mark", HeaderText = "Mark", ValueType=typeof(decimal?) },
                                         new DataGridViewCheckBoxColumn { Name = "IsPresent", HeaderText="Is Present" });

            foreach (StudentInfo s in studentsOnTheLesson)
            {
                gridJournal.Rows.Add(string.Format("{0} {1}", s.LastName, s.FirstName),
                                     string.Empty,
                                     false);
            }
            
            gridJournal.AllowUserToAddRows = false;
            gridJournal.AllowUserToDeleteRows = false;
            gridJournal.AllowUserToOrderColumns = false;
            gridJournal.Update();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < gridJournal.Rows.Count; i++)
                {
                    decimal? mark;
                    if(string.IsNullOrEmpty(gridJournal.Rows[i].Cells["Mark"].Value.ToString()))
                    {
                        mark = null;
                    }
                    else mark = (decimal)gridJournal.Rows[i].Cells["Mark"].Value;
                    LessonDAL.PlaceMark(newLesson.LessonID,
                                        this.studentsOnTheLesson[i].StudentID,
                                        mark,
                                        (bool)((DataGridViewCheckBoxCell)gridJournal.Rows[i].Cells["IsPresent"]).Value);
                }
                this.toolStripIsSaved.Text = "Saved.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridJournal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //Mark value
            {
                decimal mark;
                if (!string.IsNullOrEmpty(gridJournal.Rows[e.RowIndex].Cells["Mark"].Value.ToString())) //if mark is stated and valid
                {
                    if (decimal.TryParse(gridJournal.Rows[e.RowIndex].Cells["Mark"].Value.ToString(), out mark)) //mark is valid
                    {
                        ((DataGridViewCheckBoxCell)gridJournal.Rows[e.RowIndex].Cells["IsPresent"]).Value = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid mark value!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            toolStripIsSaved.Text = "The changes are not saved yet...";
        }
    }
}
