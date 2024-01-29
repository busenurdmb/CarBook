using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery:IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
