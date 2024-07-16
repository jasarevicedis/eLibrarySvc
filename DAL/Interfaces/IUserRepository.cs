using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserById(int userId);
        Task<List<User>> GetAllByRole(string role);
        Task<User> FindByEmail(string email);
        Task<User> FindByUsername(string username);

    }
}
