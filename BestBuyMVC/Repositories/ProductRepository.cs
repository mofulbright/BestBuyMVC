using BestBuyMVC.bestbuy;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace BestBuyMVC.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public Product AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;
            return product;
        }

        public void DeleteProduct(Product product)
        {
            _conn.Execute("DELETE FROM Reviews WHERE ProductID = @id;", new { id = product.ProductId });
            _conn.Execute("DELETE FROM Sales WHERE ProductID = @id", new { id = product.ProductId });
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id", new { id = product.ProductId });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM Categories;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM products WHERE productId = @id", new { id });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (Name, Price, CategoryId) VALUES (@name, @price, @categoryId);",
                new { name = productToInsert.Name, price = productToInsert.Price, categoryId = productToInsert.CategoryId });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("Update products SET Name = @name, Price = @price WHERE ProductId = @id",
                new { name = product.Name, price = product.Price, id = product.ProductId });
        }
        public byte[] GetPicture(int id)
        {
            return _conn.QuerySingle<byte[]>("SELECT testpictures FROM products WHERE productId = @id", new { id });
        }
    }
}
