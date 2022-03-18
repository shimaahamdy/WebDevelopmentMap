using onException_HandleError.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onException_HandleError.Controllers
{
    //[Authorize(Roles = "Admin;Guest")]
    [Authorize]
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{ ID=1, Name="test1", Age=10},
            new Employee{ ID=2, Name="test2", Age=20},
            new Employee{ ID=3, Name="test3", Age=30}
        };

        // GET: Employee
        public ActionResult Index()
        {
            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [AllowAnonymous]
        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (string.IsNullOrEmpty(emp.Name))
            {
                ModelState.AddModelError("Name", "You must enter a name!");
            }
            if (emp.Age < 18)
            {
                ModelState.AddModelError("Age", "Age must be +18");
            }

            if (ModelState.IsValid)
            {
                employees.Add(emp);
                //   return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
