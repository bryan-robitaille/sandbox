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
    [KnownType(typeof(Registration))]
    
    public partial class OLD_Quarters
    {
        public OLD_Quarters()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string Quarter_eng { get; set; }
    
    	[DataMember]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}