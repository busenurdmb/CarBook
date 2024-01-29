


using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.FooterAddressCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAddressHandlers
{
    public class CreateFooterAddressCommandHandlers : IRequestHandler<CreateFooterAddressCommand>
    {

        private readonly IRepository<FooterAddress> _Repository;

        public CreateFooterAddressCommandHandlers(IRepository<FooterAddress> repository)
        {
            _Repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await _Repository.CreateAsync(new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
        }
    }
}
