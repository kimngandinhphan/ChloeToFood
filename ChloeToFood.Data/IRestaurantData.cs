using ChloeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChloeToFood.Data
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            this._restaurants = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Cinnamon Club", Location="London", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 3, Name = "La Costa", Location = "California", Cuisine=CuisineType.Mexican}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in _restaurants
                   orderby r.Name
                   select r;
        }
    }
}
