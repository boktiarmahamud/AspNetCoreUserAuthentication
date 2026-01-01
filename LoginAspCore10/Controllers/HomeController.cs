using System.Diagnostics;
using LoginAspCore10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace LoginAspCore10.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext context;

        public HomeController(CodeFirstDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Login()
		{
			return View();
		}
        [HttpPost]
        [ValidateAntiForgeryToken]

		public IActionResult Login(UserTable user)
		{
            var myUser = context.UserTables.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
            if (myUser != null)
            {
                HttpContext.Session.SetString("userEmail", myUser.Email);
                return RedirectToAction("Dashboard");
			}
            else
            {
                ViewBag.Message = "Invalid Credentials";
			}
                return View();
		}

		public IActionResult Dashboard()
		{
            var userEmail = HttpContext.Session.GetString("userEmail");
            if (userEmail != null)
            {
                ViewBag.Message = userEmail;
            }
            else
            {
                return RedirectToAction("Login");
            }

            return View();
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
