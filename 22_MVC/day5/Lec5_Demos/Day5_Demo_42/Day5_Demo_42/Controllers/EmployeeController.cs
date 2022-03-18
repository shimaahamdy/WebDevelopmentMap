using Day5_Demo_42.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Day5_Demo_42.Controllers
{
    [AllowAnonymous]
    //[Authorize]

    //[Route("Emppp")]
    [RoutePrefix("Emppp")]
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{ ID=1, Name="test1", Age=10},
            new Employee{ ID=2, Name="test2", Age=20},
            new Employee{ ID=3, Name="test3", Age=30}
        };

        // GET: Employee
        [Route("Emp/getall/sss")]
        [myLogFilter]
        public ActionResult Index()
        {
            return View(employees);
        }

        [Route("")]
        public ActionResult test()
        {
            return View();
        }


        public ActionResult test2()
        {
            return View();
        }


        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [AllowAnonymous]

        [Route("~/Crt")]
        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        //[AcceptVerbs("POST, DELETE")]
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
                return RedirectToAction("Index");
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
