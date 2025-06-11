using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Home Page!";
            ViewBag.CurrentTime = DateTime.Now;

            string[] fruits = { "apple", "banana" };
            ViewBag.FruitsArray = fruits;

            ViewBag.SportsList = new List<string>()  { "football", "baseball" };

            Employee Ali = new Employee();
            Ali.EmpID = 1;
            Ali.EmpName = "Ali";
            Ali.EmpDesignation = "Software Engineer";

           ViewBag.Employee = Ali; 

            return View();
        }
    }
}