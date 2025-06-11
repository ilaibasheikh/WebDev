using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()

        {
            ViewData["message1"] = "laiba1 viewdata";
            ViewBag.message2 = "laiba2 viewbag";
            TempData["message3"] = "laiba3 tempdata";

            //string[]fruits= { "apple", "banana", "orange" };
            //TempData["FruitsArray"] = fruits;


            //return RedirectToAction("About");
            return View();
        }

        public ActionResult About()
        {
            if (TempData["message3"] != null)
            {
                TempData["message3"].ToString();
            }
            TempData.Keep();
            return View();
        }
        public ActionResult Contact()
        {
            if (TempData["message3"] != null)
            {
                TempData["message3"].ToString();
            }
            return View();
        }
    }
}