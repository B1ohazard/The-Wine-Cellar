using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWineCellarMVC.Models;

namespace TheWineCellarMVC.ViewModels
{
    public class FarmerListViewModel
    {
        // Passing the Farmer IEnumerable
        public IEnumerable<Farmer> Farmers { get; set; }
    }
}
