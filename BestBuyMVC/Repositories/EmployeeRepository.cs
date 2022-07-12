using BestBuyMVC.bestbuy;
using Dapper;
using System.Data;

namespace BestBuyMVC.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbConnection _conn;
        public EmployeeRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _conn.Query<Employee>("SELECT * FROM employees");
        }

        public Employee GetById(int id)
        {
            return _conn.QuerySingle<Employee>("SELECT * FROM employees WHERE employeeId = @id", new { id });
        }
    }
}
