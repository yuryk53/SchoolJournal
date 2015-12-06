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

        public static List<Subject> GetGradeSubjects(int gradeID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                var subjts = from subj in context.Subjects
                             from lesson in context.Lessons
                             where subj.SubjectID == lesson.SubjectID &&
                                   lesson.GradeID == gradeID
                             select subj;
                return subjts.ToList();
            }
        }
    }
}
