using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.AppUserQueries;
using CarBook.Application.Features.Mediator.Results.AppUserResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Results.AuthorResults;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetCheckAuthorQueryHandler : IRequestHandler<GetCheckAuthorQuery, GetCheckAuthorQueryResult>
    {
        private readonly IRepository<Author> _appAutherRepository;
        private readonly IRepository<AppRole> _appRoleRepository;

        public GetCheckAuthorQueryHandler(IRepository<Author> appAutherRepository, IRepository<AppRole> appRoleRepository)
        {
            _appAutherRepository = appAutherRepository;
            _appRoleRepository = appRoleRepository;
        }

        public async Task<GetCheckAuthorQueryResult> Handle(GetCheckAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAuthorQueryResult();
            var user = await _appAutherRepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.Role = (await _appRoleRepository.GetByFilterAsync(x => x.AppRoleId == user.AppRoleId)).AppRoleName;
                values.IsExist = true;
                values.Username = user.Username;
               values.AuthorID = user.AuthorID;
                values.Surname= user.Surname;
                values.Email = user.Email;
                values.Description=user.Description;
                values.Name=user.Name;
                
            }
            return values;
        }
    }
}
