using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string name, string email)
        {
            if (name.Equals("") == true)
            {
                ModelState.AddModelError("name", "Please enter a name");
                ViewData["nameError"]= "*";
            }
            if (email.Equals("") == true)
            {
                ModelState.AddModelError("email", "Please enter email");
                ViewData["emailError"] = "*";
            }
            else
            {
                if(Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") == false)
                {
                    ModelState.AddModelError("email", "Please enter a valid email");
                    ViewData["emailError"] = "*";
                }
            }

            if (ModelState.IsValid)
            {
                ViewData["success"] = "<script>alert('Hello " + name + " ')</script>";
                ModelState.Clear();
            }
           

            return View();
        }
    }
}