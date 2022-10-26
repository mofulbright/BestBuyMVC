using BestBuyMVC.bestbuy;
using BestBuyMVC.ViewModels;

namespace BestBuyMVC.Repositories
{
    public interface ISaleRepository
    {
        public IEnumerable<Sale> GetAllSales();
        public IEnumerable<Sale> GetAllSalesForProduct(int id);
        public EmployeeSalesModel GetAllSalesForEmployee(Employee employee);
        public Sale GetSale(int id);
        public void AddSale();
        public IEnumerable<Product> GetProductsForNewSale();
        public IEnumerable<Employee> GetEmployeesForNewSale();
        public Sale AssignEmployeesAndProducts();

        //public void UpdateSale();
        //public void DeleteSale();

    }
}
