using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstEFEntities db = new DatabaseFirstEFEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data=db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(student s)
        {
            if(ModelState.IsValid)
            {
                db.students.AddObject(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["msg"] = "Data Inserted";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg = "Data Not Inserted";
                }
            }
           

            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.students.Where(model => model.id == id).FirstOrDefault();

            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(student s)
        {
            if (ModelState.IsValid)
            {
                // Cast the result of db.Entry(s) to DbEntityEntry<student> to access the State property
                DbEntityEntry<student> entry = (DbEntityEntry<student>)db.Entry(s);
                entry.State = System.Data.Entity.EntityState.Modified;

                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["msg1"] = "Data Edited";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg1 = "Data Not Edited";
                }
            }

            return View();
        }
    }
}