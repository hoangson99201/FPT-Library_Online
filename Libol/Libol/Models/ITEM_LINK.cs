//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ITEM_LINK
    {
        public Nullable<int> LinkTypeID { get; set; }
        public int ItemID1 { get; set; }
        public int ItemID2 { get; set; }
        public bool IsSerial { get; set; }
        public string FieldCode { get; set; }
    }
}