using MinimalAPIs.Models;

namespace MinimalAPIs.Services;

public interface ICarService
{
    List<Car> GetAll();
    Car Get(int id);
    void Save(Car car);
}
