using Microsoft.AspNetCore.Mvc;

namespace SustainabilitySimulator.MvcWebApplication.Controllers
{
    public class ScenarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DomesticElectricity()
        {
            return View();
        }

        public IActionResult ShowersAndBaths()
        {
            return View();
        }

    }
}
