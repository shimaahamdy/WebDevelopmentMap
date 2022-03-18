using NOAUTH.Contexts;
using NOAUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace NOAUTH.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // Register: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Client client)
        {
            if(ModelState.IsValid)
            {
                IdentityContext context = new IdentityContext();
                context.Clients.Add(client);
                context.SaveChanges();

                var ClinetIdentity = new ClaimsIdentity(new List<Claim>()
                {

                    new Claim(ClaimTypes.Name, client.Name),
                        new Claim("Password", client.Password)
                },"AppCookies");
                Request.GetOwinContext().Authentication.SignIn(ClinetIdentity);  ///OWIN authentication manager

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //Login: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Client client)
        {
            IdentityContext context = new IdentityContext();

            var loggedUser = context.Clients.FirstOrDefault(
                C => C.Name == client.Name && C.Password == C.Password
                );

            if (loggedUser != null)
            {
                var signInIdentity = new ClaimsIdentity(
                    new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, loggedUser.Name),
                         new Claim("Password", client.Password)
                    }, "AppCookies");

                Request.GetOwinContext().Authentication.SignIn(signInIdentity);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name", "Cleint is not Existed!");
                return View();
            }
            
        }

        //Logout
        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookies");
            return RedirectToAction("Login");
        }
    }
}