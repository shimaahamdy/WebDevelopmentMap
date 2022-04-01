using CarAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Repositories_DAL
{
    // public class ITIContext : DbContext
    public class CarsRepository  : ICarsRepository
    {
        public InMemoryContext Context { get; set; }
        
        public CarsRepository(InMemoryContext memoryContext)
        {
            Context = memoryContext;
        }

        public List<Car> GetAllCars()
        {
            // Get cars from dependency
            // Logic
            return Context.Cars;
        }
        
        public Car GetCarById(int id)
        {
            return Context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public void AddCar(Car car)
        {
            Context.Cars.Add(car);
        }

        public void Remove(int carId)
        {
            var car = Context.Cars.Find(c => c.Id == carId);
            Context.Cars.Remove(car);
        }
    }
}