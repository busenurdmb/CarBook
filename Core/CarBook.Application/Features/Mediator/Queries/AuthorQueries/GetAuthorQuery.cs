using MediatR;
using CarBook.Application.Features.Mediator.Results.AuthorResults;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}
