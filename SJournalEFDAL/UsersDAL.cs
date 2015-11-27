using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace SJournalEFDAL
{
    public enum UserCategory
    {
        PARENT,
        TEACHER,
        ADMIN,
        STUDENT,
        NONE
    }

    public class UsersDAL
    {
        public static User GetUserByCredentials(string email, string password)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var user = (from usr in context.Users
                            where usr.Email == email && usr.Password == password
                            select usr).FirstOrDefault();
                return user;
            }
        }

        public static UserCategory GetUserCategory(int userID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                bool isParent = (from usr in context.Parents
                                 where usr.ParentID == userID
                                 select usr).Count() > 0;
                bool isTeacher = (from usr in context.Teachers
                                 where usr.TeacherID == userID
                                 select usr).Count() > 0;
                bool isAdmin = (from usr in context.Admins
                                 where usr.AdminID == userID
                                 select usr).Count() > 0;
                bool isStudent = (from usr in context.Students
                                 where usr.StudentID == userID
                                 select usr).Count() > 0;

                if (isParent)
                    return UserCategory.PARENT;
                else if (isTeacher)
                    return UserCategory.TEACHER;
                else if (isAdmin)
                    return UserCategory.ADMIN;
                else if (isStudent)
                    return UserCategory.STUDENT;
                else return UserCategory.NONE;
                
            }
        }
    }
}
