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
    [KnownType(typeof(HighUsageExemption))]
    
    public partial class HighUsageExemptionType
    {
        public HighUsageExemptionType()
        {
            this.HighUsageExemptions = new HashSet<HighUsageExemption>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string ExemptionType { get; set; }
    
    	[DataMember]
        public virtual ICollection<HighUsageExemption> HighUsageExemptions { get; set; }
    }
}
