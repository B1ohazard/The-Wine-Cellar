using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    public class ProductRepository : IProductRepository
    {
        // private readonly variable to access the database
        private readonly AppDBContext _appDbContext;

        public ProductRepository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        // IEnumerable to get all products from database
        public IEnumerable<Product> GetAllProducts => _appDbContext.Products;

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public Product GetProductByFarmer(string farmerId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.FarmerId == farmerId);
        }
    }
}
