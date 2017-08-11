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
    
    public partial class TelusUsageFromWL_2015_09
    {
    	[DataMember]
        public int id { get; set; }
    	[DataMember]
        public string AccountNumber { get; set; }
    	[DataMember]
        public string SubscriberPhoneNo { get; set; }
    	[DataMember]
        public string SubscriberName { get; set; }
    	[DataMember]
        public string TypeOfDevice { get; set; }
    	[DataMember]
        public string Make_and_Model_of_Device { get; set; }
    	[DataMember]
        public string Serial_Number_of_Device { get; set; }
    	[DataMember]
        public string Status_of_Device { get; set; }
    	[DataMember]
        public string Activation_Date_of_Phone_Number { get; set; }
    	[DataMember]
        public string Activation_Date_of_Device { get; set; }
    	[DataMember]
        public string Name_of_Service_Plan_of_Device { get; set; }
    	[DataMember]
        public Nullable<double> TotalNumberOfAirtimeMinutes { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Billed_Airtime_Minutes { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_US_Voice_Roaming_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Canada_to_Canada_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Canada_to_US_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Canada_to_Internation_LD_Minutes { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_US_to_Canada_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_US_to_US_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_US_to_Internation_LD_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Internation_Calling_Minutes___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_incoming_and_outgoing_SMS_Messages_in_Canada { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_outgoing_SMS_Messages_in_US { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Internation_SMS_Messages___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Incoming_SMS_Message_in_Roaming { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Outgoing_SMS_Message_in_Roaming { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_MMS_Pictures { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_MMS_Videos { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_MBs_Data_on_Mobile_Phones { get; set; }
    	[DataMember]
        public Nullable<double> Total_Number_of_MBs_on_500_MB_Data_Plans { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Billed_MBs_on_500_MB_Data_Plans__i_e___above_500_MB_ { get; set; }
    	[DataMember]
        public Nullable<double> Total_Number_of_MBs_on_5_GB_Data_Plans { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Billed_MBs_on_5_GB_Data_Plans__i_e___above_5_GB_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Megabytes_of_US_Data_Roaming___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<double> Number_of_Kilobytes_of_Internation_Data_Roaming___non_plan_ { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    }
}
