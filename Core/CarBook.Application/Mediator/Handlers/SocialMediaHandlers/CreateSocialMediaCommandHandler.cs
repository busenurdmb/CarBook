using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class CreatePricingCommandHandler : IRequestHandler<CreateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;
        public CreatePricingCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new SocialMedia
            {
                Name = request.Name,
                Icon = request.Icon,
                Url = request.Url
            });
        }
    }
}
