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
    
    public partial class Wireless
    {
        public string AccountNumber { get; set; }
        public string SubscriberPhoneNo { get; set; }
        public string SubscriberName { get; set; }
        public string TypeOfDevice { get; set; }
        public Nullable<int> ServiceProvider { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<int> RegistrationsID { get; set; }
        public Nullable<int> DeviceType { get; set; }
    
        public virtual Department Department1 { get; set; }
        public virtual DeviceTypesFromBilling DeviceTypesFromBilling { get; set; }
        public virtual ServiceProvider ServiceProvider1 { get; set; }
    }
}
