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
    [KnownType(typeof(CRA))]
    [KnownType(typeof(Province))]
    
    public partial class Location
    {
        public Location()
        {
            this.CRAs = new HashSet<CRA>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string Location_eng { get; set; }
    	[DataMember]
        public string Location_fra { get; set; }
    	[DataMember]
        public string City { get; set; }
    	[DataMember]
        public string Province { get; set; }
    	[DataMember]
        public string PostalCode { get; set; }
    
    	[DataMember]
        public virtual ICollection<CRA> CRAs { get; set; }
    	[DataMember]
        public virtual Province Province1 { get; set; }
    }
}
