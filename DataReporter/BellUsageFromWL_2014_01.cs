//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataReporter
{
    using System;
    using System.Collections.Generic;
    
    public partial class BellUsageFromWL_2014_01
    {
        public Nullable<int> Department { get; set; }
        public string AccountNumber { get; set; }
        public string SubscriberPhoneNo { get; set; }
        public string SubscriberName { get; set; }
        public string TypeOfDevice { get; set; }
        public string MakeAndModelOfDevice { get; set; }
        public string SerialNumberOfDevice { get; set; }
        public string StatusOfDevice { get; set; }
        public Nullable<System.DateTime> ActivationDateOfPhoneNumber { get; set; }
        public Nullable<System.DateTime> ActivationDateOfDevice { get; set; }
        public string NameOfServicePlanOfDevice { get; set; }
        public Nullable<int> TotalNumberOfAirtimeMinutes { get; set; }
        public Nullable<int> NumberOfBilledAirtimeMinutes { get; set; }
    
        public virtual BellCostFromWL_2014_01 BellCostFromWL_2014_01 { get; set; }
        public virtual Department Department1 { get; set; }
    }
}
