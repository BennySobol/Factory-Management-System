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
    
    public partial class orderTBL
    {
        public int Id { get; set; }
        public double currentOrderPrice { get; set; }
        public System.DateTime orderDeadline { get; set; }
        public int orderToken { get; set; }
        public bool isDiliverd { get; set; }
        public int productsID { get; set; }
        public int customerID { get; set; }
        public System.DateTime orderStartDate { get; set; }
        public int amount { get; set; }
        public Nullable<double> allOrderCost { get; set; }
        public Nullable<System.DateTime> orderSendDate { get; set; }
    
        public virtual customersTBL customersTBL { get; set; }
        public virtual productTBL productTBL { get; set; }
    }
}
