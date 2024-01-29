using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.LocationQueries;
using CarBook.Application.Mediator.Results.LocationResults;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandlers : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
        {
        private readonly IRepository<Location> _repository;

        public GetLocationByIdQueryHandlers(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            return new GetLocationByIdQueryResult
            {
                Name = value.Name,
                LocationID = value.LocationID
            };
        }
    }

    
}
