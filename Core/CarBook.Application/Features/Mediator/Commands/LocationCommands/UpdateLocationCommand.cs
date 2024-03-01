using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}
