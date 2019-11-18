using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string  Name { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
