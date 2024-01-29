

using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FooterAddressQueries;
using CarBook.Application.Mediator.Results.FooterAddressResult;
using CarBook.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Windows.Markup;

namespace CarBook.Application.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandlers : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressQueryHandlers(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x=> new GetFooterAddressQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                Email=x.Email,
                Phone = x.Phone,
                FooterAddressID= x.FooterAddressID,
            }).ToList();
        }
    }
}
