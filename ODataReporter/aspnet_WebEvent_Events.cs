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
    
    public partial class aspnet_WebEvent_Events
    {
    	[DataMember]
        public string EventId { get; set; }
    	[DataMember]
        public System.DateTime EventTimeUtc { get; set; }
    	[DataMember]
        public System.DateTime EventTime { get; set; }
    	[DataMember]
        public string EventType { get; set; }
    	[DataMember]
        public decimal EventSequence { get; set; }
    	[DataMember]
        public decimal EventOccurrence { get; set; }
    	[DataMember]
        public int EventCode { get; set; }
    	[DataMember]
        public int EventDetailCode { get; set; }
    	[DataMember]
        public string Message { get; set; }
    	[DataMember]
        public string ApplicationPath { get; set; }
    	[DataMember]
        public string ApplicationVirtualPath { get; set; }
    	[DataMember]
        public string MachineName { get; set; }
    	[DataMember]
        public string RequestUrl { get; set; }
    	[DataMember]
        public string ExceptionType { get; set; }
    	[DataMember]
        public string Details { get; set; }
    }
}
