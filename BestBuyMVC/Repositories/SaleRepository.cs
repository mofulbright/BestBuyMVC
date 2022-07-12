using BestBuyMVC.bestbuy;
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

        public IEnumerable<Sale> GetAllSalesForEmployee(int id)
        {
            return _conn.Query<Sale>("SELECT * FROM sales WHERE employeeId = @id", new { id });
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
