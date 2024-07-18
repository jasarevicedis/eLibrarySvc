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

        public User(string username, string firstName, string lastName, string email, byte[] passwordHash, byte[] passwordSalt, int roleId)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            RoleId = roleId;
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
        public Role Role { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
