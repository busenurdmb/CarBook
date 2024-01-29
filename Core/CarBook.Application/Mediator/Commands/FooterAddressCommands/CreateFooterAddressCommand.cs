using MediatR;

namespace CarBook.Application.Mediator.Commands.FooterAddressCommands
{
   public class CreateFooterAddressCommand:IRequest
    {
        
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
