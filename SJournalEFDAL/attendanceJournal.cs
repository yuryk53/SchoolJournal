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
    
    public partial class attendanceJournal
    {
        public int StudentID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public Nullable<bool> IsPresent { get; set; }
        public Nullable<decimal> Mark { get; set; }
        public System.DateTime Date { get; set; }
        public byte Grade { get; set; }
        public string Section { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public string Subject { get; set; }
    }
}
