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
    public partial class NewLessonDialogWindow : Form
    {
        public int TeacherID { get; set; }
        List<Subject> subjects = SubjectsDAL.GetAllSubjects();
        List<Grade> grades = GradesDAL.GetAllGrades();

        public NewLessonDialogWindow(int teacherID)
        {
            InitializeComponent();
            this.TeacherID = teacherID;
        }

        private void NewLessonDialogWindow_Load(object sender, EventArgs e)
        {
            toolStripTeacherID.Text = string.Format("Teacher ID: {0}", this.TeacherID.ToString());

           
            comboBoxSubject.Items.AddRange(subjects.ConvertAll<string>(s => s.Title).ToArray());
            comboBoxSubject.SelectedIndex = 0;

            comboGrade.Items.AddRange(grades.ConvertAll<string>(g => g.ToString()).ToArray());
            comboGrade.SelectedIndex = 0;
            
        }

        private void btnCreateLesson_Click(object sender, EventArgs e)
        {
            string txtLessonTheme = this.txtLessonTheme.Text,
                   txtNumberOfHours = this.comboBoxNHours.SelectedItem.ToString(),
                   txtHomeTask = this.txtHomeTask.Text;

            if (string.IsNullOrEmpty(txtLessonTheme))
            {
                ShowExceptionMessage("Lesson theme cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(txtNumberOfHours))
            {
                ShowExceptionMessage("Number of hours cannot be empty!");
                return;
            }
            int numberOfHours = 0;
            if(!int.TryParse(txtNumberOfHours, out numberOfHours))
            {
                ShowExceptionMessage("Incorrect hours number format!");
                return;
            }

            int studentsInGradeCount = StudentDAL.GetStudentCountByGradeName(comboGrade.SelectedItem.ToString());
            if (studentsInGradeCount == 0)
            {
                MessageBox.Show(string.Format("No students in grade {0}!\nAsk administrator to add some!",
                    comboGrade.SelectedItem.ToString()),
                    "Impossible to create lesson!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ILessonInfo newLesson = LessonDAL.StartNewLesson(comboBoxSubject.SelectedItem.ToString(),
                                         txtLessonTheme,
                                         numberOfHours,
                                         comboGrade.SelectedItem.ToString(),
                                         txtHomeTask,
                                         this.TeacherID);

                NewLessonWindow nlWindow = new NewLessonWindow(this.TeacherID, newLesson);

                nlWindow.Owner = this.Owner;
                nlWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                ShowExceptionMessage(ex.Message);
                return;
            }
                                     

        }

        private void ShowExceptionMessage(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
