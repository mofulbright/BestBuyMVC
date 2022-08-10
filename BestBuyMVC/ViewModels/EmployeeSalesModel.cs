using BestBuyMVC.bestbuy;

namespace BestBuyMVC.ViewModels
{
    public class EmployeeSalesModel
    {
        public string Name { get; set; }
        public IEnumerable<Sale> sales { get; set; }
    }
}
