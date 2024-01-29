

using CarBook.Application.Mediator.Results.LocationResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.LocationQueries
{
    public class GetLocationByIdQuery:IRequest<GetLocationByIdQueryResult>
    {
        public int id { get; set; }

        public GetLocationByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
