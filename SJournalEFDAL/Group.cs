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
    
    public partial class Group
    {
        public Group()
        {
            this.students = new HashSet<Student>();
        }
    
        public int GroupID { get; set; }
        public int GradeID { get; set; }
        public int SubjectID { get; set; }
        public string Description { get; set; }
        public int TeacherID { get; set; }
    
        public virtual Grade grade { get; set; }
        public virtual Teacher teacher { get; set; }
        public virtual Subject subject { get; set; }
        public virtual ICollection<Student> students { get; set; }
    }
}