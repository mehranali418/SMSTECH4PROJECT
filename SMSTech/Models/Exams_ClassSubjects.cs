//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSTech.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exams_ClassSubjects
    {
        public int ID { get; set; }
        public Nullable<int> TestID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<int> SectionID { get; set; }
        public Nullable<int> SubjectNumber { get; set; }
        public Nullable<decimal> TotalMarks { get; set; }
        public Nullable<decimal> PassingMarks { get; set; }
    }
}
