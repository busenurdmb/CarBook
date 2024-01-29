


using CarBook.Application.Mediator.Results.FooterAddressResult;
using MediatR;

namespace CarBook.Application.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
    {
        public int id { get; set; }

        public GetFooterAddressByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
