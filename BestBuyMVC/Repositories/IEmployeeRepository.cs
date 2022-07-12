using BestBuyMVC.bestbuy;

namespace BestBuyMVC.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAllEmployees();
        public Employee GetById(int id);
    }
}
