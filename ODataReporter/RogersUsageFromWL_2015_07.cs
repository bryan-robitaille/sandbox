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
    
    public partial class RogersUsageFromWL_2015_07
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
        public int id { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    	[DataMember]
        public Nullable<int> Registration { get; set; }
    }
}
