﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Show()
        {
            return "laiba"; 
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public int Studentid(int id)
        {
            return id;
        }
    }
}