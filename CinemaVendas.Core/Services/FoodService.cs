using CinemaVendas.Core.Models;
using CinemaVendas.Core.Repositories;
using CinemaVendas.Core.Repositories.Interfaces;
using CinemaVendas.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _fooRepo;

        public FoodService(IFoodRepository fooRepo)
        {
            _fooRepo = fooRepo;
        }

        public List<FoodItem> GetAllSold()
        {
            return _fooRepo.GetAllSold();
        }
    }
}
