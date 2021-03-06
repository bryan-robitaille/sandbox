//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataReporter
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    [KnownType(typeof(Department))]
    [KnownType(typeof(RogersCostFromWL_2014_04))]
    
    public partial class RogersUsageFromWL_2014_04
    {
    	[DataMember]
        public string AccountNumber { get; set; }
    	[DataMember]
        public string SubscriberPhoneNo { get; set; }
    	[DataMember]
        public string SubscriberName { get; set; }
    	[DataMember]
        public string TypeOfDevice { get; set; }
    	[DataMember]
        public string MakeAndModelOfDevice { get; set; }
    	[DataMember]
        public string SerialNumberOfDevice { get; set; }
    	[DataMember]
        public string StatusOfDevice { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ActivationDate { get; set; }
    	[DataMember]
        public string NameOfServicePlan { get; set; }
    	[DataMember]
        public string DescriptionOfServicePlan { get; set; }
    	[DataMember]
        public Nullable<int> TotalNumberOfAirtimeMinutes { get; set; }
    	[DataMember]
        public Nullable<int> NumberOfBilledAirtimeMinutes { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    
    	[DataMember]
        public virtual Department Department1 { get; set; }
    	[DataMember]
        public virtual RogersCostFromWL_2014_04 RogersCostFromWL_2014_04 { get; set; }
    }
}
