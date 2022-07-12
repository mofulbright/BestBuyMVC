using BestBuyMVC.bestbuy;

namespace BestBuyMVC.Repositories
{
    public interface ISaleRepository
    {
        public IEnumerable<Sale> GetAllSales();
        public IEnumerable<Sale> GetAllSalesForProduct(int id);
        public IEnumerable<Sale> GetAllSalesForEmployee(int id);
        public Sale GetSale();
        //public void AddSale();

        //public void UpdateSale();
        //public void DeleteSale();

    }
}
