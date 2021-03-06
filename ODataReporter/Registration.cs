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
    [KnownType(typeof(Country))]
    [KnownType(typeof(CRA))]
    [KnownType(typeof(Department))]
    [KnownType(typeof(DeviceTypesFromBilling))]
    [KnownType(typeof(DeviceTypesFromSurvey))]
    [KnownType(typeof(DialerStatu))]
    [KnownType(typeof(ExemptionType))]
    [KnownType(typeof(LandLineProvider))]
    [KnownType(typeof(LandLineType))]
    [KnownType(typeof(OLD_Quarters))]
    [KnownType(typeof(ProtectedType))]
    [KnownType(typeof(UsocType))]
    [KnownType(typeof(ServiceProvider))]
    
    public partial class Registration
    {
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string LastName { get; set; }
    	[DataMember]
        public string FirstName { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    	[DataMember]
        public string WorkLocation { get; set; }
    	[DataMember]
        public string City { get; set; }
    	[DataMember]
        public string Province { get; set; }
    	[DataMember]
        public string PostalCode { get; set; }
    	[DataMember]
        public string Email { get; set; }
    	[DataMember]
        public string LandLine { get; set; }
    	[DataMember]
        public string CellularNumber1 { get; set; }
    	[DataMember]
        public Nullable<bool> DataServices1 { get; set; }
    	[DataMember]
        public Nullable<int> DeviceType1 { get; set; }
    	[DataMember]
        public Nullable<int> ServiceProvider1 { get; set; }
    	[DataMember]
        public string Other1 { get; set; }
    	[DataMember]
        public string CellularNumber2 { get; set; }
    	[DataMember]
        public Nullable<bool> DataServices2 { get; set; }
    	[DataMember]
        public Nullable<int> DeviceType2 { get; set; }
    	[DataMember]
        public Nullable<int> ServiceProvider2 { get; set; }
    	[DataMember]
        public string Other2 { get; set; }
    	[DataMember]
        public string CellularNumber3 { get; set; }
    	[DataMember]
        public Nullable<bool> DataServices3 { get; set; }
    	[DataMember]
        public Nullable<int> DeviceType3 { get; set; }
    	[DataMember]
        public Nullable<int> ServiceProvider3 { get; set; }
    	[DataMember]
        public string Other3 { get; set; }
    	[DataMember]
        public string SupervisorName { get; set; }
    	[DataMember]
        public string SupervisorPhone { get; set; }
    	[DataMember]
        public string Extension { get; set; }
    	[DataMember]
        public string Comments { get; set; }
    	[DataMember]
        public Nullable<int> Country { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> Created { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> Modified { get; set; }
    	[DataMember]
        public string ModifiedBy { get; set; }
    	[DataMember]
        public Nullable<bool> IsRemoved { get; set; }
    	[DataMember]
        public string AccountFromOBM { get; set; }
    	[DataMember]
        public string NumberBilledFromOBM { get; set; }
    	[DataMember]
        public Nullable<int> DepartmentFromOBM { get; set; }
    	[DataMember]
        public Nullable<int> LandLineType { get; set; }
    	[DataMember]
        public Nullable<int> LandLineProvider { get; set; }
    	[DataMember]
        public string AccountFromWireless { get; set; }
    	[DataMember]
        public string NumberBilledFromWireless { get; set; }
    	[DataMember]
        public string SubscriberNameFromWireless { get; set; }
    	[DataMember]
        public Nullable<int> DepartmentFromWireless { get; set; }
    	[DataMember]
        public Nullable<int> ServiceProviderFromWireless { get; set; }
    	[DataMember]
        public Nullable<bool> IsExempted { get; set; }
    	[DataMember]
        public Nullable<bool> IsLandlineDisconnected { get; set; }
    	[DataMember]
        public string ShortAddress { get; set; }
    	[DataMember]
        public Nullable<int> LevStructureNumber { get; set; }
    	[DataMember]
        public Nullable<double> LevPrecision { get; set; }
    	[DataMember]
        public Nullable<int> JaroStructureNumber { get; set; }
    	[DataMember]
        public Nullable<double> JaroPrecision { get; set; }
    	[DataMember]
        public string FloorNumber { get; set; }
    	[DataMember]
        public string OfficeNumber { get; set; }
    	[DataMember]
        public Nullable<bool> IsDuplicate { get; set; }
    	[DataMember]
        public Nullable<int> EapStatus { get; set; }
    	[DataMember]
        public Nullable<int> DialerResult { get; set; }
    	[DataMember]
        public Nullable<int> ObmMonthAdd { get; set; }
    	[DataMember]
        public Nullable<int> ObmMonthOut { get; set; }
    	[DataMember]
        public Nullable<bool> IsInGeds { get; set; }
    	[DataMember]
        public Nullable<int> UsocType { get; set; }
    	[DataMember]
        public Nullable<bool> Keep { get; set; }
    	[DataMember]
        public string Justification { get; set; }
    	[DataMember]
        public Nullable<int> DeviceTypeFromBilling1 { get; set; }
    	[DataMember]
        public Nullable<int> DeviceTypeFromBilling2 { get; set; }
    	[DataMember]
        public Nullable<int> DeviceTypeFromBilling3 { get; set; }
    	[DataMember]
        public Nullable<bool> IsLetterExcluded { get; set; }
    	[DataMember]
        public Nullable<int> ToBeOutOrderedDate { get; set; }
    	[DataMember]
        public Nullable<bool> ToBeOutOrdered { get; set; }
    	[DataMember]
        public Nullable<bool> IsBoardroom { get; set; }
    	[DataMember]
        public Nullable<int> CTC_Exemption { get; set; }
    	[DataMember]
        public Nullable<int> CTC_AccessoryStatus { get; set; }
    	[DataMember]
        public string CTC_CentrexOutOrderNumber { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> CTC_OutOrderDate { get; set; }
    	[DataMember]
        public string CTC_Comments { get; set; }
    	[DataMember]
        public string CTC_EmailStatus { get; set; }
    	[DataMember]
        public string CTC_ReasonForNotDisconnecting { get; set; }
    
    	[DataMember]
        public virtual Country Country1 { get; set; }
    	[DataMember]
        public virtual CRA CRA { get; set; }
    	[DataMember]
        public virtual Department Department1 { get; set; }
    	[DataMember]
        public virtual Department Department2 { get; set; }
    	[DataMember]
        public virtual Department Department3 { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromBilling DeviceTypesFromBilling { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromBilling DeviceTypesFromBilling1 { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromBilling DeviceTypesFromBilling2 { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromSurvey DeviceTypesFromSurvey { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromSurvey DeviceTypesFromSurvey1 { get; set; }
    	[DataMember]
        public virtual DeviceTypesFromSurvey DeviceTypesFromSurvey2 { get; set; }
    	[DataMember]
        public virtual DialerStatu DialerStatu { get; set; }
    	[DataMember]
        public virtual ExemptionType ExemptionType { get; set; }
    	[DataMember]
        public virtual LandLineProvider LandLineProvider1 { get; set; }
    	[DataMember]
        public virtual LandLineType LandLineType1 { get; set; }
    	[DataMember]
        public virtual OLD_Quarters OLD_Quarters { get; set; }
    	[DataMember]
        public virtual ProtectedType ProtectedType { get; set; }
    	[DataMember]
        public virtual UsocType UsocType1 { get; set; }
    	[DataMember]
        public virtual ServiceProvider ServiceProvider { get; set; }
    	[DataMember]
        public virtual ServiceProvider ServiceProvider4 { get; set; }
    	[DataMember]
        public virtual ServiceProvider ServiceProvider5 { get; set; }
    	[DataMember]
        public virtual ServiceProvider ServiceProvider6 { get; set; }
    }
}
