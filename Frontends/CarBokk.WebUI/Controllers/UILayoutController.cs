using Microsoft.AspNetCore.Mvc;

namespace CarBokk.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
