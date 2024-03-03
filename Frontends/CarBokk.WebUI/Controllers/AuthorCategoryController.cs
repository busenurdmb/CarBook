using CarBook.Dto.AuthorDtos;
using CarBook.Dto.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CarBokk.WebUI.Controllers
{
    public class AuthorCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


                var id = User.Claims.FirstOrDefault(X => X.Type == "id").Value;
                if (id != null)
                {

                }

                
                var responseMessage = await client.GetAsync("https://localhost:7071/api/Categories");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                    return View(values);
                }

            }
            return View();
        }
    }
}
