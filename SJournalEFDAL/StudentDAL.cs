using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public interface IStudentInfo
    {
        int StudentID {get;}
        string LastName { get; }
        string FirstName { get; }
    }

    public class StudentInfo : IStudentInfo
    {
        
        public string LastName{get { return _lastName; }}
        public string FirstName{get { return _firstName; }}
        public int StudentID { get { return _studentID; } }

        int _studentID;
        string _lastName, _firstName;

        public StudentInfo(Student s)
        {
            _studentID = s.user.UserID;
            _lastName = s.user.LastName;
            _firstName = s.user.FirstName;
            
        }
    }

    public class StudentDAL
    {
        public static double GetAvgMark(int studentID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                ObjectParameter output = new ObjectParameter("avg_mark", typeof(int));

                context.getAvgMark(studentID, output);

                return (double)output.Value;
            }
        }

        public static void AddNewStudent(string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                                          string email, string password, string phone, string gradeName)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                context.addNewStudent(firstName,
                                      lastName,
                                      patronymic,
                                      dateOfBirth,
                                      email,
                                      password,
                                      phone,
                                      gradeName);
                context.SaveChanges();
            }
        }

        public static List<IStudentInfo> GetAllStudentsOnTheLesson(int lessonID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var studentIDs = from lessonStudent in context.lesson_student
                                 where lessonStudent.LessonID == lessonID
                                 select lessonStudent.StudentID;
                var students = from student in context.Students
                               where studentIDs.Contains(student.StudentID)
                               orderby student.user.LastName, student.user.FirstName
                               select student;
                               
                List<IStudentInfo> stds = new List<IStudentInfo>();
                foreach (Student s in students)
                    stds.Add(new StudentInfo(s));
                return stds;
            }
        }
    }
}
