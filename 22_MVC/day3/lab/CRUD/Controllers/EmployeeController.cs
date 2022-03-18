using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;
namespace CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        EMPLOYEESEntities context = new EMPLOYEESEntities();
        
        // GET: Employee (list all employees)
        public ActionResult Index()
        {
            SelectList departments = new SelectList(context.Depts.ToList(),
            "DeptID", "DeptName");
           

            ViewBag.departments = departments;
           
            return View(context.Emps.ToList());
        }
        [HttpPost]
        public ActionResult Index(int dep)
        {



           SelectList departments = new SelectList(context.Depts.ToList(),
          "DeptID", "DeptName");


            ViewBag.departments = departments;
           

            return View(context.Emps.Where(emp => emp.dID == dep).ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Emps.Find(id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            SelectList departments = new SelectList(context.Depts.ToList(),
               "DeptID", "DeptName");
            SelectList cities = new SelectList(context.Cities.ToList(),
                "CityID", "CityName");

            ViewBag.departments = departments;
            ViewBag.cities = cities;
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            try
            {
                context.Emps.Add(emp);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                SelectList departments = new SelectList(context.Depts.ToList(),
             "DeptID", "DeptName");
                SelectList cities = new SelectList(context.Cities.ToList(),
                    "CityID", "CityName");

                ViewBag.departments = departments;
                ViewBag.cities = cities;
                return View(emp);
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            SelectList departments = new SelectList(context.Depts.ToList(),
                "DeptID", "DeptName");
            SelectList cities = new SelectList(context.Cities.ToList(),
                "CityID", "CityName");

            ViewBag.departments = departments;
            ViewBag.cities = cities;
            return View(context.Emps.Find(id));
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Emp EditedEmp)
        {
            try
            {
                Emp emp = context.Emps.Find(id);
                emp.EmpFname = EditedEmp.EmpFname;
                emp.EmpLname = EditedEmp.EmpLname;
                emp.EmpSalary = EditedEmp.EmpSalary;
                emp.EmpHDate = EditedEmp.EmpHDate;
                emp.dID = EditedEmp.dID;
                emp.CtyID = EditedEmp.CtyID;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                SelectList departments = new SelectList(context.Depts.ToList(),
             "DeptID", "DeptName");
                SelectList cities = new SelectList(context.Cities.ToList(),
                    "CityID", "CityName");

                ViewBag.departments = departments;
                ViewBag.cities = cities;
                return View(EditedEmp);
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Emp emp = context.Emps.Find(id);
            return View(emp);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Emp emp = context.Emps.Find(id);
                context.Emps.Remove(emp);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult helper()
        {
            
            return View(context.Emps.ToList());
        }
    }
}
