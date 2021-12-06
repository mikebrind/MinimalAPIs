using MinimalAPIs.Models;

namespace MinimalAPIs.Services;

public interface ICarService
{
    List<Car> ReadAll();
}
