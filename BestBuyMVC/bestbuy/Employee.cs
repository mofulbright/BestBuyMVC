using System;
using System.Collections.Generic;

namespace BestBuyMVC.bestbuy
{
    public partial class Employee
    {
        public Employee()
        {
            Sales = new HashSet<Sale>();
        }

        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleInitial { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Title { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
