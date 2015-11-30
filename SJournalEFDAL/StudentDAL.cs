using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
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

        public static List<StudentInfo> GetAllStudentsOnTheLesson(int lessonID)
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
                               
                List<StudentInfo> stds = new List<StudentInfo>();
                foreach (Student s in students)
                {
                    stds.Add(new StudentInfo(s));
                }

                return stds;
            }
        }
    }
}
