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
    
    public partial class tbldailyprodstatu
    {
        public int ID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Status { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<System.DateTime> InsertedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string CorrectedDate { get; set; }
        public string ColorCode { get; set; }
    
        public virtual tblmachinedetail tblmachinedetail { get; set; }
    }
}
