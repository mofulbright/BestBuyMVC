using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
