//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mleczarnia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Delivery
    {
        public int deilveryID { get; set; }
        public int farmID { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<float> milkAmount { get; set; }
    
        public virtual Farm Farm { get; set; }
    }
}
