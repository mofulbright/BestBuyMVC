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

        public IEnumerable<Product> GetProductsForNewSale()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }

        public Sale AssignEmployeesAndProducts()
        {          
            Sale newSale = new Sale()
            {
                Employees = GetEmployeesForNewSale(),
                Products = GetProductsForNewSale()
            };
            return newSale;
        }
        public void AddSale()
        {

        }


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
            var sales = _conn.Query<Sale>("SELECT * FROM sales WHERE productId = @id", new { id }).ToList();
            sales[0].Product = _conn.QuerySingle<Product>("SELECT * FROM products WHERE productId = @id", new { id });
            return sales;
            
        }

        public Sale GetSale(int id)
        {
            return _conn.QuerySingle<Sale>("SELECT * FROM sales WHERE salesId = @id", new { id });
        }

        public IEnumerable<Employee> GetEmployeesForNewSale()
        {
            return _conn.Query<Employee>("SELECT * FROM employees;");
        }
    }
}
