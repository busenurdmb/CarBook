

using MediatR;

namespace CarBook.Application.Mediator.Commands.LocationCommands
{
    public class CreateLocationCommand:IRequest
    {
    
        public string Name { get; set; }
    }
}
