using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWineCellarMVC.Models;

namespace TheWineCellarMVC.ViewModels
{
    public class ProductSearchListViewModel
    {
        // The product search variables
        public IEnumerable<Product> Products { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProductTypeString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchEmailString { get; set; }
    }
}
