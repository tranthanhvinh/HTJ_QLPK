//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExchangeRate
    {
        public string GoldCode { get; set; }
        public string GoldType { get; set; }
        public Nullable<decimal> BuyRate { get; set; }
        public Nullable<decimal> SellRate { get; set; }
        public Nullable<decimal> ChangeRate { get; set; }
        public string ShopId { get; set; }
    }
}
