//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRKSDemo.Server_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblpriorityalarm
    {
        public int AlarmID { get; set; }
        public int AlarmNumber { get; set; }
        public string AlarmDesc { get; set; }
        public int AxisNo { get; set; }
        public string AlarmGroup { get; set; }
        public int PriorityNumber { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> MachineID { get; set; }
        public string CorrectedDate { get; set; }
        public Nullable<int> isMailSent { get; set; }
    }
}
