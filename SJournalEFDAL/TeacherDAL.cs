﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Configuration;

namespace SJournalEFDAL
{
    public class TeacherDAL
    {
        public static DataTable GetTeacherStudents(int teacherID)
        {        
            return Util.PopulateFromStoredProcedure("getTeacherStudents", new SqlParameter("@teacher_id", teacherID));
        }

        /// <summary>
        /// Adds new teacher to the database.
        /// </summary>
        /// <param name="t"></param>
        /// <returns>ID of newly added teacher.</returns>
        public static int AddNewTeacher(TeacherInfo t)
        {    
            int userID;
            if (!Util.IsValidEmail(t.Email))
                throw new ArgumentException("Email string is not a valid email!");

            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    userID = UsersDAL.AddNewUser(t, dbContextTransaction.UnderlyingTransaction);
                    context.Teachers.Add(new Teacher
                    {
                        TeacherID = userID,
                        Category = t.Category,
                        Specialization = t.Specialization
                    });
                    context.SaveChanges();
                    dbContextTransaction.Commit();
                }
            }
            return userID;
        }

        public static void UpdateTeacher(TeacherInfo t)
        {
            if (!Util.IsValidEmail(t.Email))
                throw new ArgumentException("Email string is not a valid email!");

            UsersDAL.UpdateUser(t);
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                Teacher teacherToUpdate = context.Set<Teacher>().Find(t.TeacherID);
                teacherToUpdate.Specialization = t.Specialization;
                teacherToUpdate.Category = t.Category;
                context.SaveChanges();
            }
        }

        public static DataTable GetTeacherGroups(int teacherID)
        {
            return Util.PopulateFromStoredProcedure("getTeacherGroups", new SqlParameter("@teacher_id", teacherID));
        }

        public static TeacherInfo GetTeacher(int teacherID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var teachers = from t in context.Teachers where t.TeacherID == teacherID select t;
                return new TeacherInfo(teachers.First());
            }
        }
    }
}
