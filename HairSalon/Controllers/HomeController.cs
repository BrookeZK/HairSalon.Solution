using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/login")]
        public ActionResult Login(string userName)
        {
            return View(userName);
        }

        [HttpPost("/login")]
        public ActionResult Authenticate(string userName)
        {
            return View("Login", userName);
        }

    }
}
