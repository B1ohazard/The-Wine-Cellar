using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWineCellarMVC.Models;

namespace TheWineCellarMVC.ViewModels
{
    public class ProductListViewModel
    {
        // Passing the product IEnumerable
        public IEnumerable<Product> Products { get; set; }
    }
}
