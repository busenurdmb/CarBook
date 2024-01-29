using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;
        public CreateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Feature
            {
                Name = request.Name 
            });

        }
    }
}
