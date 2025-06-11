using System.Linq;
using System.Web.Mvc;
using HMS.Models;
using Q1.Models;

namespace Q1.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            // Find user by username
            var user = _context.Users
                .Where(u => u.Username == username)
                .FirstOrDefault();

            if (user != null && user.PasswordHash == password) // Simple password check, replace with proper hashing later
            {
                // Create session
                Session["UserID"] = user.UserID;
                Session["Username"] = user.Username;
                Session["RoleID"] = user.RoleID;

                // Redirect based on role
                if (user.RoleID == 1) // Assuming RoleID = 1 is Admin
                {
                    return RedirectToAction("AdminDashboard", "Home");
                }
                else if (user.RoleID == 2) // Assuming RoleID = 2 is Doctor
                {
                    return RedirectToAction("DoctorDashboard", "Home");
                }
                else if (user.RoleID == 3) // Assuming RoleID = 3 is Patient
                {
                    return RedirectToAction("PatientDashboard", "Home");
                }
            }

            // If login fails
            ModelState.AddModelError("", "Invalid username or password.");
            return View();
        }

        // Logout action
        public ActionResult Logout()
        {
            // Clear the session
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
