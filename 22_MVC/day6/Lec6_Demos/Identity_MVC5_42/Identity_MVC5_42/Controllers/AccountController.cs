using Identity_MVC5_42.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Identity_MVC5_42.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User usr)
        {
            //Check if valid user (ModelState.IsValid)
            //Insert user into database
            //Create identity for this user using Claims (Name,Password, Email)
            //OWIN Cookie Middleware, use identity to create cookie for this user to authenticate user
            //Redirect to Home/Index

            if (ModelState.IsValid)
            {
                MainDbContext context = new MainDbContext();

                //usr.Country = "";
                context.Users.Add(usr);
                context.SaveChanges();

                var userIdentity = new ClaimsIdentity(new List<Claim>()
                {
                        new Claim(ClaimTypes.Email, usr.Email),
                        new Claim("Name", usr.Name),
                        new Claim("Password", usr.Password)
                }, "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(userIdentity);  ///OWIN authentication manager

                return RedirectToAction("Index", "Home");

            }

            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User usr)
        {
            //Get User from database
            //Check if user not null
            //if Not Null {OWIN Cookie}
            //else return View

            MainDbContext context = new MainDbContext();

            var loggedUser = context.Users.FirstOrDefault(
                u => u.Email == usr.Email && u.Password == usr.Password
                );

            if (loggedUser != null)
            {
                var signInIdentity = new ClaimsIdentity(
                    new List<Claim>()
                    {
                        new Claim(ClaimTypes.Email, loggedUser.Email),
                        new Claim("Password", loggedUser.Password)
                    }, "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(signInIdentity);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name", "User is not Existed!");
                return View();
            }
        }

        public ActionResult Logout()
        {
            //Destroy Cookie for this user

            Request.GetOwinContext().Authentication.SignOut("AppCookie");
            return RedirectToAction("Login");
        }
    }
}