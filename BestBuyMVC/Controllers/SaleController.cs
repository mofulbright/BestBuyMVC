using BestBuyMVC.bestbuy;
using BestBuyMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BestBuyMVC.Controllers
{
    public class SaleController : Controller
    {
        private readonly ISaleRepository repo;
        public SaleController(ISaleRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var sales = repo.GetAllSales();
            return View(sales);
        }

        public IActionResult SalesByProduct(int id)
        {
            var sales = repo.GetAllSalesForProduct(id);
            return View(sales);
        }
        
        public IActionResult SalesByEmployee(Employee employee)
        {
            var sales = repo.GetAllSalesForEmployee(employee);
            return View(sales);
        }
        
        public IActionResult SaleById(int id)
        {
            return View(repo.GetSale(id));
        }

        public IActionResult AddSale()
        {
            return View(repo.AssignEmployeesAndProducts());
        }
    }
}
