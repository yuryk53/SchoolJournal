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
    public partial class ChildProgressWindow : Form
    {
        int ParentID { get; set; }
        DataTable students = null;
        SortedSet<string> subjects = null;
        List<Subject> sbjcts = null;
        List<int> _selectedStudentIDs = null;
        List<int> SelectedStudentIDs
        {
            get
            {
                _selectedStudentIDs = new List<int>();
                if (radioShowAll.Checked)
                {
                    foreach (DataRow dr in students.Rows)
                    {
                        int studID = int.Parse(dr[0].ToString());
                        _selectedStudentIDs.Add(studID);
                    }
                }
                else
                {
                    _selectedStudentIDs.Add(
                        int.Parse(
                            this.comboChild.SelectedItem.ToString().Split(' ')[0] //student id
                        )
                    );
                }
                return _selectedStudentIDs;
            }
        }
        bool IsLoaded { get; set; }

        public ChildProgressWindow(int parentID)
        {
            InitializeComponent();
            this.ParentID = parentID;
            IsLoaded = false;
        }

        private void ChildProgressWindow_Load(object sender, EventArgs e)
        {
            students = ParentDAL.GetParentStudents(this.ParentID);

            //populate combo box STUDENTS
            foreach (DataRow dr in students.Rows)
            {
                string studID = dr[0].ToString();
                string lastName = dr[1].ToString();
                string firstName = dr[2].ToString();
                string patronymic = dr[3].ToString();
                comboChild.Items.Add(
                    string.Format("{0} {1} {2} {3}", studID, lastName, firstName, patronymic));
            }
            if (comboChild.Items.Count > 0)
                comboChild.SelectedItem = comboChild.Items[0];
            else comboChild.Enabled = false;


            //populate combo box SUBJECTS
            UpdateSubjectsComboBox();


            // Set palette.
            this.chartProgress.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chartProgress.Titles.Add("Student progress");

            IsLoaded = true;
        }

        private void UpdateSubjectsComboBox()
        {
            this.subjects = new SortedSet<string>();
            foreach (int studentID in SelectedStudentIDs)
            {
                sbjcts = SubjectsDAL.GetGradeSubjects(StudentDAL.GetStudentGradeID(studentID));
                foreach (Subject s in sbjcts)
                    this.subjects.Add(s.Title);
            }

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

        private void comboBoxChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.radioShowAll.Checked = false;
           
            //update subjects list
            UpdateSubjectsComboBox();
            
            //update chart
            UpdateChart();

        }

        private void UpdateChart()
        {
            // Data arrays.
            List<string> seriesList = new List<string>();
            List<List<MarkInfo>> marksList = new List<List<MarkInfo>>();

            DateTime studyYearStart;  //= new DateTime(yearStart, 9, 1); //1st Septemper
            if(DateTime.Now.Month<=7) //it's previous study year
            {
                studyYearStart = new DateTime(DateTime.Now.Year-1, 9, 1); //1st Septemper 
            }
            else studyYearStart = new DateTime(DateTime.Now.Year, 9, 1);

            this.Text = string.Format("Child progress - School Journal"+
               " - Results on the {0}/{1} study year", studyYearStart.Year, studyYearStart.Year + 1);

            foreach (DataRow dr in students.Rows)
            {
                int studID = int.Parse(dr[0].ToString());
                if (SelectedStudentIDs.Contains(studID))
                {
                    string lastName = dr[1].ToString();
                    string firstName = dr[2].ToString();
                    string patronymic = dr[3].ToString();
                    seriesList.Add(
                        string.Format("{0} {1} {2} {3}", studID, lastName, firstName, patronymic));

                    //select student marks
                    marksList.Add(StudentDAL.GetStudentSubjectMarks(studID, 
                        (from subj in this.sbjcts
                         where subj.Title==this.comboSubject.SelectedItem.ToString()
                         select subj.SubjectID).First(), studyYearStart));
                }
            }
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

                if(marksList[i].Count>0)
                    this.chartProgress.BackImage = string.Empty;
                series.Points.Clear();
                foreach (MarkInfo info in marksList[i])
                {
                    series.Points.AddXY(info.Date, (double)info.MarkValue);
                }
            }
        }

        private void radioShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(IsLoaded)
                UpdateChart();
        }
    }
}
