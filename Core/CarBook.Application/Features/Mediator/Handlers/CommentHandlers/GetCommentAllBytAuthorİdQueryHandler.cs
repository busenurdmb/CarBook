using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Queries.CommentQuery;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Features.Mediator.Results.CommentResult;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CommetInterfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentAllBytAuthorİdQueryHandler : IRequestHandler<GetCommentAllBytAuthorİdQuery, List<GetCommentAllBytAuthoridQueryResult>>
    {
        private readonly ICommentRepository<Comment> _repository;

        public GetCommentAllBytAuthorİdQueryHandler(ICommentRepository<Comment> repository)
        {
            _repository = repository;
        }

        public Task<List<GetCommentAllBytAuthoridQueryResult>> Handle(GetCommentAllBytAuthorİdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
