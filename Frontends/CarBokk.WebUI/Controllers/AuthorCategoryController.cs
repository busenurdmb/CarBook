using CarBook.Dto.AuthorDtos;
using CarBook.Dto.BlogDtos;
using CarBook.Dto.CategoryDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CarBokk.WebUI.Controllers
{
    [Authorize(Roles = "Writer")]
    public class AuthorCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
           
                var client = _httpClientFactory.CreateClient();
             


                var responseMessage = await client.GetAsync("https://localhost:7071/api/Categories");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                    return View(values);
                }

            
            return View();
        }
        [HttpGet]
        public IActionResult CreateBlogbyCategory(int Id)
        {
            var id = User.Claims.FirstOrDefault(X => X.Type == "id").Value;
            if (id != null)
            {

            }
            var model = new CreatelogsByAuthorIdDto
            {

                CategoryID = Id,
                AuthorID = Convert.ToInt32(id)
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogbyCategory(CreatelogsByAuthorIdDto model)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PostAsync("https://localhost:7071/api/Blogs", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "AuthorBlog");
                }
            }
            return View();
        }
    }
}
