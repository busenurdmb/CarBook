


using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.FooterAddressCommands;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Mediator.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAddress> _repository;

      

        public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.FooterAddressID);
            value.Description = request.Description;
            value.Address=request.Address;
            value.Phone = request.Phone;
            value.Email = request.Email;
           await _repository.UpdateAsync(value);
        }
    }
}
