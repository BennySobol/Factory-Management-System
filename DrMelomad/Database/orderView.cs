//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrMelomad.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderView
    {
        public string fullName { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public double currentOrderPrice { get; set; }
        public int amount { get; set; }
        public System.DateTime orderStartDate { get; set; }
        public System.DateTime orderDeadline { get; set; }
        public int orderToken { get; set; }
        public int productID { get; set; }
    }
}
