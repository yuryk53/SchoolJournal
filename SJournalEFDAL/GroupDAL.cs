using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class GroupDAL
    {
        public static DataTable GetGroupStudents(int groupID)
        {
            return Util.PopulateFromStoredProcedure("getGroupStudents", new SqlParameter("@group_id", groupID));
        }
    }
}
