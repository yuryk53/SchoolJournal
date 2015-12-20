using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class ParentDAL
    {
        public static ParentInfo GetParentInfo(int parentID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                Parent p = context.Set<Parent>().Find(parentID);

                if (p != null)
                {
                    ParentInfo info = new ParentInfo(p);
                    return info;
                }
                else throw new ArgumentOutOfRangeException("Parent ID was not found in the DB!");
            }
        }

        public static DataTable GetParentStudents(int parentID)
        {
            return Util.PopulateFromStoredProcedure("getParentStudents", new SqlParameter("@parent_id", parentID));
        }

        public static List<string> GetParentNames()
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var parents = from parent in context.parentsList
                              select    parent.Parent_ID  + " " +
                                        parent.Last_Name  + " " +
                                        parent.First_Name + " " +
                                        parent.Patronymic;
                return parents.ToList();
            }
        }

        public static void DeleteParent(int parentID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                Parent parentToDelete = context.Set<Parent>().Find(parentID);

                context.Parents.Remove(parentToDelete);
                context.SaveChanges();
            }
        }

        public static int AddNewParent(Parent newParent)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                if (!Util.IsValidEmail(newParent.user.Email))
                    throw new ArgumentException("Email string is not a valid email!");
                context.Parents.Add(newParent);
                context.SaveChanges();
                return newParent.ParentID;
            }
        }

    }
}
