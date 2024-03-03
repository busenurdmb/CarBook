using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Tools;
using UdemyCarBook.Application.Tools;
using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(GetCheckAppUserQuery query)
        {
            var values = await _mediator.Send(query);
            if (values.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(values));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalıdır");
            }
        }

     
        [HttpPost("AuthorLogin")]
        public async Task<IActionResult> AuthorLogin(GetCheckAuthorQuery query)
        {
            var values = await _mediator.Send(query);
            if (values.IsExist)
            {

                return Created("", JwtTokenGenerator.GenerateToken(values));
            }
            else
            {
                return BadRequest("Kullanıcı adı veya şifre hatalıdır");
            }
        }


    }
}
