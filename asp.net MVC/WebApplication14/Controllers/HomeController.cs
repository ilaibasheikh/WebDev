using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication14.Models;

namespace WebApplication14.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();//get data in rows so list from db
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)

        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["msg"] = "<script>alert('Data Inserted');</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg = "<script>alert('Failed to Insert');</script>";
                }

            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.id == id).FirstOrDefault();
            return View(row);

        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["msg1"] = "<script>alert('Data Updated');</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.msg1 = "<script>alert('Failed to Update');</script>";
                }

            }
            return View();

        }
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
            var row = db.Students.Where(model => model.id == id).FirstOrDefault();
                if(row != null)
                {
                    db.Entry(row).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["msg2"] = "<script>alert('Data Deleted');</script>";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.msg2 = "<script>alert('Failed to Delete');</script>";
                    }
                }
               
            }
            return RedirectToAction("Index");



        }
        public ActionResult Details (int id)
        {
            var row = db.Students.Where(model => model.id == id).FirstOrDefault();
            return View(row);

        }

    }
}