using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using SJournalEFDAL;

namespace SchoolJournalGUI
{
    public partial class StudentProgressOnSubjWindow : Form
    {
        SortedSet<string> subjects = null;
        List<Subject> sbjcts = null;

        int StudentID { get; set; }

        public StudentProgressOnSubjWindow(int studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void StudentProgressOnSubjWindow_Load(object sender, EventArgs e)
        {
            //populate combo box SUBJECTS
            UpdateSubjectsComboBox();

            // Set palette.
            this.chartProgress.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chartProgress.Titles.Add("Student progress");
        }

        private void UpdateSubjectsComboBox()
        {
            this.subjects = new SortedSet<string>();

            sbjcts = SubjectsDAL.GetGradeSubjects(StudentDAL.GetStudentGradeID(this.StudentID));
            foreach (Subject s in sbjcts)
                this.subjects.Add(s.Title);


            this.comboSubject.Items.Clear();
            foreach (string sTitle in this.subjects)
            {
                this.comboSubject.Items.Add(sTitle);
            }
            if (comboSubject.Items.Count > 0)
                comboSubject.SelectedItem = comboSubject.Items[0];
            else comboSubject.Enabled = false;
        }

        private void comboBoxSubj_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update chart
            UpdateChart();
        }

        private void UpdateChart()
        {
            // Data arrays.
            List<string> seriesList = new List<string>();
            List<List<MarkInfo>> marksList = new List<List<MarkInfo>>();

            DateTime studyYearStart;  //= new DateTime(yearStart, 9, 1); //1st Septemper
            if (DateTime.Now.Month <= 7) //it's previous study year
            {
                studyYearStart = new DateTime(DateTime.Now.Year - 1, 9, 1); //1st Septemper 
            }
            else studyYearStart = new DateTime(DateTime.Now.Year, 9, 1);

            this.Text = string.Format("My progress on subject - School Journal" +
               " - Results on the {0}/{1} study year", studyYearStart.Year, studyYearStart.Year + 1);

            StudentInfo s_info = StudentDAL.GetStudentInfo(this.StudentID);

            string lastName = s_info.LastName;
            string firstName = s_info.FirstName;
            string patronymic = s_info.Patronymic;
            seriesList.Add(
                string.Format("{0} {1} {2} {3}", this.StudentID, lastName, firstName, patronymic));

            //select student marks
            marksList.Add(StudentDAL.GetStudentSubjectMarks(this.StudentID,
                (from subj in this.sbjcts
                 where subj.Title == this.comboSubject.SelectedItem.ToString()
                 select subj.SubjectID).First(), studyYearStart));

            try
            {
                this.chartProgress.BackImage = "no_marks_on_subject.png";
                this.chartProgress.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.chartProgress.Series.Clear();
            for (int i = 0; i < seriesList.Count; i++)
            {
                // Add series.
                Series series = this.chartProgress.Series.Add(seriesList[i]);
                series.XValueType = ChartValueType.Date;
                series.YValueType = ChartValueType.Double;

                if (marksList[i].Count > 0)
                    this.chartProgress.BackImage = string.Empty;
                series.Points.Clear();
                foreach (MarkInfo info in marksList[i])
                {
                    series.Points.AddXY(info.Date, (double)info.MarkValue);
                }
            }
        }
    }
}
