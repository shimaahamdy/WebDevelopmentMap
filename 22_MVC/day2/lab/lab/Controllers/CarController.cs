using lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab.Controllers
{
    public class CarController : Controller
    {
       
        public ActionResult GetAllCars()
        {

            ViewBag.cars = LoadDate.cars;
            return View();

        }
      
        public ActionResult Details(int id)
        {
            var selectedCar = LoadDate.cars.FirstOrDefault(e => e.Num == id);

            ViewBag.car = selectedCar;

            return View();
        }

      
        public ActionResult Create()
        {
            Car newCar = new Car();
            newCar.Color = "Red";
            newCar.Model = "Honda";
            newCar.Manfacture = "UCA";
            LoadDate.cars.Add(newCar);
            ViewBag.car = newCar;

            return View("Edit");

        }
        public ActionResult Edit(int id)
        {
            var selectedCar = LoadDate.cars.FirstOrDefault(e => e.Num == id);

            ViewBag.car = selectedCar;

            return View();
        }

        [HttpPost]
        public ActionResult Edit(int ID, string Color, string Model, string Manfacture)
        {
            var selectedCar = LoadDate.cars.FirstOrDefault(e => e.Num == ID);
            
            selectedCar.Color = Color;
            selectedCar.Model = Model;
            selectedCar.Manfacture = Manfacture;
          


            return RedirectToAction("GetAllCars");
        }

        public ActionResult Delete(int id)
        {
            var selectedCar = LoadDate.cars.FirstOrDefault(e => e.Num == id);
            LoadDate.cars.Remove(selectedCar);
            return RedirectToAction("GetAllCars");
        }
    }
}