

using CarBook.Application.Interfaces;

namespace   CarBook.Application.Features.Mediator.Results.AuthorResults
{
    public class GetCheckAuthorQueryResult
    {
        public int AuthorID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public bool IsExist { get; set; }


    }
}
