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
    
    public partial class Sale
    {
        public int saleID { get; set; }
        public int productionID { get; set; }
        public Nullable<float> amountToSell { get; set; }
        public Nullable<float> price { get; set; }
        public Nullable<float> entrenceAmount { get; set; }
        public string production { get; set; }
        public virtual Production Production { get; set; }
    }
}
