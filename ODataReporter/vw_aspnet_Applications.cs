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
    
    public partial class vw_aspnet_Applications
    {
    	[DataMember]
        public string ApplicationName { get; set; }
    	[DataMember]
        public string LoweredApplicationName { get; set; }
    	[DataMember]
        public System.Guid ApplicationId { get; set; }
    	[DataMember]
        public string Description { get; set; }
    }
}
