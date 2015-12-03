using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Entity.Core.Objects;
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

        public static int AddNewStudent(string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
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

                var userID = (from user in context.Users
                              where user.FirstName == firstName &&
                                    user.LastName == lastName &&
                                    user.Patronymic == patronymic &&
                                    user.DateOfBirth == dateOfBirth &&
                                    user.Email == email &&
                                    user.Password == password &&
                                    user.Phone == phone
                              select user.UserID).First();
                return userID;
                                                               
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

        public static void UpdateStudent(int studentID, string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                                          string email, string password, string phone, string gradeName, DateTime? dateOfJoin)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                
                Student s = context.Set<Student>().Find(studentID);
                if (s == null)
                    throw new ArgumentNullException("StudentID to update cannot be null!");

                UsersDAL.UpdateUser(studentID, firstName, lastName, patronymic, dateOfBirth, email, password, phone);

                s.DateOfJoin = dateOfJoin;
                //find grade ID
                var gID = (from grade in context.Grades where (grade.GradeNo+grade.Section).Equals(gradeName) select grade.GradeID);
                if (gID.Count() > 0)
                {
                    s.GradeID = gID.First();
                }
                else throw new ArgumentException("Invalid grade name!");
                context.SaveChanges();
            }
        }

    }
}
