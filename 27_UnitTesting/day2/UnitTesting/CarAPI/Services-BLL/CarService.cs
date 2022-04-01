using CarAPI.Entities;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace CarAPI.Services_BLL
{
    public class CarService : ICarService
    {
        private ICarsRepository CarsRepository { get; set; }

        public CarService(
            ICarsRepository carsRepository,
            [Dependency("CashService")]IPaymentService paymentService
            )
        {
            CarsRepository = carsRepository;
        }

        public List<Car> GetAll()
        {
            var cars = CarsRepository.GetAllCars();
            // Logic on cars
            return cars;
        }

        public Car GetCarById(int id)
        {
            var car = CarsRepository.GetCarById(id);
            /// Logic on the car
            if (car == null) return null;
            return car;
        }

        public void AddCar(Car car)
        {
            CarsRepository.AddCar(car);
        }

        public void Remove(int carId)
        {
            CarsRepository.Remove(carId);
        }
    }
}