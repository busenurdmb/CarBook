using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.AppUserResults;
using CarBook.Application.Features.Mediator.Results.AuthorResults;

namespace   CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetCheckAuthorQuery : IRequest<GetCheckAuthorQueryResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
