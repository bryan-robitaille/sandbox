//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataReporter
{
    using System;
    using System.Collections.Generic;
    
    public partial class NAT_NWTel
    {
        public string Phone { get; set; }
        public Nullable<int> Registration { get; set; }
        public string AccountNo { get; set; }
        public Nullable<int> Department { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Product { get; set; }
        public string ProductName { get; set; }
        public string Charge { get; set; }
    
        public virtual Department Department1 { get; set; }
    }
}
