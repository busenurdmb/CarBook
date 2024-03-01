using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int id { get; set; }

        public GetFooterAddressByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
