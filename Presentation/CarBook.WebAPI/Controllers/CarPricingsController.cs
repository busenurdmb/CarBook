using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using   CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using   CarBook.Application.Features.Mediator.Queries.LocationQueries;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var values = await _mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(values);
        }

        [HttpGet("GetCarPricingWithTimePeriodList")]
		public async Task<IActionResult> GetCarPricingWithTimePeriodList()
		{
			var values = await _mediator.Send(new GetCarPricingWithTimePeriodQuery());
			return Ok(values);
		}
	}
}
