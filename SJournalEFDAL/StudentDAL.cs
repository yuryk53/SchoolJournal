using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
namespace SJournalEFDAL
{
    public class MarkInfo
    {
        public DateTime Date { get; set; }
        public decimal MarkValue { get; set; }
        public MarkInfo() { }
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

        public static void UpdateStudent(StudentInfo si)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                
                Student s = context.Set<Student>().Find(si.StudentID);
                if (s == null)
                    throw new ArgumentNullException("StudentID to update cannot be null!");

                UsersDAL.UpdateUser(si);

                s.DateOfJoin = si.DateOfJoin;
                //find grade ID
                var gID = (from grade in context.Grades where (grade.GradeNo+grade.Section).Equals(si.GradeName) select grade.GradeID);
                if (gID.Count() > 0)
                {
                    s.GradeID = gID.First();
                }
                else throw new ArgumentException("Invalid grade name!");
                context.SaveChanges();
            }
        }

        public static void ShiftAllStudentsToNextGrade()
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (Student s in context.Students)
                        {
                            //if the current grade is the last one, the student is deleted!
                            int nextGradeID = GetNextGradeID(s.GradeID);
                            if (nextGradeID == -1) //delete student from school
                            {
                                UsersDAL.DeleteUser(s.StudentID);
                            }
                            else
                            {
                                s.GradeID = nextGradeID;
                            }
                        }
                        foreach (Group g in context.Groups)
                        {
                            int nextGradeID = GetNextGradeID(g.GradeID);
                            if (nextGradeID == -1) //delete student from school
                            {
                                context.Groups.Remove(g);
                            }
                            else
                            {
                                g.GradeID = nextGradeID;
                            }
                        }
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        static int GetNextGradeID(int currentGradeID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                Grade currentGrade = (from grade in context.Grades where grade.GradeID == currentGradeID select grade).FirstOrDefault();
                string section = currentGrade.Section;
                //check if current grade is last one, if yes, return -1
                int lastGradeNo = (from grade in context.Grades select grade.GradeNo).Max();
                if (currentGrade.GradeNo == lastGradeNo)
                    return -1;

                int nextGradeID = (from grade in context.Grades where grade.GradeNo == currentGrade.GradeNo + 1
                                                                      && (grade.Section==currentGrade.Section ||
                                                                          grade.Section==null)
                                   select grade.GradeID).FirstOrDefault();
                if (nextGradeID != 0)
                    return nextGradeID;
                else throw new Exception("GetNextGradeID() failed!");

            }
        }

        public static int GetStudentGradeID(int studentID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                Student s = context.Set<Student>().Find(studentID);

                if (s != null)
                {
                    return s.GradeID;
                }
                else throw new ArgumentOutOfRangeException("No such studentID=" + studentID); 
            }
        }

        public static List<MarkInfo> GetStudentSubjectMarks(int studentID, int subjectID, 
            DateTime fromDate)
        {
            List<MarkInfo> resultList = Util.PopulateFromStoredProcedure<MarkInfo>("getStudentSubjectMarks", 
                                                                                    dr=>{
                                                                                        return new MarkInfo
                                                                                        {
                                                                                            Date = DateTime.Parse(dr["Date"].ToString()),
                                                                                            MarkValue = decimal.Parse(dr["Value"].ToString())
                                                                                        };
                                                                                    },
                                                                                    new SqlParameter("@student_id", studentID),
                                                                                    new SqlParameter("@subject_id", subjectID),
                                                                                    new SqlParameter("@fromDate", fromDate)
                                                                                    );
            return resultList;
        }
    }
}
