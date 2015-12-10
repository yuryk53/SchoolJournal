using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SJournalEFDAL
{
    public class AttendanceJournalDAL
    {
        public static DataTable BuildDataTable(int teacherID, int gradeNo, string section, string subjectTitle,
            DateTime studyYearStart, DateTime studyYearEnd)
        {
            SchoolJournalEntities context = new SchoolJournalEntities();

            DataTable dt = new DataTable();

            var records = from j in context.attendanceJournal
                          where j.TeacherID == teacherID && j.Grade == gradeNo && j.Section==section
                                && j.Date <= studyYearEnd && j.Date >= studyYearStart
                                && j.Subject.Equals(subjectTitle)
                          select j;
            var dates = (from rec in records select rec.Date).Distinct();

            dt.Columns.Add(new DataColumn("ID", typeof(int))); 
            dt.Columns.Add(new DataColumn("Last Name, First Name", typeof(string)));
            dt.PrimaryKey = new DataColumn[] {dt.Columns[0]};

            foreach (var date in dates)
            {
                //string dateString = date.ToString("dd.MM.yy");
                string dateString = string.Format("{0}\n{1}", date.ToString("dd.MM.yy"), date.ToShortTimeString());
                if (dt.Columns.Contains(dateString))
                    continue;
                DataColumn dc = new DataColumn(dateString, typeof(string));
                
                dt.Columns.Add(dc);
                
            }

            foreach (var rec in records)
            {
                DataRow dr;
                string nameSurname = string.Format("{0} {1}", rec.Last_Name, rec.First_Name);
                if (!dt.Rows.Contains(rec.StudentID))
                {
                    dr = dt.NewRow();
                    dr[0] = rec.StudentID;
                    dr[1] = string.Format("{0} {1}", rec.Last_Name, rec.First_Name);
                }
                else dr = dt.Rows.Find(rec.StudentID);
                string dateString = string.Format("{0}\n{1}", rec.Date.ToString("dd.MM.yy"), rec.Date.ToShortTimeString());
                dr[dateString] = rec.Mark == null ? (rec.IsPresent.GetValueOrDefault() ? "." : "a") : rec.Mark.ToString();
                
                if(!dt.Rows.Contains(rec.StudentID))
                    dt.Rows.Add(dr);
            }
            context.Dispose();
            return dt;
        }

        public static List<string> GetStudyYears(int teacherID, int gradeNo, int yearEndMonth)
        {
            SchoolJournalEntities context = new SchoolJournalEntities();

            HashSet<string> studyYears = new HashSet<string>();

            var records = from j in context.attendanceJournal
                          where j.TeacherID == teacherID && j.Grade == gradeNo
                          select j;
            var dates = (from rec in records select rec.Date).Distinct();

            foreach (var date in dates)
            {
                //semester begining - 01.09; semester ending - 31.07;
                if (date.Month < yearEndMonth) //period from New Year to summer - semester beginning - the previous year
                {
                    string studyYear = string.Format("{0}-{1}", date.Year - 1, date.Year);
                    studyYears.Add(studyYear);
                }
                else
                {
                    string studyYear = string.Format("{0}-{1}", date.Year, date.Year+1);
                    studyYears.Add(studyYear);
                }          
            }
            context.Dispose();
            return studyYears.ToList();
        }
        public static List<Grade> GetTeacherGrades(int teacherID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var grades = from lesson in context.Lessons
                             from teacher in context.Teachers
                             from grade in context.Grades
                             where teacher.lessons.Contains(lesson) &&
                                   teacher.TeacherID == teacherID &&
                                   lesson.GradeID == grade.GradeID
                             select grade;
                return grades.Distinct().ToList();
            }
        }
        public static List<Subject> GetTeacherSubjects(int teacherID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var subjectIDs = from lesson in context.Lessons
                               from teacher in context.Teachers
                               where teacher.TeacherID == teacherID &&
                                     teacher.lessons.Contains(lesson)
                               select lesson.SubjectID;

                var subjects = from subject in context.Subjects
                               where subjectIDs.Contains(subject.SubjectID)
                               select subject;

                return subjects.ToList();
            }
        }
    }
}
