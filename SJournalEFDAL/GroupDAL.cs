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

        public static int NewGroup(int teacherID, string subject, string gradeSection, string description)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                //get gradeID using gradeSection
                int gradeID = (from grade in context.Grades where grade.GradeNo + grade.Section == gradeSection select grade.GradeID).FirstOrDefault();
                if (gradeID == 0)
                    throw new ArgumentOutOfRangeException("Grade name is invalid!");
                //get subjectID
                int subjID = (from subj in context.Subjects where subj.Title == subject select subj.SubjectID).FirstOrDefault();
                if (subjID == 0)
                    throw new ArgumentOutOfRangeException("Subject title is invalid!");


                    Group newGroup = new Group
                    {
                        TeacherID = teacherID,
                        SubjectID = subjID,
                        GradeID = gradeID,
                        Description = description
                    };

                    context.Groups.Add(newGroup);
                    context.SaveChanges();

                    return newGroup.GroupID;
            }
        }

        public static void UpdateGroup(int groupID, int teacherID, string subject, string gradeSection, string description)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                //get gradeID using gradeSection
                int gradeID = (from grade in context.Grades where grade.GradeNo + grade.Section == gradeSection select grade.GradeID).FirstOrDefault();
                if (gradeID == 0)
                    throw new ArgumentOutOfRangeException("Grade name is invalid!");
                //get subjectID
                int subjID = (from subj in context.Subjects where subj.Title == subject select subj.SubjectID).FirstOrDefault();
                if (subjID == 0)
                    throw new ArgumentOutOfRangeException("Subject title is invalid!");


                Group groupToUpdate = context.Set<Group>().Find(groupID);

                groupToUpdate.GroupID = groupID;
                groupToUpdate.GradeID = gradeID;
                groupToUpdate.SubjectID = subjID;
                groupToUpdate.TeacherID = teacherID;
                groupToUpdate.Description = description;
                context.SaveChanges();
            }
        }

        public static void AddStudentToGroup(int groupID, int studentID)
        {
            using (SchoolJournalEntities context = new SchoolJournalEntities())
            {
                context.Database.ExecuteSqlCommand(
                    string.Format("INSERT INTO student_group(group_id,student_id) VALUES({0},{1})",groupID,studentID));
                context.SaveChanges();
            }
        }
    }
}
