using CinemaVendas.Core.Models;
using System.Collections.Generic;

namespace CinemaVendas.Core.Repositories.Interfaces
{
    public interface IFoodRepository
    {
        List<FoodItem> GetAllSold();
    }
}
