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
    
    public partial class SchoolSetting
    {
        public int ID { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string Example { get; set; }
        public string DataType { get; set; }
        public byte[] Images { get; set; }
        public string Category { get; set; }
    }
}
