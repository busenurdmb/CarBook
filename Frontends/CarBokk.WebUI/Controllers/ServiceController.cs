using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Authorization;

namespace CarBokk.WebUI.Controllers
{
    [AllowAnonymous]
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
