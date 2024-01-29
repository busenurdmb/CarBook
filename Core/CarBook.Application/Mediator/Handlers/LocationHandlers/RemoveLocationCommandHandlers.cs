using CarBook.Application.Interfaces;
using CarBook.Application.Mediator.Commands.LocationCommands;
using CarBook.Domain.Entities;
using MediatR;


namespace CarBook.Application.Mediator.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandlers : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;

        public RemoveLocationCommandHandlers(IRepository<Location> repository)
        {
            _repository = repository;
        }

        async Task IRequestHandler<RemoveLocationCommand>.Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
           await  _repository.RemoveAsync(value);
        }
    }
}
