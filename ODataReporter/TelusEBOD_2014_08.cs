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
    
    public partial class TelusEBOD_2014_08
    {
    	[DataMember]
        public int Id { get; set; }
    	[DataMember]
        public string phonenumber { get; set; }
    	[DataMember]
        public System.DateTime billing_date { get; set; }
    	[DataMember]
        public int ClientID { get; set; }
    }
}
