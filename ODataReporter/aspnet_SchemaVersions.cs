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
    
    public partial class aspnet_SchemaVersions
    {
    	[DataMember]
        public string Feature { get; set; }
    	[DataMember]
        public string CompatibleSchemaVersion { get; set; }
    	[DataMember]
        public bool IsCurrentVersion { get; set; }
    }
}
