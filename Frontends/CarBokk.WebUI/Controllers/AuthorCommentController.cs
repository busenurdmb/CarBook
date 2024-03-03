using CarBook.Dto.AuthorDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using CarBook.Dto.CommentDtos;
using CarBook.Dto.CategoryDtos;
using Microsoft.AspNetCore.Authorization;

namespace CarBokk.WebUI.Controllers
{
    [Authorize(Roles = "Writer")]
    public class AuthorCommentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorCommentController(IHttpClientFactory httpClientFactory)
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
                
                var responseMessage = await client.GetAsync("https://localhost:7071/api/Comments/GetCommentAllBytAuthorid?id=" +id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                    return View(values);
                }
               
            

            }
            return View();

          
        }
    }
}
