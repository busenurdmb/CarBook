using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using   CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using   CarBook.Application.Interfaces.StatisticsInterfaces;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBlogCountQueryHandler : IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBlogCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogCount();
            return new GetBlogCountQueryResult
            {
                BlogCount = value
            };
        }
    }
}
