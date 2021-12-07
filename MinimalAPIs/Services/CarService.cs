using MinimalAPIs.Models;

namespace MinimalAPIs.Services;

public class CarService : ICarService
{
    public List<Car> GetAll() => cars;
    public void Save(Car car)
    {
        if (car.Id != 0)
        {
            var carToUpdate = cars.FirstOrDefault(c => c.Id == car.Id);
            if (carToUpdate != null)
            {
                cars.Remove(carToUpdate);
            }
        }
        else
        {
            car.Id = cars.Max(c => c.Id) + 1;
        }
        cars.Add(car);
    } 

    public Car Get(int id) => cars.FirstOrDefault(c => c.Id == id);


    private List<Car> cars = new (){
        new Car { Id = 1, Make = "Audi", Model = "R8", Year = 2018, Doors = 2, Color = "Red", Price = 79995 },
        new Car { Id = 2, Make = "Aston Martin", Model = "Rapide", Year = 2014, Doors = 2, Color = "Black", Price = 54995 },
        new Car { Id = 3, Make = "Porsche", Model = " 911 991", Year = 2020, Doors = 2, Color = "White", Price = 155000 },
        new Car { Id = 4, Make = "Mercedes-Benz", Model = "GLE 63S", Year = 2021, Doors = 5, Color = "Blue", Price = 83995 },
        new Car { Id = 5, Make = "BMW", Model = "X6 M", Year = 2020, Doors = 5, Color = "Silver", Price = 62995 },
    };
}
