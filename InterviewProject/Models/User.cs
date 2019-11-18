using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserProfile Profile { get; set; } //one to one
        public ICollection<Address> Address { get; set; } // one to many
        public ICollection<UserRole> UserRole { get; set; }//many to many
    }
}
