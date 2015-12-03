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

        public UserInfo(int userID, string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                                          string email, string password, string phone)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DoB = dateOfBirth;
            Email = email;
            Password = password;
            Phone = phone;
        }

        public User GetUser()
        {
            return new User
            {
                UserID = UserID,
                FirstName = FirstName,
                LastName = LastName,
                Patronymic = Patronymic,
                DateOfBirth = DoB,
                Email = Email,
                Password = Password,
                Phone = Phone
            };
        }
    }

    public sealed class StudentInfo : UserInfo
    {
        public readonly int GradeID;
        public readonly int GradeNo;
        public readonly string Section;
        public readonly DateTime? DateOfJoin;
        public int StudentID { get { return base.UserID; } }
        public string GradeName { get { return string.Format("{0}{1}", GradeNo, Section); } }
        public StudentInfo(Student s) : base(s.user)
        {
            GradeID = s.GradeID;
            GradeNo = s.grade.GradeNo;
            Section = s.grade.Section;
            DateOfJoin = s.DateOfJoin;
        }
        public StudentInfo(int userID, string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                           string email, string password, string phone, int gradeID, int gradeNo, string section,
                           DateTime? dateOfJoin)
            : base(userID, firstName, lastName, patronymic, dateOfBirth, email, password, phone)
        {
            GradeID = gradeID;
            GradeNo = gradeNo;
            Section = section;
            DateOfJoin = dateOfJoin;
        }

        public StudentInfo(int userID, string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                           string email, string password, string phone, int gradeID, string gradeSection,
                           DateTime? dateOfJoin)
            : base(userID, firstName, lastName, patronymic, dateOfBirth, email, password, phone)
        {
            GradeID = gradeID;
            GradeNo = int.Parse(gradeSection.Substring(0, gradeSection.Length - 1)); //gradeNo;
            Section = gradeSection[gradeSection.Length-1]+"";
            DateOfJoin = dateOfJoin;
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
        public TeacherInfo(int userID, string firstName, string lastName, string patronymic, DateTime? dateOfBirth,
                                          string email, string password, string phone, string specialization, string category)
            : base(userID, firstName, lastName, patronymic, dateOfBirth, email, password, phone)
        {
            this.Specialization = specialization;
            this.Category = category;
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
