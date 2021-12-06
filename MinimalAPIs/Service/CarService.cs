using MinimalAPIs.Models;

namespace MinimalAPIs.Service;

public class CarService : ICarService
{
    public List<Car> ReadAll() => new (){
            new Car{Id = 1, Make="Audi",Model="R8",Year=2014,Doors=2,Color="Red",Price=79995},
            new Car{Id = 2, Make="Aston Martin",Model="Rapide",Year=2010,Doors=2,Color="Black",Price=54995},
            new Car{Id = 3, Make="Porsche",Model=" 911 991",Year=2016,Doors=2,Color="White",Price=155000},
            new Car{Id = 4, Make="Mercedes-Benz",Model="GLE 63S",Year=2017,Doors=5,Color="Blue",Price=83995},
            new Car{Id = 5, Make="BMW",Model="X6 M",Year=2016,Doors=5,Color="Silver",Price=62995},
        };
}
