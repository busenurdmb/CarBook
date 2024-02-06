using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.ServiceDtos;

namespace CarBokk.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
