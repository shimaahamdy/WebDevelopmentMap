using FirstMVC_WebApp_42.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FirstMVC_WebApp_42.Controllers
{
    public class GeneratedEmpController : Controller
    {
        // GET: GeneratedEmp
        static List<Employee> empLst = new List<Employee>()
        {
            new Employee(){ ID=1, Name= "test-1" },
            new Employee(){ ID=2, Name= "test-2" },
            new Employee(){ ID=3, Name= "test-3" },
            new Employee(){ ID=4, Name= "test-4" },
            new Employee(){ ID=5, Name= "test-5" }
        };

        public ActionResult getAll()
        {
            //ViewBag.emps = empLst;

            return View(empLst);
        }

        public ActionResult Details(int id)
        {
            var selectedEmp = empLst.FirstOrDefault(e => e.ID == id);

            //ViewBag.emp = selectedEmp;

            return View(selectedEmp);
        }

        public ActionResult Edit(int id)
        {
            var selectedEmp = empLst.FirstOrDefault(e => e.ID == id);

            //ViewBag.emp = selectedEmp;

            return View(selectedEmp);
        }

        [HttpPost]
        public ActionResult Edit(int id, string name)
        {
            var savedEmp = empLst.FirstOrDefault(e => e.ID == id);

            savedEmp.Name = name;

            return RedirectToAction("getAll");
        }
    }
}
