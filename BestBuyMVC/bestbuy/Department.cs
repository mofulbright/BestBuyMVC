using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Department
    {
        public Department()
        {
            Categories = new HashSet<Category>();
        }

        public int DepartmentId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
