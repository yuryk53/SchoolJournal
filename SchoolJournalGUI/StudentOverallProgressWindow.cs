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
using System.Windows.Forms.DataVisualization.Charting;

namespace SchoolJournalGUI
{
    public partial class StudentOverallProgressWindow : Form
    {
        SortedSet<string> subjects = null;
        List<Subject> sbjcts = null;
        int StudentID { get; set; }
        public StudentOverallProgressWindow(int studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void StudentOverallProgressWindow_Load(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            this.subjects = new SortedSet<string>();

            sbjcts = SubjectsDAL.GetGradeSubjects(StudentDAL.GetStudentGradeID(this.StudentID));
            foreach (Subject s in sbjcts)
                this.subjects.Add(s.Title);

            //gain marks list on each subject
            List<string> seriesList = new List<string>();
            List<List<MarkInfo>> marksList = new List<List<MarkInfo>>();

            DateTime studyYearStart;  //= new DateTime(yearStart, 9, 1); //1st Septemper
            if (DateTime.Now.Month <= 7) //it's previous study year
            {
                studyYearStart = new DateTime(DateTime.Now.Year - 1, 9, 1); //1st Septemper 
            }
            else studyYearStart = new DateTime(DateTime.Now.Year, 9, 1);

            this.Text = string.Format("My overall progress - School Journal" +
               " - Results on the {0}/{1} study year", studyYearStart.Year, studyYearStart.Year + 1);

            foreach (Subject s in this.sbjcts)
            {
                if (seriesList.Contains(s.Title))
                    continue;
                seriesList.Add(s.Title);

                //select student marks
                marksList.Add(StudentDAL.GetStudentSubjectMarks(this.StudentID, s.SubjectID, studyYearStart));
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
