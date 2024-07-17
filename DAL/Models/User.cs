using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string Username  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime JoinDate { get; set; }
        public int RoleId { get; set; }
        public Role UserRole { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
