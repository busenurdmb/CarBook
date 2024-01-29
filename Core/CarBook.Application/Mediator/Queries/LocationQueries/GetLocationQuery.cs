using CarBook.Application.Mediator.Results.LocationResults;
using MediatR;


namespace CarBook.Application.Mediator.Queries.LocationQueries
{
    public class GetLocationQuery:IRequest<List<GetLocationQueryResult>>
    {
    }
}
