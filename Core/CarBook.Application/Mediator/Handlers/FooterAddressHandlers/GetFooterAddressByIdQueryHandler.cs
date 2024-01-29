using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Queries.FooterAddressQueries;
using CarBook.Application.Mediator.Results.FooterAddressResult;

using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.id);
            return new GetFooterAddressByIdQueryResult
            {
                Address = values.Address,
                Description = values.Description,
                Email = values.Email,
                Phone = values.Phone,
                FooterAddressID = values.FooterAddressID
            };
        }
    }
}
