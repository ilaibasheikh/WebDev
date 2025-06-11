using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee employee = new Employee();

            employee.Id = 1;
            employee.Name = "John Doe";
            employee.Age = 30;

            ViewBag.Employee1 = employee;
            ViewData["Employee2"] = employee;

            Employee emp = new Employee();

            emp.Id = 2;
            emp.Name = "bob Doe";
            emp.Age = 20;

            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(emp);

            return View(employees);
        }
    }
}