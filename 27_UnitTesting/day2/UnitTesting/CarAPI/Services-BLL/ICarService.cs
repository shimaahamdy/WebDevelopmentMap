using CarAPI.Entities;
using System.Collections.Generic;

namespace CarAPI.Services_BLL
{
    public interface ICarService
    {
        void AddCar(Car car);
        List<Car> GetAll();
        Car GetCarById(int id);
        void Remove(int carId);
    }
}