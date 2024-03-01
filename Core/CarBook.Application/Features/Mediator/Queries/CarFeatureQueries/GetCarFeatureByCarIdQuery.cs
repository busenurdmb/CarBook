using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarBook.Application.Features.Mediator.Results.CarFeatureResults;

namespace CarBook.Application.Features.Mediator.Queries.CarFeatureQueries
{
    public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
    {
        public int Id { get; set; }

        public GetCarFeatureByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}
