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
    [KnownType(typeof(Device))]
    [KnownType(typeof(Devices_History))]
    
    public partial class KeepChoice
    {
        public KeepChoice()
        {
            this.Devices = new HashSet<Device>();
            this.Devices_History = new HashSet<Devices_History>();
        }
    
    	[DataMember]
        public int ID { get; set; }
    	[DataMember]
        public string description_eng { get; set; }
    	[DataMember]
        public string description_fra { get; set; }
    
    	[DataMember]
        public virtual ICollection<Device> Devices { get; set; }
    	[DataMember]
        public virtual ICollection<Devices_History> Devices_History { get; set; }
    }
}
