using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["message"] ="Hello laiba";
            ViewData["date"] = DateTime.Now;

            string[] fruits = {"apple", "banana", "orange", "grape" };
            ViewData["fruitsdata"] = fruits;

            ViewData["SportsList"] = new List<String>()
            {
                "Cricket",    "Football",
                "Hockey",
                "Tennis",
                "Baseball"
            };

            Employee Ali = new Employee();
            Ali.EmpID = 1;
            Ali.EmpName = "Ali";
            Ali.EmpDesignation = "Software Engineer";

            ViewData["Employee"] = Ali;
            return View();


        }
    }
}