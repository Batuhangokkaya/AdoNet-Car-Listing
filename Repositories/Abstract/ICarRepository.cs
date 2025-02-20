using Entities.Models;

namespace Repositories.Abstract
{
    public interface ICarRepository
    {
        void Add(Car entity);
        void Update(Car entity);
        void Delete(int id);
        Car GetByIdCar(int id);
        List<Car> GetAllCars();
    }
}