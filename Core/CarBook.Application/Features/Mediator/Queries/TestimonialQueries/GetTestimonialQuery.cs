using MediatR;

using CarBook.Application.Features.Mediator.Results.TestimonialResults;

namespace CarBook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery:IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
