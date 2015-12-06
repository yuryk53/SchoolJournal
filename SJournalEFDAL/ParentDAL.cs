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
    }
}
