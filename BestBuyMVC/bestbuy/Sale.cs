using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Sale
    {
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
