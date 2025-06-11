using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db= new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    
        [HttpPost]
        public ActionResult Index(user s)
        {
            if (ModelState.IsValid)
            {
              
                var credentials=db.users.Where(model => model.username == s.username && model.password == s.password).FirstOrDefault();
                if (credentials != null)
                {
                    Session["id"] = credentials.id.ToString();
                    Session["username"] = credentials.username.ToString();
                    Session["password"] = credentials.password.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Invalid username or password";
                    return View();
                }

            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(user s)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(s);
                int a =db.SaveChanges();
                if (a > 0)
                {
                    TempData["SuccessMessage"] = "Registration Successful";
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    ViewBag.SuccessMessage = "Registration Failed";
                }
            }
            return View();
        }

    }
}
