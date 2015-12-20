using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CryptSharp;

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
        //password - not hashed password
        public static User GetUserByCredentials(string email, string plainPassword)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                string cryptedPassword = Crypter.Blowfish.Crypt(plainPassword);
                var user = (from usr in context.Users
                            where usr.Email == email
                            select usr).ToList();
                foreach (User usr in user)
                {
                    if (Crypter.CheckPassword(plainPassword, usr.Password))
                    {
                        return usr;
                    }
                }
                return null;
            }
        }

        public static int AddNewUser(UserInfo u, System.Data.Common.DbTransaction transaction = null) //returns new UserID
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                if (transaction != null)
                {
                    context.Database.UseTransaction(transaction);
                }
                User newUser = u.GetUser();
                if (!Util.IsValidEmail(u.Email))
                    throw new ArgumentException("Email string is not a valid email!");
                newUser.Password = Crypter.Blowfish.Crypt(newUser.Password); //newUser entity contains uncrypted password!
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

        public static void UpdateUserInfo(UserInfo userInfo)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                User userToUpdate = (User)context.Set<User>().Find(userInfo.UserID);
                userToUpdate.UserID = userInfo.UserID;
                userToUpdate.LastName = userInfo.LastName;
                userToUpdate.FirstName = userInfo.FirstName;
                userToUpdate.Patronymic = userInfo.Patronymic;
                if (userToUpdate.Password == userInfo.Password) //password supplied is crypted already
                {
                    //do nothing - passwords already the same
                }
                else
                {
                    userToUpdate.Password = Crypter.Blowfish.Crypt(userInfo.Password);
                }
                if (!Util.IsValidEmail(userInfo.Email))
                    throw new ArgumentException("Email string is not a valid email!");
                userToUpdate.Email = userInfo.Email;
                userToUpdate.Phone = userInfo.Phone;
                userToUpdate.DateOfBirth = userInfo.DoB;

                context.SaveChanges();               
            }
            
        }

        /// <summary>
        /// Changes user password
        /// </summary>
        /// <param name="UserID">UserID</param>
        /// <param name="oldPass">old plain text password</param>
        /// <param name="newPass">new plain text password</param>
        public static void ChangeUserPassword(int UserID, string oldPass, string newPass)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                if (newPass.Length > 0)
                {
                    User userToUpdate = (User)context.Set<User>().Find(UserID);
                    //if (userToUpdate.Password.Equals(oldPass))
                    if(Crypter.CheckPassword(oldPass, userToUpdate.Password))
                    {
                        //userToUpdate.Password = newPass;
                        userToUpdate.Password = Crypter.Blowfish.Crypt(newPass);
                        context.SaveChanges();
                    }
                    else throw new ArgumentException("Old password is incorrect!");
                }
                else throw new ArgumentOutOfRangeException("New password is empty!");
            }
        }

        /// <summary>
        /// Updates a user
        /// </summary>
        /// <param name="u">New passwords supplied should be plain text!</param>
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
                if (!Util.IsValidEmail(u.Email))
                    throw new ArgumentException("Email string is not a valid email!");
                userToUpdate.Email = u.Email;
                if (userToUpdate.Password != u.Password) //new password supplied => crypt it!
                {
                    userToUpdate.Password = Crypter.Blowfish.Crypt(u.Password);
                }
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
