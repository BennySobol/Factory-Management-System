

using System;

namespace DrMelomad
{
    class ProductInCart
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int ProductID { get; set; }
        public double Total { get; set; }
        public void Calc()
        {
            Total = Amount * Price;
        }
    }
    class Order
    {
        public string CustomerName { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime StartDate { get; set; }
        public double Price { get; set; }
        public int Tocken { get; set; }
        public bool IsDiliverd { get; set; }
        public double ProductionCost { get; set; }
    }

}

