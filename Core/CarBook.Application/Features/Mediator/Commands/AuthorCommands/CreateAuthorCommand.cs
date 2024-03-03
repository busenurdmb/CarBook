using MediatR;
namespace CarBook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
