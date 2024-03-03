using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using CarBook.Dto.AuthorDtos;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace CarBokk.WebUI.Controllers
{
    [Authorize(Roles = "Writer")]
    public class AuthorProfileController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorProfileController(IHttpClientFactory httpClientFactory)
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
           
                var responseMessage = await client.GetAsync($"https://localhost:7071/api/Authors/{id}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<ResultAuthorDto>(jsondata);
                    return View(value);
                }

            }
            return View();
            
        }
        [HttpGet]
        public async Task<IActionResult> Update()
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

                var responseMessage = await client.GetAsync($"https://localhost:7071/api/Authors/{id}");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<ResultAuthorDto>(jsondata);
                    return View(value);
                }

            }
            return View();

        }
        [HttpPost]
            public async Task<IActionResult> Update(ResultAuthorDto model)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7071/api/Authors", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "AuthorProfile");
                }



            }
            return View();

        }

    }
}
