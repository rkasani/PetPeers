//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetPeers.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class PetUserMapping
    {
        public long PetUserSaleMappingId { get; set; }
        public Nullable<long> PetId { get; set; }
        public Nullable<long> BroughtBy { get; set; }
        public Nullable<System.DateTime> BroughtOn { get; set; }
    
        public virtual Pet Pet { get; set; }
        public virtual User User { get; set; }
    }
}
