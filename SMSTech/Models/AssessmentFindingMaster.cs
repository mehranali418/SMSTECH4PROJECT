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
    
    public partial class AssessmentFindingMaster
    {
        public int ID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> AssessmentCategoryID { get; set; }
        public Nullable<int> AssessmentColorID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public string Editable { get; set; }
    }
}
