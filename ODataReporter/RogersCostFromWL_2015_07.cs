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
    
    public partial class RogersCostFromWL_2015_07
    {
    	[DataMember]
        public int id { get; set; }
    	[DataMember]
        public Nullable<int> Registration { get; set; }
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
        public Nullable<double> CostOfServicePlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfSuspensionPlan { get; set; }
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
        public Nullable<double> MMSCharges { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsDataOnMobilePhones { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsAbove500MBsOn500MBsDataPlans { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsAbove5GBon5GBsDataPlans { get; set; }
    	[DataMember]
        public Nullable<double> CostOfMBsAbove15GBon5GBsDataPlans { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsDataRoamingNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfInternationalDataRoamingNonPlan { get; set; }
    	[DataMember]
        public Nullable<double> CostOfUsSmsMessages { get; set; }
    	[DataMember]
        public Nullable<double> CostOfOneTimeUnlockingFees { get; set; }
    	[DataMember]
        public Nullable<double> CostTOfSecondLineForFederalGovt { get; set; }
    	[DataMember]
        public Nullable<double> CostOfWiFiAccessOnly { get; set; }
    	[DataMember]
        public Nullable<double> CostOfBusinessWiFiLocal { get; set; }
    	[DataMember]
        public Nullable<double> CostOfBusinessWiFiCanadaWide { get; set; }
    	[DataMember]
        public Nullable<double> CostOfVoicemailToTextSpinVox { get; set; }
    	[DataMember]
        public Nullable<double> CostOfRogersNavigator { get; set; }
    	[DataMember]
        public Nullable<double> CostOfGpsNavigatorTelevav { get; set; }
    	[DataMember]
        public Nullable<double> CostOfBbTetheringAccess { get; set; }
    	[DataMember]
        public Nullable<double> CostOfWPSACC { get; set; }
    	[DataMember]
        public Nullable<double> CostOfPublicIpAccess { get; set; }
    	[DataMember]
        public Nullable<double> CostOfAPN { get; set; }
    	[DataMember]
        public Nullable<double> CostOfStaticApnAccess { get; set; }
    	[DataMember]
        public Nullable<double> MiscellaneousChargesAndCredit { get; set; }
    	[DataMember]
        public Nullable<double> GstTaxForServices { get; set; }
    	[DataMember]
        public Nullable<double> HstTaxForServices { get; set; }
    	[DataMember]
        public Nullable<double> TotalCostForServices { get; set; }
    	[DataMember]
        public Nullable<double> CostOfDevices { get; set; }
    	[DataMember]
        public Nullable<double> CostOfAccessories { get; set; }
    	[DataMember]
        public Nullable<double> ShippingCost { get; set; }
    	[DataMember]
        public Nullable<double> GstTaxForProducts { get; set; }
    	[DataMember]
        public Nullable<double> HstTaxForProducts { get; set; }
    	[DataMember]
        public Nullable<double> MiscellaneousChargesAndCreditsHardware { get; set; }
    	[DataMember]
        public Nullable<double> TotalCostForProducts { get; set; }
    	[DataMember]
        public Nullable<double> TotalCostForServicesAndProducts { get; set; }
    }
}
