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
    
    public partial class vw_aspnet_WebPartState_User
    {
    	[DataMember]
        public Nullable<System.Guid> PathId { get; set; }
    	[DataMember]
        public Nullable<System.Guid> UserId { get; set; }
    	[DataMember]
        public Nullable<int> DataSize { get; set; }
    	[DataMember]
        public System.DateTime LastUpdatedDate { get; set; }
    }
}