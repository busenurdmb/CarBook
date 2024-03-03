using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogsByAuthorIdQueryHandler : IRequestHandler<GetBlogsByAuthorIdQuery, List<GetBlogsByAuthorIdQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetBlogsByAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBlogsByAuthorIdQueryResult>> Handle(GetBlogsByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAuthorIdAllBlogs(request.Id);
            return values.Select(x => new GetBlogsByAuthorIdQueryResult
            {
                BlogID = x.BlogID,
                AuthorID = x.AuthorID,
                CategoryID = x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Title = x.Title

            }).ToList();
            
        }
    }
}
