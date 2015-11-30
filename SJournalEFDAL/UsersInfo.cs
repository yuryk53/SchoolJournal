using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SJournalEFDAL
{
    public class UserInfo
    {
        public int UserID { get; protected set; }
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Patronymic { get; protected set; }
        public DateTime? DoB { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Phone { get; protected set; }

        public UserInfo(User u)
        {
            UserID = u.UserID;
            FirstName = u.FirstName;
            LastName = u.LastName;
            Patronymic = u.Patronymic;
            DoB = u.DateOfBirth;
            Email = u.Email;
            Password = u.Password;
            Phone = u.Phone;
        }
    }

    public sealed class StudentInfo : UserInfo
    {
        public readonly int GradeID;
        public readonly int GradeNo;
        public readonly string Section;
        public readonly DateTime? DateOfJoin;
        public int StudentID { get { return base.UserID; } }
        public StudentInfo(Student s) : base(s.user)
        {
            GradeID = s.GradeID;
            GradeNo = s.grade.GradeNo;
            Section = s.grade.Section;
            DateOfJoin = s.DateOfJoin;
        }
    }


    public sealed class TeacherInfo : UserInfo
    {
        public readonly string Specialization;
        public readonly string Category;
        public int TeacherID { get { return base.UserID; } }
        public TeacherInfo(Teacher t)
            : base(t.user)
        {
            Specialization = t.Specialization;
            Category = t.Category;
        }
    }

    public sealed class AdminInfo : UserInfo
    {
        public readonly bool HasDeleteRights;
        public int AdminID { get { return base.UserID; } }
        public AdminInfo(Admin a)
            : base(a.user)
        {
            HasDeleteRights = a.has_delete_rights;
        }
    }

    public sealed class ParentInfo : UserInfo
    {
        public readonly string Job;
        public int ParentID { get { return base.UserID; } }
        public ParentInfo(Parent p)
            : base(p.user)
        {
            Job = p.Job;
        }
    }
}
