using MediatR;


namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
    public class UpdateSocialMediaCommand:IRequest
    {
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
