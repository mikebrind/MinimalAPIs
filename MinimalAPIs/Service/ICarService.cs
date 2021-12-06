using MinimalAPIs.Models;

namespace MinimalAPIs.Service;

public interface ICarService
{
    List<Car> ReadAll();
}
