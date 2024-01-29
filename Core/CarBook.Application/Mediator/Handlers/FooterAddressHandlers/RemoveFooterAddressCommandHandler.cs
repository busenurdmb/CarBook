

using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.FooterAddressCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAddressHandlers
{
    public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

        public RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

     

        public async Task Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            await _repository.RemoveAsync(value);
        }
    }
}
