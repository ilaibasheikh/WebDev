using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;


namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee e)
        {
            if (ModelState.IsValid==true)
            {
                ViewData["success"] = "<script>alert('Hi "+e.name+" ');</script>";
                ModelState.Clear();

            }
            return View();
        }

    }   
}