using Microsoft.AspNetCore.Mvc;

namespace CarBokk.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
