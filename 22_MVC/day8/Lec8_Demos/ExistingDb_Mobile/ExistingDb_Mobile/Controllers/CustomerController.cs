using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExistingDb_Mobile.Models;

namespace ExistingDb_Mobile.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CUSTOMERMDFContext context;
        public CustomerController(CUSTOMERMDFContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.customer.ToList());
        }
    }
}
