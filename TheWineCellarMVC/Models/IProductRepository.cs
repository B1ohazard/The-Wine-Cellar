using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    // ProductRepository is extending the IProductRepository
    public interface IProductRepository
    {
        // IEnumerable to get all products from database
        IEnumerable<Product> GetAllProducts { get; }

        // How do we want to fetch this data --> Using product ID (Primary Key)
        Product GetProductById(int productId);

        // How do we want to fetch this data --> Using farmer ID (Primary Key)
        Product GetProductByFarmer(string farmerId);
    }
}
