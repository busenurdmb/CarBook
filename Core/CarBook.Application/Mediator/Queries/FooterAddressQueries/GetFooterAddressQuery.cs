

using CarBook.Application.Mediator.Results.FooterAddressResult;
using MediatR;

namespace CarBook.Application.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery:IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}
