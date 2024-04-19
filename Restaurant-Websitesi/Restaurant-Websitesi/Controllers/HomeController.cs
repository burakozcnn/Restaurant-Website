using Microsoft.AspNetCore.Mvc;
using Restaurant_Websitesi.Models;
using System.Diagnostics;

namespace Restaurant_Websitesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            ViewBag.LinkText = "Home";
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.LinkText = "Menu";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.LinkText = "About";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.LinkText = "Contact";
            return View();
        }
        public ActionResult ProductDetails()
        {
            ViewBag.LinkText = "Details";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}