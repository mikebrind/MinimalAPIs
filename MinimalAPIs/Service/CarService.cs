using MinimalAPIs.Models;

namespace MinimalAPIs.Service;

public class CarService : ICarService
{
    public List<Car> ReadAll() => new (){
        new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2014, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 2, Make = "Aston Martin", Model = "Rapide", Year = 2010, Doors = 2, Color = "Black", Price = 54995 },
        new Car { Id = 3, Make = "Porsche", Model = " 911 991", Year = 2016, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2017, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2016, Doors = 5, Color = "Silver", Price = 62995 },

        new Car { Id = 6, Make = "Audi", Model = "R8", Year = 2014, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 7, Make = "Aston Martin", Model = "Rapide", Year = 2010, Doors = 2, Color = "Black", Price = 54995 },
        new Car { Id = 8, Make = "Porsche", Model = " 911 991", Year = 2016, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 9, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2017, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 10, Make = "BMW", Model = "X6 M", Year = 2016, Doors = 5, Color = "Silver", Price = 62995 },

        new Car { Id = 11, Make = "Audi", Model = "R8", Year = 2014, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 12, Make = "Aston Martin", Model = "Rapide", Year = 2010, Doors = 2, Color = "Black", Price = 54995 },
        new Car { Id = 13, Make = "Porsche", Model = " 911 991", Year = 2016, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 14, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2017, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 15, Make = "BMW", Model = "X6 M", Year = 2016, Doors = 5, Color = "Silver", Price = 62995 },

        new Car { Id = 16, Make = "Audi", Model = "R8", Year = 2014, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 17, Make = "Aston Martin", Model = "Rapide", Year = 2010, Doors = 2, Color = "Black", Price = 54995 },
        new Car { Id = 18, Make = "Porsche", Model = " 911 991", Year = 2016, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 19, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2017, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 20, Make = "BMW", Model = "X6 M", Year = 2016, Doors = 5, Color = "Silver", Price = 62995 },
    };
}
