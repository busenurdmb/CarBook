using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CarBook.Dto.CarFeatureDtos;
using CarBook.Dto.ReviewDtos;

namespace CarBook.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailCommentsByCarIdComponentPartial:ViewComponent
	{
        private readonly IHttpClientFactory _httpClientFactory;
        public _CarDetailCommentsByCarIdComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.carid = id;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7071/api/Reviews?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultReviewByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
