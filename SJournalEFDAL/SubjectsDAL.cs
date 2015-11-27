using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class SubjectsDAL
    {
        public static List<Subject> GetAllSubjects()
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                return context.Subjects.ToList();
            }
        }
    }
}
