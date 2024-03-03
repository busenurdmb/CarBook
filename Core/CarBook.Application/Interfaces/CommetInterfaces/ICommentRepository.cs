using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CommetInterfaces
{
    public interface ICommentRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);
        T GetById(int id);
        List<T> GetCommentsByBlogId(int id);
        public int GetCountCommentByBlog(int id);
        public List<T> GetCommentAllBytAuthorid(int id);
    }
}
