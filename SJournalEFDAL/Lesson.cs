//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SJournalEFDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lesson
    {
        public Lesson()
        {
            this.teachers = new HashSet<Teacher>();
            this.lesson_student = new HashSet<lesson_student>();
        }
    
        public int LessonID { get; set; }
        public System.DateTime Date { get; set; }
        public int NumberOfHours { get; set; }
        public string Theme { get; set; }
        public int SubjectID { get; set; }
        public int GradeID { get; set; }
        public string HomeTask { get; set; }
    
        public virtual Grade grade { get; set; }
        public virtual Subject subject { get; set; }
        public virtual ICollection<Teacher> teachers { get; set; }
        public virtual ICollection<lesson_student> lesson_student { get; set; }
    }
}
