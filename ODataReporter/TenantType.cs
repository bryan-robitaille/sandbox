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
    [KnownType(typeof(BuildingDetail))]
    
    public partial class TenantType
    {
        public TenantType()
        {
            this.BuildingDetails = new HashSet<BuildingDetail>();
            this.BuildingDetails1 = new HashSet<BuildingDetail>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string Description { get; set; }
    
    	[DataMember]
        public virtual ICollection<BuildingDetail> BuildingDetails { get; set; }
    	[DataMember]
        public virtual ICollection<BuildingDetail> BuildingDetails1 { get; set; }
    }
}