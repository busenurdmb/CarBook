

using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.LocationQueries;
using CarBook.Application.Mediator.Results.LocationResults;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class GetLocationQueryHandlers : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationQueryHandlers(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new  GetLocationQueryResult
            {
                Name = x.Name,
                LocationID = x.LocationID
            }).ToList();
        }
    }
}
