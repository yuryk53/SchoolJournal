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
    public partial class StudentHomeTasks : Form
    {
        public DateTime IntervalStart { get; set; }
        public DateTime IntervalEnd { get; set; }
        int StudentID { get; set; }
        public StudentHomeTasks(int studentID)
        {
            InitializeComponent();
            this.StudentID = studentID;
        }

        private void StudentHomeTasks_Load(object sender, EventArgs e)
        {
            DateIntervalDialog dlg = new DateIntervalDialog();
            dlg.FormClosed += (o, s) =>
            {
                this.IntervalStart = dlg.IntervalStart;
                this.IntervalEnd = dlg.IntervalEnd;
            };
            dlg.ShowDialog();

            StudentInfo info = StudentDAL.GetStudentInfo(this.StudentID);
            this.lblGrade.Text = info.GradeName;
            this.lblStudentID.Text = info.StudentID.ToString();
            this.lblDateInteval.Text = 
                string.Format("[{0}] - [{1}]", this.IntervalStart.ToShortDateString(), this.IntervalEnd.ToShortDateString());

            UpdateHomeTaskDataGridView();
        }

        private void UpdateHomeTaskDataGridView()
        {
            DataTable dt = new DataTable();

            List<HomeTask> homeTaskList = StudentDAL.GetStudentHomeTaskByDate(this.StudentID, this.IntervalStart, this.IntervalEnd);

            SortedDictionary<string, List<HomeTask>> homeTaskDictionary = new SortedDictionary<string, List<HomeTask>>();
            Dictionary<string, int> homeTaskDateCount = new Dictionary<string, int>();

            foreach (HomeTask t in homeTaskList)
            {
                string key = DateToString(t.Date);
                if (homeTaskDictionary.ContainsKey(key))
                {
                    homeTaskDictionary[key].Add(t);
                    homeTaskDateCount[key]++;
                }
                else
                {
                    homeTaskDictionary.Add(key, new List<HomeTask>());
                    homeTaskDictionary[key].Add(t);

                    homeTaskDateCount.Add(key, 1);
                }
            }

            //add columns
            foreach (string date in homeTaskDictionary.Keys)
            {
                dt.Columns.Add(new DataColumn(date));
            }

            //calculate number of rows needed
            int rowsCount = 0;
            int[] tasksCount = homeTaskDateCount.Values.ToArray();
            Array.Sort(tasksCount);
            rowsCount = tasksCount.LastOrDefault();

            for (int i = 0; i < rowsCount; i++)
            {
                DataRow dr = dt.NewRow();
                foreach (DataColumn dc in dt.Columns)
                {
                    if (homeTaskDictionary[dc.ColumnName].Count>i)
                    {
                        dr[dc] = homeTaskDictionary[dc.ColumnName][i].ToString();
                    }
                }
                dt.Rows.Add(dr);
            }

            this.dataGridViewHomeTask.DataSource = dt;
        }

        string DateToString(DateTime date)
        {
            return date.ToString("dd.MM.yy");
        }
    }
}
