using System;
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
