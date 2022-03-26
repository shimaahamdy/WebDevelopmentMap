using Day8_Demo_42.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day8_Demo_42.Controllers
{
    public class ProductController : Controller
    {
        public ProductDbContext Context { get; }
        public ProductController(ProductDbContext context)
        {
            Context = context;
        }

        //ProductDbContext dbContext = new ProductDbContext()

        //List<Product> List = new List<Product>()
        //{
        //    new Product() { Id = 1, Name ="prod_1" },
        //    new Product() { Id = 2, Name ="prod_2" },
        //    new Product() { Id = 3, Name ="prod_3" }
        //};

        public IActionResult Index()
        {
            //return View(List);
            return View(Context.Products);
        }

        public ActionResult Calculate(int x, int y)
        {
            return Content((x + y).ToString());
        }

    }
}
