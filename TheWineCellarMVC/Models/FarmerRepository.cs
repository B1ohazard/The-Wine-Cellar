using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Models
{
    // FarmerRespository is extending the IFarmerRepository
    public class FarmerRepository : IFarmerRepository
    {
        // private readonly variable to access the database
        private readonly AppDBContext _appDBContext;

        public FarmerRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        // IEnumerable to get all farmers from database
        public IEnumerable<Farmer> GetFarmers => _appDBContext.Farmers;
    }
}
