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
    
    public partial class NAT_DMS_2015
    {
    	[DataMember]
        public string ServiceNo { get; set; }
    	[DataMember]
        public Nullable<int> Registration { get; set; }
    	[DataMember]
        public string AccountNumber { get; set; }
    	[DataMember]
        public Nullable<int> Department { get; set; }
    	[DataMember]
        public Nullable<int> DepartmentAgency { get; set; }
    	[DataMember]
        public string CustName { get; set; }
    	[DataMember]
        public string DepartmentName { get; set; }
    	[DataMember]
        public string CustAcronym { get; set; }
    	[DataMember]
        public string CustomerGroup { get; set; }
    	[DataMember]
        public string CLID { get; set; }
    	[DataMember]
        public string StreetNumber { get; set; }
    	[DataMember]
        public string StreetName { get; set; }
    	[DataMember]
        public string RmAptNo { get; set; }
    	[DataMember]
        public string Province { get; set; }
    	[DataMember]
        public string CountyCd { get; set; }
    	[DataMember]
        public string PostalCode { get; set; }
    	[DataMember]
        public string Switch { get; set; }
    	[DataMember]
        public string Len { get; set; }
    	[DataMember]
        public string SetType { get; set; }
    	[DataMember]
        public string NCOS { get; set; }
    	[DataMember]
        public string HqClientCode { get; set; }
    }
}