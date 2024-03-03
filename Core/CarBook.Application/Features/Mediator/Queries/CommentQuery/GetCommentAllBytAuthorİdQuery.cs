using CarBook.Application.Features.Mediator.Handlers.CommentHandlers;
using CarBook.Application.Features.Mediator.Results.CommentResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.CommentQuery
{
   public class GetCommentAllBytAuthorİdQuery:IRequest<List<GetCommentAllBytAuthoridQueryResult>>
    {
        public int Id { get; set; }

        public GetCommentAllBytAuthorİdQuery(int ıd)
        {
            Id = ıd;
        }
    }


}
