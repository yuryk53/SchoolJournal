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
using System.Data.Entity;

namespace SchoolJournalGUI
{
    public partial class JournalViewWindow : Form
    {
        private int TeacherID { get; set; }
        private List<Grade> teacherGrades;
        private List<string> studyYears;
        private List<Subject> teacherSubjects;
        public JournalViewWindow(int teacherID)
        {
            InitializeComponent();
            this.TeacherID = teacherID;
            this.teacherGrades = AttendanceJournalDAL.GetTeacherGrades(this.TeacherID);
            this.teacherSubjects = AttendanceJournalDAL.GetTeacherSubjects(this.TeacherID);
            if (this.teacherSubjects == null)
            {
                MessageBox.Show("Error occured! Teacher tells no subjects!");
                this.Close();
            }
        }

        private void JournalViewWindow_Load(object sender, EventArgs e)
        {
            lblTeacher.Text = TeacherID.ToString();

            foreach (Subject s in teacherSubjects)
                comboBoxSubject.Items.Add(s.Title);
            comboBoxSubject.SelectedIndex = 0;
            comboBoxSubject.SelectedIndexChanged += comboBoxSubject_SelectedIndexChanged;

            //init grade ComboBox
            foreach (Grade g in this.teacherGrades)
                comboBoxGrade.Items.Add(g.ToString());
            comboBoxGrade.SelectedIndex = 0;

            //init study year combo box
            //comboStudyYear.DataSource = AttendanceJournalDAL.GetStudyYears(TeacherID, 
            studyYears = AttendanceJournalDAL.GetStudyYears(this.TeacherID,
                                                                         (int)this.teacherGrades[comboBoxGrade.SelectedIndex].GradeNo,
                                                                         7);

            //-------------------only this order
            

            UpdateComboStudyYear();
            UpdateGridJournalData();
            //------------------only this order
            

            gridJournal.AllowUserToAddRows = false;
            gridJournal.AllowUserToDeleteRows = false;

            this.gridJournal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridJournal.ColumnHeadersHeight = 55;

            gridJournal.CellPainting += DataGridView_CellPaintingRotate; //rotate date header
        }

        private void UpdateGridJournalData()
        {
            int yearStart = int.Parse(comboStudyYear.SelectedItem.ToString().Split('-')[0]);
            int yearEnd = int.Parse(comboStudyYear.SelectedItem.ToString().Split('-')[1]);
            DateTime studyYearStart = new DateTime(yearStart, 9, 1); //1st Septemper
            DateTime studyYearEnd = new DateTime(yearEnd, 7, 31); //31st of June

            gridJournal.DataSource = AttendanceJournalDAL.BuildDataTable(TeacherID,
                                    (int)this.teacherGrades[comboBoxGrade.SelectedIndex].GradeNo,
                                    this.teacherGrades[comboBoxGrade.SelectedIndex].Section,
                                    this.comboBoxSubject.SelectedItem.ToString(),
                                    studyYearStart,
                                    studyYearEnd);
        }

        private void DataGridView_CellPaintingRotate(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Vertical text from column 0, or adjust below, if first column(s) to be skipped
            if (e.RowIndex == -1 && e.ColumnIndex > 1)
            {
                e.PaintBackground(e.CellBounds, true);
                e.Graphics.TranslateTransform(e.CellBounds.Left, e.CellBounds.Bottom);
                e.Graphics.RotateTransform(270);
                e.Graphics.DrawString(e.FormattedValue.ToString(), e.CellStyle.Font, Brushes.Black, 5, 5);
                e.Graphics.ResetTransform();
                e.Handled = true;
            }
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            studyYears = AttendanceJournalDAL.GetStudyYears(this.TeacherID,
                                                                         (int)this.teacherGrades[comboBoxGrade.SelectedIndex].GradeNo,
                                                                         7);
            if (studyYears.Count == 0)
                studyYears.Add(GetCurrentStudyYear());
            UpdateComboStudyYear();
            UpdateGridJournalData();
        }

        private string GetCurrentStudyYear()
        {
            if(DateTime.Now.Month<=7 && DateTime.Now.Month>=1)
            {
                return string.Format("{0}-{1}", DateTime.Now.Year-1, DateTime.Now.Year); 
            }
            else
                return string.Format("{0}-{1}", DateTime.Now.Year, DateTime.Now.Year+1);
        }

        private void UpdateComboStudyYear()
        {
            comboStudyYear.Items.Clear();
            foreach (string year in studyYears)
            {
                comboStudyYear.Items.Add(year);
            }
            if(comboStudyYear.Items.Count>0)
                comboStudyYear.SelectedIndex = 0;
        }

        private void gridJournal_DataSourceChanged(object sender, EventArgs e)
        {
            toolStripRowsFetched.Text = string.Format("Rows fetched: {0}", gridJournal.Rows.Count.ToString());
        }

        private void comboStudyYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridJournalData();
        }

        private void comboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGridJournalData();
        }
    }
}
