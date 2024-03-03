using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using   CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Domain.Entities;

using CarBook.Infrastructure.Persistence.Context;

namespace CarBook.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carBookContext;

        public BlogRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public List<Blog> GetAllBlogsWithAuthors()
        {
            var values=_carBookContext.Blogs.Include(x=>x.Author).ToList();
            return values;
        }

        public List<Blog> GetAllBlogsWithAuthors(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAuthorIdAllBlogs(int id)
        {
            var values = _carBookContext.Blogs.Include(x => x.Author).Where(a => a.AuthorID == id).ToList();
            return values;
        }

        public List<Blog> GetBlogByAuthorId(int id)
        {
            var values = _carBookContext.Blogs.Include(x => x.Author).Where(y => y.BlogID == id).ToList();
            return values;
        }

       

        public List<Blog> GetLast3BlogsWithAuthors()
        {
            var values = _carBookContext.Blogs.Include(x => x.Author).OrderByDescending(x => x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
