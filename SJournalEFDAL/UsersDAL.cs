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

        public static int AddNewUser(UserInfo u) //returns new UserID
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                User newUser = u.GetUser();
                context.Users.Add(newUser);
                context.SaveChanges();

                return newUser.UserID;
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

        public static void UpdateUserInfo(UserInfo info)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                User userToUpdate = (User)context.Set<User>().Find(info.UserID);
                userToUpdate.UserID = info.UserID;
                userToUpdate.LastName = info.LastName;
                userToUpdate.FirstName = info.FirstName;
                userToUpdate.Patronymic = info.Patronymic;
                userToUpdate.Password = info.Password;
                userToUpdate.Email = info.Email;
                userToUpdate.Phone = info.Phone;
                userToUpdate.DateOfBirth = info.DoB;

                context.SaveChanges();               
            }
            
        }

        public static void ChangeUserPassword(int UserID, string oldPass, string newPass)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                if (newPass.Length > 0)
                {
                    User userToUpdate = (User)context.Set<User>().Find(UserID);
                    if (userToUpdate.Password.Equals(oldPass))
                    {
                        userToUpdate.Password = newPass;
                        context.SaveChanges();
                    }
                    else throw new ArgumentException("Old password is incorrect!");
                }
                else throw new ArgumentOutOfRangeException("New password is empty!");
            }
        }

        public static void UpdateUser(UserInfo u)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                User userToUpdate = (User)context.Set<User>().Find(u.UserID);

                if(userToUpdate==null)
                    throw new ArgumentException("UserID is incorrect!");
                userToUpdate.FirstName = u.FirstName;
                userToUpdate.LastName = u.LastName;
                userToUpdate.Patronymic = u.Patronymic;
                userToUpdate.DateOfBirth = u.DoB;
                userToUpdate.Email = u.Email;
                userToUpdate.Password = u.Password;
                userToUpdate.Phone = u.Phone;

                context.SaveChanges();
            }
        }
        public static void DeleteUser(int userID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                User userToDelete = (User)context.Set<User>().Find(userID);

                if (userToDelete != null)
                {
                    context.Users.Remove(userToDelete);
                    context.SaveChanges();
                }
                else throw new ArgumentOutOfRangeException("Invalid userID!");
                
            }
        }
    }
}
