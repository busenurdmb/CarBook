using Microsoft.AspNetCore.Mvc;

namespace CarBokk.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
