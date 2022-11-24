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

        public IActionResult BathsAndShowers()
        {
            return View();
        }

        public IActionResult ElectricityProduction()
        {
            return View();
        }

        public IActionResult VehicleMPG()
        {
            return View();
        }

    }
}
