using MVC_EF_42.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVC_EF_42.Controllers
{
    public class CityController : Controller
    {
        EMPLOYEESEntities context = new EMPLOYEESEntities();

        // GET: City
        public ActionResult Index()
        {
            return View(context.Cities.ToList());
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            return View(context.Cities.Find(id));
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            SelectList contryLst = new SelectList(context.Countries.ToList(),
                                            "countryID", "CountryName");

            ViewBag.countries = contryLst;

            return View(context.Cities.Find(id));
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, City cty)
        {
            try
            {
                var EditedCity = context.Cities.Find(id);

                //EditedCity.CityName = collection["CityName"];
                //EditedCity.cID = int.Parse(collection["cID"]);

                EditedCity.CityName = cty.CityName;
                EditedCity.cID = cty.cID;

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: City/Delete/5
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
