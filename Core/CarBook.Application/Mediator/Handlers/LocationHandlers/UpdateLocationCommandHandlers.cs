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
    public class UpdateLocationCommandHandlers : IRequestHandler<UpdateLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public UpdateLocationCommandHandlers(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.LocationID);
            value.Name = request.Name;
          await  _repository.UpdateAsync(value);
        }
    }
}
