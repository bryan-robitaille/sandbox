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
    [KnownType(typeof(BellUsageFromWL_2014_04))]
    
    public partial class BellCostFromWL_2014_04
    {
    	[DataMember]
        public Nullable<int> Registration { get; set; }
    	[DataMember]
        public string AccountNumber { get; set; }
    	[DataMember]
        public string SubscriberPhoneNo { get; set; }
    	[DataMember]
        public Nullable<double> CostOfServicePlan { get; set; }
    	[DataMember]
        public Nullable<double> SuspensionRate { get; set; }
    	[DataMember]
        public Nullable<double> CostOfBilledAirtimeMinutes { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsVoiceRoamingMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfCanadatoCanadaLdMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfCanadaToUsLdMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfCanadaToInternationalLdMinutes { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUstoCanadaLdMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsToUsLdMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsToInternationalLdMinuteNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalCallingMinutesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOutgoingSmsMessagesinUsNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalSmsMessagesNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMmsPictures { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMmsVideos { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsDataOnMobilePhones { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsAbove500MBsOn500MBsDataPlans { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsAbove5GBon5GBsDataPlans { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsOfUsDataRoamingNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMbsOfInternationalDataRoamingNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfCanadaToCanadaUsLdMinutesUnderMonthlyCdnLdPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30DayUsVoiceRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsRoamingMinutesUnderUsVoiceRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOneTimeUnlockingFee { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30dayUsDataRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsRoamingMBsUnderUsDataRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30dayUsSmsRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsSmsMessagesUnderUsSmsRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30dayInternationalVoiceRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalRoamingMinutesUnderInternationalVoiceRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30dayInternationalDataRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalRoamingMBsUnderInternationalDataRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOf30dayInternationalSmsRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalSmsMessagesUnderInternationalSmsRoamingPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalService911AccessFee { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceBbEmailInt1GBNorthAmerica { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceDetailBilling { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceGovCanBBerryTethering500MB { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceGovCanBBerryTethering5GB { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceMobileTV { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceNBGovt911Fee { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceNSGovt911Fee { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServicePEIGovt911Fee { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceSasktelCallDispInOut { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceStaticIP { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceUnlimitedTextMessaging { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceVisualVoiceMail { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceVoiceMailPlus { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOptionalServiceVoiceMailToText { get; set; }
    	[DataMember]
        public Nullable<double> TotalOtherChargesAndCredits { get; set; }
    	[DataMember]
        public Nullable<double> GstTaxForServices { get; set; }
    	[DataMember]
        public Nullable<double> HstTaxForServices { get; set; }
    	[DataMember]
        public Nullable<double> QstTaxForServices { get; set; }
    	[DataMember]
        public Nullable<double> TotalCostForServices { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMonthlyCdnLdPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostofOptionalServiceDetailedAccountActivity { get; set; }
    
    	[DataMember]
        public virtual BellUsageFromWL_2014_04 BellUsageFromWL_2014_04 { get; set; }
    }
}
