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
    
    public partial class AllowanceAmount
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AllowanceTypeID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<int> SalaryMonthID { get; set; }
        public Nullable<int> AllowanceAmountID { get; set; }
    }
}
