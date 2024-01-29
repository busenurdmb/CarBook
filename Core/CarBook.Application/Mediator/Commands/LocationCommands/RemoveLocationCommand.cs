

using MediatR;

namespace CarBook.Application.Mediator.Commands.LocationCommands
{
    public class RemoveLocationCommand:IRequest
    {
        public int id { get; set; }

        public RemoveLocationCommand(int id)
        {
            this.id = id;
        }
    }
}
