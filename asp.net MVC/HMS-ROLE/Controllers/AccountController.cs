using System.Linq;
using System.Web.Mvc;
using HMS_ROLE.Models;
using HMS_ROLE;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController()
    {
        _context = new ApplicationDbContext();
    }

    // GET: Login
    public ActionResult Login()
    {
        return View();
    }

    // POST: Login
    [HttpPost]
    public ActionResult Login(string username, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            // Store user details in session
            Session["UserId"] = user.UserId;
            Session["Role"] = user.Role;
            return RedirectToAction("Index", "Home"); // Redirect to the homepage after successful login
        }

        // If login fails, show error message
        ModelState.AddModelError("", "Invalid login attempt.");
        return View();
    }

    // GET: Register
    public ActionResult Register()
    {
        return View();
    }

    // POST: Register
    [HttpPost]
    public ActionResult Register(string username, string password, string role)
    {
        var user = new User { Username = username, Password = password, Role = role };
        _context.Users.Add(user);
        _context.SaveChanges();

        return RedirectToAction("Login");
    }

    // GET: Logout
    public ActionResult Logout()
    {
        // Clear session on logout
        Session.Clear();
        return RedirectToAction("Login");
    }
}
