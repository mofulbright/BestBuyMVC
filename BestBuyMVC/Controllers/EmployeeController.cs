using BestBuyMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BestBuyMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repo;
        public EmployeeController(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var employees = repo.GetAllEmployees();
            return View(employees);
        }

        public IActionResult ViewEmployee(int id)
        {
            var employee = repo.GetById(id);
            return View(employee);
        }
    }
}
