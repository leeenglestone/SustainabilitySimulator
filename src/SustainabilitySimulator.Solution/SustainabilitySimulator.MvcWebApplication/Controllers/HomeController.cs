using Microsoft.AspNetCore.Mvc;
using SustainabilitySimulator.MvcWebApplication.Models;
using System.Diagnostics;

namespace SustainabilitySimulator.MvcWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "SustainabilitySimulator.com";

            return View();
        }

        [Route("/about/")]
        public IActionResult About()
        {
            ViewBag.Title = "About SustainabilitySimulator.com";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}