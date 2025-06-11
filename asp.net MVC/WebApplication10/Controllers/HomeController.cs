using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<Product>ProductList    =new List<Product>()
        {
            new Product { id = 1, name = "Product 1", price = 10.00 ,picture="~/images/WhatsApp Image 2024-06-08 at 11.34.38_2f278c65.jpg" },
            new Product { id = 2, name = "Product 2", price = 20.00,picture="~/images/WhatsApp Image 2024-09-01 at 13.35.05_4d957973.jpg" },
            new Product { id = 3, name = "Product 3", price = 30.00,picture="~/images/WhatsApp Image 2024-09-01 at 15.18.30_c6e538be.jpg" }
        };
public ActionResult Index()
        {
            return View(ProductList);
        }
    }
}