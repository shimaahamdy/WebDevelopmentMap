using CarAPI.Entities;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarAPI.Controllers
{
    public class CarController : ApiController
    {
        public ICarService CarService { get; set; }

        public CarController(ICarService carService)
        {
            //CarService = new CarService(new CarsRepository(new InMemoryContext()));
            CarService = carService;
        }

        [HttpGet]
        public List<Car> Get()
        {
            return CarService.GetAll();
        }

        [HttpGet]
        [Route("{id:int}")]
        public Car Get(int id)
        {
            return CarService.GetCarById(id);
        }
       
        [HttpPost]
        public void Post([FromBody]Car car)
        {
            CarService.AddCar(car);
        }

        [HttpDelete]
        public void Delete(int carId)
        {
            CarService.Remove(carId);
        }

    }
}
