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

        public User(int id, string username, string firstName, string lastName, string email, byte[] passwordHash, byte[] passwordSalt, DateTime joinDate, UserRole userRole)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            JoinDate = joinDate;
            UserRole = userRole;
        }

        public int Id { get; set; }
        public string Username  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime JoinDate { get; set; }
        public UserRole UserRole { get; set; }
    }
}
