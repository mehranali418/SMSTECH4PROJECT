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
    
    public partial class Exams_Marks
    {
        public int ID { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<int> ExamClassSubject_id { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<decimal> ObtainMarksA { get; set; }
        public Nullable<decimal> ObtainMarksB { get; set; }
        public Nullable<decimal> ObtainMarksPractical { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> PassFail { get; set; }
        public Nullable<bool> ExcludeSubject { get; set; }
    }
}
