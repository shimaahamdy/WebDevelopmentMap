using CarAPI.Entities;
using System.Collections.Generic;

namespace CarAPI.Repositories_DAL
{
    public interface ICarsRepository
    {
        void AddCar(Car car);
        List<Car> GetAllCars();
        Car GetCarById(int id);
        void Remove(int carId);
    }
}