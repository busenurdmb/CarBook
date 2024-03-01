using MediatR;


namespace CarBook.Application.Features.Mediator.Commands.PricingCommands
{
    public class UpdatePricingCommand : IRequest
    {
        public int PricingID { get; set; }
        public string Name { get; set; }
    }
}
