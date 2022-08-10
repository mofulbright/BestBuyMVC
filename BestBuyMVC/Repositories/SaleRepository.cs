using BestBuyMVC.bestbuy;
using BestBuyMVC.ViewModels;
using Dapper;
using System.Data;

namespace BestBuyMVC.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly IDbConnection _conn;
        public SaleRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        //public void AddSale()
        //{
            
        //}

        public IEnumerable<Sale> GetAllSales()
        {
            return _conn.Query<Sale>("SELECT * FROM sales");
        }

        public EmployeeSalesModel GetAllSalesForEmployee(Employee employee)
        {
            return new EmployeeSalesModel()
            {
                Name = employee.FirstName + " " + employee.LastName,
                sales = _conn.Query<Sale>("SELECT * FROM sales WHERE employeeId = @id", new { id = employee.EmployeeId })
            };
        }

        public IEnumerable<Sale> GetAllSalesForProduct(int id)
        {
            return _conn.Query<Sale>("SELECT * FROM sales WHERE productId = @id", new { id });
        }

        public Sale GetSale()
        {
            throw new NotImplementedException();
        }
    }
}
