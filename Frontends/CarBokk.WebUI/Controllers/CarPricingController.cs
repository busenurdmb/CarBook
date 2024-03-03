using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;
using	 CarBook.Dto.CarPricingDtos;
using Microsoft.AspNetCore.Authorization;

namespace	CarBook.WebUI.Controllers
{
    [AllowAnonymous]
    public class CarPricingController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;
		public CarPricingController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IActionResult> Index()
		{
			ViewBag.v1 = "Paketler";
			ViewBag.v2 = "Araç Fiyat Paketleri";
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7071/api/CarPricings/GetCarPricingWithTimePeriodList");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultCarPricingListWithModelDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}
