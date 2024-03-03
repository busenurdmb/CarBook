using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}

