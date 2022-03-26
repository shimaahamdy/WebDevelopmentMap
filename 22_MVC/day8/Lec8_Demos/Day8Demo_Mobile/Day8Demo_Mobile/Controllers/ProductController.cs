using Day8Demo_Mobile.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day8Demo_Mobile.Controllers
{
    public class ProductController : Controller
    {
        //ProductDbContext context = new ProductDbContext();

        private readonly IConfiguration configuration;
        private readonly ProductDbContext dbContext;

        public ProductController(IConfiguration configuration, ProductDbContext dbContext)
        {
            this.configuration = configuration;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.config = configuration;
            return View();
        }

        public IActionResult GetAllProducts()
        {
            return View(dbContext.Products.ToList());
        }

    }
}
