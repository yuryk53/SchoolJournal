using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SJournalEFDAL
{
    public interface ILessonInfo
    {
        int GradeNo { get; }
        int LessonID { get; }
        string GradeSection { get; }
        string Subject { get; }
        DateTime Date { get; }
    }

    public class LessonInfo : ILessonInfo
    {
        public int GradeNo { get { return _gradeNo; } }
        public int LessonID { get { return _lessonID; } }
        public string GradeSection { get { return _gradeSection; } }
        public string Subject { get { return _subject; } }
        public DateTime Date { get { return _date; } }
        
        int _gradeNo, _lessonID;
        string _subject, _gradeSection;
        DateTime _date;
        public LessonInfo(Lesson l)
        {
            _gradeNo = l.grade.GradeNo;
            _lessonID = l.LessonID;
            _subject = String.Copy(l.subject.Title);
            _gradeSection = String.Copy(l.grade.Section);
            _date = l.Date;
        }
      
    }

    public class LessonDAL
    {
        public static void PlaceMark(int lessonID, int studentID, decimal? markValue, bool isPresent = true)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                try
                {
                    //context.placeMark(lessonID, studentID, markValue, isPresent);
                    int markID = -1;
                    if (markValue.HasValue) //check for correct value
                    {
                        var value = from mark in context.Marks
                                     where mark.Value == markValue
                                     select mark;
                        if (value.Count() == 0)
                            throw new ArgumentOutOfRangeException(string.Format("Mark value '{0}' is incorrect!", markValue));
                        markID = value.First().MarkID;
                    }

                    var less_student = from record in context.lesson_student
                                       where record.LessonID == lessonID &&
                                             record.StudentID == studentID
                                       select record;
                    if (markID != -1)
                        less_student.First().MarkID = markID;
                    less_student.First().IsPresent = isPresent;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception("PlaceMark failed!"+ex.Message+"\n"+ex.InnerException.Message);
                }    
            }
        }

        public static ILessonInfo StartNewLesson(string subj_title, string theme, int numberOfHours, string gradeName, string homeTask, int teacherID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                ObjectParameter output = new ObjectParameter("addedLesson_id", typeof(int));
                context.startNewLesson(subj_title, theme, numberOfHours, gradeName, homeTask, teacherID, output);
                context.SaveChanges();

                int lessonID = (int)output.Value;
                
                var lsn = (from lesson in context.Lessons where lesson.LessonID==lessonID select lesson).FirstOrDefault();
                return new LessonInfo(lsn);
            }
        }
    }
}
