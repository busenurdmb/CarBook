using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;
using CarBook.Dto.BlogDtos;
using Microsoft.AspNetCore.Authorization;
using System.Text.Json;
using CarBook.Dto.CategoryDtos;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBook.Dto.AuthorDtos;
using System.Text;

namespace CarBokk.WebUI.Controllers
{
    [Authorize(Roles = "Writer")]
    public class AuthorBlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorBlogController(IHttpClientFactory httpClientFactory)
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
                var responseMessage = await client.GetAsync($"https://localhost:7071/api/Blogs/GetAuthorIdAllBlogs?id=" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<List<GetBlogsByAuthorIdDto>>(jsondata);
                    return View(value);
                }

            }
            return View();
        }
        public async Task<IActionResult> BlogList()
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
                var responseMessage = await client.GetAsync($"https://localhost:7071/api/Blogs/GetAuthorIdAllBlogs?id=" + id);
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<List<GetBlogsByAuthorIdDto>>(jsondata);
                    return View(value);
                }

            }
            return View();
        }

        [HttpGet]
        public  IActionResult Create()
        {
            
                var id = User.Claims.FirstOrDefault(X => X.Type == "id").Value;
                if (id != null)
                {

                }
                var model = new CreatelogsByAuthorIdDto
                {


                    AuthorID = Convert.ToInt32(id)
                };
                return View(model);
            
           
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatelogsByAuthorIdDto model)
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

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);


              
                var responseMessage = await client.GetAsync($"https://localhost:7071/api/Blogs/{id}");

                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsondata = await responseMessage.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<GetBlogById>(jsondata);
                    return View(value);
                }

            }
            return View();
            
}

        [HttpPost]
        public async Task<IActionResult> Update(GetBlogById model)
        {

            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var jsonData = JsonConvert.SerializeObject(model);
                StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var responseMessage = await client.PutAsync("https://localhost:7071/api/Blogs", stringContent);
                if (responseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "AuthorBlog");
                }



            }

            return View();
        }

    }
    }





