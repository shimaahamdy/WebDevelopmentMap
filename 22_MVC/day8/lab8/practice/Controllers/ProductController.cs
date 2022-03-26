using Microsoft.AspNetCore.Mvc;
using practice.Models;
using System.Collections.Generic;

namespace practice.Controllers
{
    public class ProductController : Controller
    {
        List<Products> list = new List<Products>()
        {
            new Products() {Id = 1,Name = "shimaa"}
        };
        public IActionResult Index()
        {
            return View(list);
        }
    }
}
