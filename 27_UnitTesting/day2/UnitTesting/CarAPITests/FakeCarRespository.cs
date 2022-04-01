using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPITests
{
    public class FakeCarRespository : ICarsRepository
    {
        private readonly FakeInMemoryContext _context;

        public FakeCarRespository(FakeInMemoryContext context)
        {
            _context = context;
        }

        public void AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            return _context.Cars;
        }

        public Car GetCarById(int id)
        {
            return _context.Cars.Find(c => c.Id == id);
        }

        public void Remove(int carId)
        {
            var car = GetCarById(carId);
            _context.Cars.Remove(car);
        }
    }
}
