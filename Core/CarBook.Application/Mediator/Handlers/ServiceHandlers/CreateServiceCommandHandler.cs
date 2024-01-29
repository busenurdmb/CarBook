using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateServiceCommand>
    {
        private readonly IRepository<Service> _repository;
        public CreatePricingCommandHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title
            });
        }
    }
}
