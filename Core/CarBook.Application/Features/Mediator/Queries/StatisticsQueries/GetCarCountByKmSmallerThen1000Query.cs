using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;

namespace CarBook.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByKmSmallerThen1000Query:IRequest<GetCarCountByKmSmallerThen1000QueryResult>
    {
    }
}
