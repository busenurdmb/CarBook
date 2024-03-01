using CarBook.Application.Features.Mediator.Results.LocationResults;
using MediatR;


namespace CarBook.Application.Features.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}
