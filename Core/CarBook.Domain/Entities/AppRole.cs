using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleId { get; set; }
        public string AppRoleName { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
