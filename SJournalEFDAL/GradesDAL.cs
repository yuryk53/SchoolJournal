using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class GradesDAL
    {
        public static List<Grade> GetAllGrades()
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                return context.Grades.ToList();
            }
        }
    }
}
