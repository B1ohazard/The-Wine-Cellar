using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    // Holding the Ienumerable to get the farmers
   public interface IFarmerRepository
    {
        IEnumerable<Farmer> GetFarmers { get; }
    }
}
