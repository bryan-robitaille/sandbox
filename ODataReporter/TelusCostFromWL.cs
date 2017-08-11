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
    
    public partial class TelusCostFromWL
    {
    	[DataMember]
        public int id { get; set; }
    	[DataMember]
        public string AccountNumber { get; set; }
    	[DataMember]
        public string SubscriberPhoneNo { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Service_Plan { get; set; }
    	[DataMember]
        public Nullable<double> Suspension_Rate { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Billed_Airtime_Minutes { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_US_Voice_Roaming_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Canada_to_Canada_LD_Minutes__non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Canada_to_US_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Canada_to_Internation_LD_Minutes { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_US_to_Canada_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_US_to_US_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_US_to_Internation_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Internation_Calling_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_outgoing_SMS_Messages_in_US___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Internation_SMS_Messages___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Incoming_SMS_Message_in_Roaming { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Outgoing_SMS_Message_in_Roaming { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_MMS_Pictures { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_MMS_Videos { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_MBs_Data_on_Mobile_Phones { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_MB_above_500MB_on_500_MB_Data_Plans { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_MB_above_5GB_on_5GB_Data_Plans { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Megabytes_of_US_Data_Roaming___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Kilobytes_of_Internation_Data_Roaming___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> GST_Tax_for_Services { get; set; }
    	[DataMember]
        public Nullable<double> HST_Tax_for_Services { get; set; }
    	[DataMember]
        public Nullable<double> TotalCostForServices { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Devices { get; set; }
    	[DataMember]
        public Nullable<double> Cost_of_Accessories { get; set; }
    	[DataMember]
        public Nullable<double> Shipping_Cost { get; set; }
    	[DataMember]
        public Nullable<double> GST_Tax_for_Products { get; set; }
    	[DataMember]
        public Nullable<double> HST_Tax_for_Products { get; set; }
    	[DataMember]
        public Nullable<double> Total_Cost_for_Products { get; set; }
    	[DataMember]
        public Nullable<double> Total_Cost_for_Services_and_Products { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    	[DataMember]
        public Nullable<int> Registration { get; set; }
    }
}
