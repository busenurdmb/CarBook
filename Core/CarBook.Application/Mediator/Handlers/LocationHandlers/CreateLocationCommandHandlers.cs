using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.LocationCommands;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandlers : IRequestHandler<CreateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public CreateLocationCommandHandlers(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Location
            {
                Name = request.Name,

            });
        }
    }
}
