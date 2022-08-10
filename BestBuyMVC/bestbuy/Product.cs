using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Product
    {
        public Product()
        {
            Reviews = new HashSet<Review>();
            Sales = new HashSet<Sale>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public sbyte OnSale { get; set; }
        public string? StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        
        public byte[] Picture { get; set; }
    }
}
