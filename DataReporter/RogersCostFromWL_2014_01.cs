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
    
    public partial class RogersCostFromWL_2014_01
    {
        public Nullable<int> Registration { get; set; }
        public string AccountNumber { get; set; }
        public string SubscriberPhoneNo { get; set; }
        public string SubscriberName { get; set; }
        public string TypeOfDevice { get; set; }
        public string MakeAndModelOfDevice { get; set; }
        public string SerialNumberOfDevice { get; set; }
        public string StatusOfDevice { get; set; }
        public Nullable<System.DateTime> ActivationDate { get; set; }
        public string NameOfServicePlan { get; set; }
        public string DescriptionOfServicePlan { get; set; }
        public Nullable<double> CostOfServicePlan { get; set; }
        public Nullable<double> CostOfSuspensionPlan { get; set; }
        public Nullable<double> CostOfBilledAirtimeMinutes { get; set; }
        public Nullable<double> CostOfUsVoiceRoamingMinutesNonPlan { get; set; }
        public Nullable<double> CostOfCanadatoCanadaLdMinutesNonPlan { get; set; }
        public Nullable<double> CostOfCanadaToUsLdMinutesNonPlan { get; set; }
        public Nullable<double> CostOfCanadaToInternationalLdMinutes { get; set; }
        public Nullable<double> CostOfUstoCanadaLdMinutesNonPlan { get; set; }
        public Nullable<double> CostOfUsToUsLdMinutesNonPlan { get; set; }
        public Nullable<double> CostOfUsToInternationalLdMinuteNonPlan { get; set; }
        public Nullable<double> CostOfInternationalCallingMinutesNonPlan { get; set; }
        public Nullable<double> CostOfOutgoingSmsMessagesinUsNonPlan { get; set; }
        public Nullable<double> CostOfInternationalSmsMessagesNonPlan { get; set; }
        public Nullable<double> MMSCharges { get; set; }
        public Nullable<double> CostOfMBsDataOnMobilePhones { get; set; }
        public Nullable<double> CostOfMBsAbove500MBsOn500MBsDataPlans { get; set; }
        public Nullable<double> CostOfMBsAbove5GBon5GBsDataPlans { get; set; }
        public Nullable<double> CostOfMBsAbove15GBon5GBsDataPlans { get; set; }
        public Nullable<double> CostOfUsDataRoamingNonPlan { get; set; }
        public Nullable<double> CostOfInternationalDataRoamingNonPlan { get; set; }
        public Nullable<double> CostOfUsSmsMessages { get; set; }
        public Nullable<double> CostOfOneTimeUnlockingFees { get; set; }
        public Nullable<double> CostTOfSecondLineForFederalGovt { get; set; }
        public Nullable<double> CostOfWiFiAccessOnly { get; set; }
        public Nullable<double> CostOfBusinessWiFiLocal { get; set; }
        public Nullable<double> CostOfBusinessWiFiCanadaWide { get; set; }
        public Nullable<double> CostOfVoicemailToTextSpinVox { get; set; }
        public Nullable<double> CostOfRogersNavigator { get; set; }
        public Nullable<double> CostOfGpsNavigatorTelevav { get; set; }
        public Nullable<double> CostOfBbTetheringAccess { get; set; }
        public Nullable<double> CostOfWPSACC { get; set; }
        public Nullable<double> CostOfPublicIpAccess { get; set; }
        public Nullable<double> CostOfAPN { get; set; }
        public Nullable<double> CostOfStaticApnAccess { get; set; }
        public Nullable<double> MiscellaneousChargesAndCredit { get; set; }
        public Nullable<double> GstTaxForServices { get; set; }
        public Nullable<double> HstTaxForServices { get; set; }
        public Nullable<double> TotalCostForServices { get; set; }
        public Nullable<double> CostOfDevices { get; set; }
        public Nullable<double> CostOfAccessories { get; set; }
        public Nullable<double> ShippingCost { get; set; }
        public Nullable<double> GstTaxForProducts { get; set; }
        public Nullable<double> HstTaxForProducts { get; set; }
        public Nullable<double> MiscellaneousChargesAndCreditsHardware { get; set; }
        public Nullable<double> TotalCostForProducts { get; set; }
        public Nullable<double> TotalCostForServicesAndProducts { get; set; }
        public string HighestCharge { get; set; }
    
        public virtual RogersUsageFromWL_2014_01 RogersUsageFromWL_2014_01 { get; set; }
    }
}
