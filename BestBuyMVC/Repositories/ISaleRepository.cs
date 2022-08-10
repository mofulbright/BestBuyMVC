using BestBuyMVC.bestbuy;
using BestBuyMVC.ViewModels;

namespace BestBuyMVC.Repositories
{
    public interface ISaleRepository
    {
        public IEnumerable<Sale> GetAllSales();
        public IEnumerable<Sale> GetAllSalesForProduct(int id);
        public EmployeeSalesModel GetAllSalesForEmployee(Employee employee);
        public Sale GetSale();
        //public void AddSale();

        //public void UpdateSale();
        //public void DeleteSale();

    }
}
