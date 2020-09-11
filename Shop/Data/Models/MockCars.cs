using Shop.Data.interfaces;
using Shop.Data.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class MockCars : IAll
    {
        private readonly ICarsCategory _caregoryCars = new MockCategory();  



        public IEnumerable<Car> Cars
        {
          get
          {
                return new List<Car> {
                new Car {
                    name ="Tesla Model S",
                    shortDesc = "Быстрый автомобиль",
                    lingDesc = "Красивый и безшумный, от компании Tesla",
                    img = "/img/1.jpg",
                    price = 45000,
                    isFavourite = true,
                    available = true,
                    Category = _caregoryCars.AllCategories.First()
                    },
                           
                    new Car
                    {
                    name ="Ford Fiesta",
                    shortDesc = "Тихий и спокойный",
                    lingDesc = "Удобный автомобиль для городской жизни",
                    img = "/img/2.jpg",
                    price = 11000,
                    isFavourite = false,
                    available = true,
                    Category = _caregoryCars.AllCategories.Last()
                    },

                    new Car
                    {
                        name = "Chevrolet camaro",
                        shortDesc = "Быстрый и красивый",
                        lingDesc = "Очень футуристичный автомобиль для городских поезок",
                        img = "/img/3.jpg",
                        price = 20000,
                        isFavourite = false,
                        available = true,
                        Category = _caregoryCars.AllCategories.Last()
                    }
                    
                };
          }
           

        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
    
}

