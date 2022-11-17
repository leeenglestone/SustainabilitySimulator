using Microsoft.AspNetCore.Mvc;

namespace SustainabilitySimulator.MvcWebApplication.Controllers
{
    public class ScenariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
